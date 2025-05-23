using System;
using System.Threading.Tasks;
using GraphQL.Client.Http;
using MondayApi.ActivityLogs;
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
        public const string EnvironmentDebugShowQuery = "DEBUG_SHOWQUERY";
        public const string EnvironmentDebugShowResponse = "DEBUG_SHOWRESPONSE";

        private readonly string baseURL = "https://api.monday.com/v2";
        private readonly GraphQLHttpClient client;

        private string queryResponse = string.Empty;

        public MondayApiClient([System.Diagnostics.CodeAnalysis.AllowNull] string token) {
            Utils.Utils.RequireArgument(nameof(token), string.IsNullOrWhiteSpace(token) ? null : token);

            client = new GraphQLHttpClient(baseURL, new Utils.DebugSerializer(captureResponse: response => queryResponse = response));

            client.HttpClient.DefaultRequestHeaders.Add("Authorization", token);
            client.HttpClient.DefaultRequestHeaders.Add("Accept", "application/json");
            client.HttpClient.DefaultRequestHeaders.Add("API-Version", "2025-04");
        }

        public Task<Query> RunQuery(QueryQueryBuilder queryBuilder) => Run<Query>(queryBuilder);
        public Task<Mutation> RunMutation(MutationQueryBuilder queryBuilder) => Run<Mutation>(queryBuilder);
        public Task<Mutation> RunFileMutation(MutationQueryBuilder queryBuilder, System.IO.Stream file, string filename) => RunFileMutation<Mutation>(queryBuilder, file, filename);

        public Task<T> Run<T>(GraphQlQueryBuilder queryOrMutationBuilder) {
            string? query = null;
#if DEBUG
            if (Environment.GetEnvironmentVariable(EnvironmentDebugShowQuery) != null) {
                query = queryOrMutationBuilder.Build(Formatting.Indented);
                Console.WriteLine(query);
            }
#endif
            if (query == null)
                query = queryOrMutationBuilder.Build();

            return Run<T>(new GraphQL.GraphQLRequest(query));
        }
        public Task<T> RunFileMutation<T>(GraphQlQueryBuilder queryBuilder, System.IO.Stream file, string filename) {
            string? query = null;
#if DEBUG
            if (Environment.GetEnvironmentVariable(EnvironmentDebugShowQuery) != null) {
                query = queryBuilder.Build(Formatting.Indented);
                Console.WriteLine(query);
            }
#endif
            if (query == null)
                query = queryBuilder.Build();

            return Run<T>(new Utils.MondayFileUploadRequest(query, file, filename));
        }

        public async Task<T> Run<T>(GraphQL.GraphQLRequest request) {
            GraphQL.GraphQLResponse<T> response;
            try {
                response = await client.SendQueryAsync<T>(request);
            } catch (Newtonsoft.Json.JsonSerializationException) {
                // attempt to convert to MondayApiError. If it fails, throw original JsonSerializationException
                if (Utils.Utils.TryDeserializeMondayApiError(queryResponse, out var mondayApiError))
                    throw new AggregateException(new MondayException(mondayApiError));
                throw;
#if DEBUG
            } catch (Newtonsoft.Json.JsonReaderException) {
                if (Environment.GetEnvironmentVariable(EnvironmentDebugShowResponse) != null)
                    Console.WriteLine(queryResponse);
                throw;
#endif
            }

            if (response.Errors != null)
                throw MondayException.FromErrors(response.Errors);
            if (response.Data == null) {
                if (Utils.Utils.TryDeserializeMondayApiError(queryResponse, out var mondayApiError))
                    throw new AggregateException(new MondayException(mondayApiError));
                throw new AggregateException(new MondayException(queryResponse));
            }

#if DEBUG
            if (Environment.GetEnvironmentVariable(EnvironmentDebugShowResponse) != null)
                Console.WriteLine(queryResponse);
#endif

            return response.Data;
        }

        public IActivityLogActions ActivityLogs => new ActivityLogActions(this);
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
