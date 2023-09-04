using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MondayApi.Schema;

//https://developer.monday.com/api-reference/docs/groups
namespace MondayApi.Groups {
    public class GroupActions : IGroupActions {
        private readonly IMondayApiClient client;
        public GroupActions(IMondayApiClient client) {
            this.client = client;
        }

        public async Task<IEnumerable<Group>> GetAsync(int boardID) {
            var ids = new GraphQlQueryParameter<IEnumerable<int?>>(null, new int?[] { boardID });

            var query = new QueryQueryBuilder().WithBoards(new BoardQueryBuilder().WithGroups(new GroupQueryBuilder().WithAllScalarFields()), ids: ids);
            var response = await client.RunQuery(query);
            return response.Boards?.FirstOrDefault()?.Groups;
        }

        public async Task<Group> GetOneAsync(int boardID, string groupID) {
            var boardIDs = new GraphQlQueryParameter<IEnumerable<int?>>(null, new int?[] { boardID });
            var groupIDs = new GraphQlQueryParameter<IEnumerable<string>>(null, new string[] { groupID });

            var query = new QueryQueryBuilder().WithBoards(new BoardQueryBuilder().WithGroups(new GroupQueryBuilder().WithAllScalarFields(), ids: groupIDs), ids: boardIDs);
            var response = await client.RunQuery(query);
            return response.Boards?.FirstOrDefault()?.Groups?.FirstOrDefault();
        }
    }
}
