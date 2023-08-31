using GraphQL.Client.Http;
using GraphQL.Client.Serializer.Newtonsoft;

namespace MondayApi {
    public class MondayApiClient : IMondayApiClient {
        private readonly string baseURL = "https://api.monday.com/v2";
        private readonly GraphQLHttpClient client;

        public MondayApiClient(string token) {
            client = new GraphQLHttpClient(baseURL, new NewtonsoftJsonSerializer());

            client.HttpClient.DefaultRequestHeaders.Add("Authorization", token);
            client.HttpClient.DefaultRequestHeaders.Add("Accept", "application/json");
        }
    }
}
