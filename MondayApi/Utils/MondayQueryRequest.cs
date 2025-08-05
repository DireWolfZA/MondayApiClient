using GraphQL.Client.Http;

namespace MondayApi.Utils {
    // as of 2025/08/05 monday requests now require provided parameters to have values
    //  variables: Expected object, received null
    //  operationName: must be a string
    //    provide an operation name, and you get `Unknown operation named "{operation name}"`
    // simple request that doesn't even include `variables` or `operationName` - somehow this works:
    public class MondayQueryRequest : GraphQLHttpRequest {
        public MondayQueryRequest() { }
        public MondayQueryRequest(string query) {
            Query = query;
        }
    }
}
