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

        public async Task<IEnumerable<User>> Get(int? pageNumber = null, int? numPerPage = null) {
            var query = new QueryQueryBuilder().WithUsers(
                new UserQueryBuilder().WithAllScalarFields().ExceptEncryptApiToken(),
                page: pageNumber,
                limit: numPerPage
            );
            var response = await client.RunQuery(query);
            return response.Users;
        }

        public async Task<User> GetOne(string id) {
            var query = new QueryQueryBuilder().WithUsers(
                new UserQueryBuilder().WithAllScalarFields().ExceptEncryptApiToken(),
                ids: new string[] { id }
            );
            var response = await client.RunQuery(query);
            return response.Users?.FirstOrDefault();
        }
    }
}
