using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MondayApi.Schema;

//https://developer.monday.com/api-reference/reference/users
namespace MondayApi.Users {
    public class UserActions : IUserActions {
        private readonly IMondayApiClient client;
        public UserActions(IMondayApiClient client) {
            this.client = client;
        }

        private UserQueryBuilder getUserQueryBuilder() =>
            new UserQueryBuilder().WithAllScalarFields().ExceptEncryptApiToken();

        public async Task<IEnumerable<User>> Get(int? pageNumber = null, int? numPerPage = null, bool? inactive = null) {
            var query = new QueryQueryBuilder().WithUsers(
                getUserQueryBuilder(),
                page: pageNumber,
                limit: numPerPage,
                nonActive: inactive
            );
            var response = await client.RunQuery(query);
            return response.Users!;
        }

        public async Task<User?> GetOne(string id) {
            var query = new QueryQueryBuilder().WithUsers(
                getUserQueryBuilder(),
                ids: new string[] { id }
            );
            var response = await client.RunQuery(query);
            return response.Users?.FirstOrDefault();
        }

        public async Task<User?> GetOneIncludeInactive(string id) {
            var query = new QueryQueryBuilder().WithUsers(
                getUserQueryBuilder(),
                ids: new string[] { id },
                alias: "getActiveUser"
            ).WithUsers(
                getUserQueryBuilder(),
                ids: new string[] { id },
                nonActive: true,
                alias: "getInactiveUser"
            );
            var response = await client.Run<Dictionary<string, List<User>>>(query);
            return response.Values.FirstOrDefault(q => q.Count > 0).FirstOrDefault();
        }
    }
}
