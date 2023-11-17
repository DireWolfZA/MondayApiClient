using System;
using System.Threading.Tasks;
using GraphQL.Client.Http;
using MondayApi.Assets;
using MondayApi.Boards;
using MondayApi.Columns;
using MondayApi.Groups;
using MondayApi.Items;
using MondayApi.Schema;
using MondayApi.Subitems;
using MondayApi.Updates;
using MondayApi.Users;
using MondayApi.Workspaces;

namespace MondayApi {
    public class MondayApiClient : IMondayApiClient {
        private readonly string baseURL = "https://api.monday.com/v2";
        private readonly GraphQLHttpClient client;
        public const string EnvironmentDebugShowQuery = "DEBUG_SHOWQUERY";
        public const string EnvironmentDebugShowResponse = "DEBUG_SHOWRESPONSE";

        public MondayApiClient(string token) {
            client = new GraphQLHttpClient(baseURL, new DebugSerializer(captureResponse: response => queryResponse = response));

            client.HttpClient.DefaultRequestHeaders.Add("Authorization", token);
            client.HttpClient.DefaultRequestHeaders.Add("Accept", "application/json");
            client.HttpClient.DefaultRequestHeaders.Add("API-Version", "2023-10");
        }

        private string queryResponse;
        public async Task<Query> RunQuery(QueryQueryBuilder queryBuilder) {
            string query = null;
#if DEBUG
            if (Environment.GetEnvironmentVariable(EnvironmentDebugShowQuery) != null) {
                query = queryBuilder.Build(Formatting.Indented);
                Console.WriteLine(query);
            }
#endif
            if (query == null)
                query = queryBuilder.Build();

            GraphQL.GraphQLResponse<Query> response;
            try {
                response = await client.SendQueryAsync<Query>(new GraphQL.GraphQLRequest(query));
            } catch (Newtonsoft.Json.JsonSerializationException) {
                // attempt to convert to MondayApiError. If it fails, throw original JsonSerializationException
                if (Utils.TryDeserializeMondayApiError(queryResponse, out var mondayApiError))
                    throw new AggregateException(new MondayException(mondayApiError));
                throw;
            }

            if (response.Errors != null)
                throw MondayException.FromErrors(response.Errors);
            if (response.Data == null)
                throw new AggregateException(new MondayException(queryResponse));

#if DEBUG
            if (Environment.GetEnvironmentVariable(EnvironmentDebugShowResponse) != null)
                Console.WriteLine(queryResponse);
#endif

            return response.Data;
        }

        public async Task<Mutation> RunMutation(MutationQueryBuilder queryBuilder) {
            string query = null;
#if DEBUG
            if (Environment.GetEnvironmentVariable(EnvironmentDebugShowQuery) != null) {
                query = queryBuilder.Build(Formatting.Indented);
                Console.WriteLine(query);
            }
#endif
            if (query == null)
                query = queryBuilder.Build();

            GraphQL.GraphQLResponse<Mutation> response;
            try {
                response = await client.SendMutationAsync<Mutation>(new GraphQL.GraphQLRequest(query));
            } catch (Newtonsoft.Json.JsonSerializationException) {
                if (Utils.TryDeserializeMondayApiError(queryResponse, out var mondayApiError))
                    throw new AggregateException(new MondayException(mondayApiError));
                throw;
            }

            if (response.Errors != null)
                throw MondayException.FromErrors(response.Errors);
            if (response.Data == null)
                throw new AggregateException(new MondayException(queryResponse));

#if DEBUG
            if (Environment.GetEnvironmentVariable(EnvironmentDebugShowResponse) != null)
                Console.WriteLine(queryResponse);
#endif

            return response.Data;
        }

        public async Task<Mutation> RunFileMutation(MutationQueryBuilder queryBuilder, System.IO.Stream file, string filename) {
            string query = null;
#if DEBUG
            if (Environment.GetEnvironmentVariable(EnvironmentDebugShowQuery) != null) {
                query = queryBuilder.Build(Formatting.Indented);
                Console.WriteLine(query);
            }
#endif
            if (query == null)
                query = queryBuilder.Build();

            GraphQL.GraphQLResponse<Mutation> response;
            try {
                response = await client.SendMutationAsync<Mutation>(new MondayFileUploadRequest(query, file, filename));
            } catch (Newtonsoft.Json.JsonSerializationException) {
                if (Utils.TryDeserializeMondayApiError(queryResponse, out var mondayApiError))
                    throw new AggregateException(new MondayException(mondayApiError));
                throw;
            }

            if (response.Errors != null)
                throw MondayException.FromErrors(response.Errors);
            if (response.Data == null)
                throw new AggregateException(new MondayException(queryResponse));

#if DEBUG
            if (Environment.GetEnvironmentVariable(EnvironmentDebugShowResponse) != null)
                Console.WriteLine(queryResponse);
#endif

            return response.Data;
        }

        public IAssetActions Assets => new AssetActions(this);
        public IBoardActions Boards => new BoardActions(this);
        public IColumnActions Columns => new ColumnActions(this);
        public IGroupActions Groups => new GroupActions(this);
        public IItemActions Items => new ItemActions(this);
        public ISubitemActions Subitems => new SubitemActions(this);
        public IUpdateActions Updates => new UpdateActions(this);
        public IUserActions Users => new UserActions(this);
        public IWorkspaceActions Workspaces => new WorkspaceActions(this);
    }
}
