using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using GraphQL;
using GraphQL.Client.Abstractions.Websocket;
using GraphQL.Client.Serializer.Newtonsoft;
using Newtonsoft.Json;

namespace MondayApi.Utils {
    // thanks to https://github.com/graphql-dotnet/graphql-client/issues/527#issuecomment-1655503961
    internal class DebugSerializer : IGraphQLWebsocketJsonSerializer {
        readonly NewtonsoftJsonSerializer implementation = new NewtonsoftJsonSerializer();
        readonly Action<string> captureResponse;

        public DebugSerializer(Action<string> captureResponse) => this.captureResponse = captureResponse;
        public byte[] SerializeToBytes(GraphQLWebSocketRequest request) => implementation.SerializeToBytes(request);
        public Task<WebsocketMessageWrapper> DeserializeToWebsocketResponseWrapperAsync(Stream stream) => implementation.DeserializeToWebsocketResponseWrapperAsync(stream);
        public GraphQLWebSocketResponse<TResponse> DeserializeToWebsocketResponse<TResponse>(byte[] bytes) => implementation.DeserializeToWebsocketResponse<TResponse>(bytes);
        public string SerializeToString(GraphQLRequest request) => implementation.SerializeToString(request);

        public async Task<GraphQLResponse<TResponse>> DeserializeFromUtf8StreamAsync<TResponse>(Stream stream, CancellationToken cancellationToken) {
            using (var ms = new MemoryStream()) {
                await stream.CopyToAsync(ms);
                ms.Position = 0;

                // re-implemented private method `Task<T> NewtonsoftJsonSerializer.DeserializeFromUtf8Stream<T>(Stream stream)`,
                //  which is called by public method `Task<GraphQLResponse<TResponse>> NewtonsoftJsonSerializer.DeserializeFromUtf8StreamAsync<TResponse>(Stream stream, CancellationToken cancellationToken)`
                using (var sr = new StreamReader(ms)) {
                    // capture response string and reset position
                    captureResponse(await sr.ReadToEndAsync());
                    ms.Position = 0;

                    using (JsonReader reader = new JsonTextReader(sr)) {
                        var serializer = JsonSerializer.Create(implementation.JsonSerializerSettings);
                        return serializer.Deserialize<GraphQLResponse<TResponse>>(reader);
                    }
                }
            }
        }
    }
}
