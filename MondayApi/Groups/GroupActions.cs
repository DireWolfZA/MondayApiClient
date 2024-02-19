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

        public async Task<IEnumerable<Group>> GetAsync(string boardID) {
            var query = new QueryQueryBuilder().WithBoards(
                new BoardQueryBuilder().WithGroups(new GroupQueryBuilder().WithAllScalarFields()),
                ids: Utils.GetParameterToMulti(boardID)
            );
            var response = await client.RunQuery(query);
            return response.Boards?.FirstOrDefault()?.Groups;
        }

        public async Task<Group> GetOneAsync(string boardID, string groupID) {
            var query = new QueryQueryBuilder().WithBoards(
                new BoardQueryBuilder().WithGroups(
                    new GroupQueryBuilder().WithAllScalarFields(),
                    ids: Utils.GetParameterToMulti(groupID)
                ),
                ids: Utils.GetParameterToMulti(boardID)
            );
            var response = await client.RunQuery(query);
            return response.Boards?.FirstOrDefault()?.Groups?.FirstOrDefault();
        }

        public async Task<Group> CreateAsync(string boardID, string title, string color = null, string relativeTo = null, PositionRelative? positionRelative = null) {
            Utils.RequireArgument(nameof(boardID), boardID);
            Utils.RequireArgument(nameof(title), title);

            var mutation = new MutationQueryBuilder().WithCreateGroup(
                new GroupQueryBuilder().WithAllScalarFields(),
                boardID: boardID,
                groupName: title,
                groupColor: color,
                relativeTo: relativeTo,
                positionRelativeMethod: positionRelative
            );

            var response = await client.RunMutation(mutation);
            return response.CreateGroup;
        }

        public async Task<Group> UpdateAsync(string boardID, string groupID, GroupAttributes attribute, string newValue) {
            var mutation = new MutationQueryBuilder().WithUpdateGroup(new GroupQueryBuilder().WithAllScalarFields(), boardID, groupID, attribute, newValue);

            var response = await client.RunMutation(mutation);
            return response.UpdateGroup;
        }

        public async Task<Group> DeleteAsync(string boardID, string groupID) {
            var mutation = new MutationQueryBuilder().WithDeleteGroup(new GroupQueryBuilder().WithAllScalarFields(), boardID, groupID);

            var response = await client.RunMutation(mutation);
            return response.DeleteGroup;
        }
    }
}
