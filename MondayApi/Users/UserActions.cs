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
            var query = new QueryQueryBuilder().WithUsers(
                new UserQueryBuilder().WithAllScalarFields(),
                limit: Utils.GetParameter<int?>(numPerPage),
                page: Utils.GetParameter<int?>(pageNumber)
            );
            var response = await client.RunQuery(query);
            return response.Users;
        }

        public async Task<User> GetOneAsync(string id) {
            var query = new QueryQueryBuilder().WithUsers(
                new UserQueryBuilder().WithAllScalarFields(),
                ids: Utils.GetParameterToMulti(id)
            );
            var response = await client.RunQuery(query);
            return response.Users?.FirstOrDefault();
        }
    }
}
