using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MondayApi.Schema;

//https://developer.monday.com/api-reference/docs/users
namespace MondayApi.Users {
    public class UserActions : IUserActions {
        private readonly IMondayApiClient client;
        public UserActions(IMondayApiClient client) {
            this.client = client;
        }

        public async Task<IEnumerable<User>> GetAsync(int pageNumber, int numPerPage) {
            var limit = new GraphQlQueryParameter<int?>(null, defaultValue: numPerPage);
            var page = new GraphQlQueryParameter<int?>(null, defaultValue: pageNumber);

            var query = new QueryQueryBuilder().WithUsers(new UserQueryBuilder().WithAllScalarFields(), limit: limit, page: page);
            var response = await client.RunQuery(query);
            return response.Users;
        }

        public async Task<User> GetOneAsync(string id) {
            var ids = new GraphQlQueryParameter<IEnumerable<string>>(null, defaultValue: new string[] { id });

            var query = new QueryQueryBuilder().WithUsers(new UserQueryBuilder().WithAllScalarFields(), ids: ids);
            var response = await client.RunQuery(query);
            return response.Users?.FirstOrDefault();
        }
    }
}
