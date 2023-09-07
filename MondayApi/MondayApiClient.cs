using System;
using System.Threading.Tasks;
using GraphQL.Client.Http;
using MondayApi.Boards;
using MondayApi.Columns;
using MondayApi.Groups;
using MondayApi.Items;
using MondayApi.Schema;
using MondayApi.Subitems;
using MondayApi.Users;

namespace MondayApi {
    public class MondayApiClient : IMondayApiClient {
        private readonly string baseURL = "https://api.monday.com/v2";
        private readonly GraphQLHttpClient client;

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
            if (Environment.GetEnvironmentVariable("DEBUG") != null) {
                query = queryBuilder.Build(Formatting.Indented);
                Console.WriteLine(query);
            }
#endif
            if (query == null)
                query = queryBuilder.Build();

            var response = await client.SendQueryAsync<Query>(new GraphQL.GraphQLRequest(query));
            if (response.Errors != null)
                throw MondayException.FromErrors(response.Errors);
            if (response.Data == null)
                throw new MondayException(queryResponse);

            return response.Data;
        }

        public IBoardActions Boards => new BoardActions(this);
        public IColumnActions Columns => new ColumnActions(this);
        public IGroupActions Groups => new GroupActions(this);
        public IItemActions Items => new ItemActions(this);
        public ISubitemActions Subitems => new SubitemActions(this);
        public IUserActions Users => new UserActions(this);
    }
}
