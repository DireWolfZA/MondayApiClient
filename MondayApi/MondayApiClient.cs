﻿using System;
using System.Threading.Tasks;
using GraphQL.Client.Http;
using GraphQL.Client.Serializer.Newtonsoft;
using MondayApi.Schema;

namespace MondayApi {
    public class MondayApiClient : IMondayApiClient {
        private readonly string baseURL = "https://api.monday.com/v2";
        private readonly GraphQLHttpClient client;

        public MondayApiClient(string token) {
            client = new GraphQLHttpClient(baseURL, new NewtonsoftJsonSerializer());

            client.HttpClient.DefaultRequestHeaders.Add("Authorization", token);
            client.HttpClient.DefaultRequestHeaders.Add("Accept", "application/json");
        }

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

            return response.Data;
        }
    }
}
