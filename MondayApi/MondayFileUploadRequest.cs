using System.IO;
using System.Net.Http;
using GraphQL.Client.Abstractions;
using GraphQL.Client.Http;

namespace MondayApi {
    // thanks to https://github.com/graphql-dotnet/graphql-client/issues/216#issuecomment-625118457
    public class MondayFileUploadRequest : GraphQLHttpRequest {
        public MondayFileUploadRequest() { }
        public MondayFileUploadRequest(string query, Stream file, string filename) {
            Query = query;
            File = file;
            Filename = filename;
        }

        public Stream File { get; set; }
        public string Filename { get; set; }

        public override HttpRequestMessage ToHttpRequestMessage(GraphQLHttpClientOptions options, IGraphQLJsonSerializer serializer) {
            Utils.RequireArgument(nameof(File), File);
            Utils.RequireArgument(nameof(Filename), Filename);

            return new HttpRequestMessage(HttpMethod.Post, "https://api.monday.com/v2/file") { // monday file uploads go to special endpoint
                Content = new MultipartFormDataContent("Upl----") {
                    { new StringContent(Query), QUERY_KEY },
                    { new StringContent("{\"upload\":\"variables.file\"}"), "map" }, // map $file variable to `upload` HTTP content item
                    { new StreamContent(File), "upload", Filename },
                },
            };
        }
    }
}
