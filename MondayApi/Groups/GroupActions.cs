using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MondayApi.Schema;

//https://developer.monday.com/api-reference/reference/groups
namespace MondayApi.Groups {
    public class GroupActions : IGroupActions {
        private readonly IMondayApiClient client;
        public GroupActions(IMondayApiClient client) {
            this.client = client;
        }

        public async Task<IEnumerable<Group>> Get(string boardID) {
            var query = new QueryQueryBuilder().WithBoards(
                new BoardQueryBuilder().WithGroups(new GroupQueryBuilder().WithAllScalarFields()),
                ids: new string[] { boardID }
            );
            var response = await client.RunQuery(query);
            return response.Boards?.FirstOrDefault()?.Groups;
        }

        public async Task<Group> GetOne(string boardID, string groupID) {
            var query = new QueryQueryBuilder().WithBoards(
                new BoardQueryBuilder().WithGroups(
                    new GroupQueryBuilder().WithAllScalarFields(),
                    ids: new string[] { groupID }
                ),
                ids: new string[] { boardID }
            );
            var response = await client.RunQuery(query);
            return response.Boards?.FirstOrDefault()?.Groups?.FirstOrDefault();
        }

        /// <inheritdoc />
        public async Task<Group> Create(string boardID, string title, string color = null, string relativeTo = null, PositionRelative? positionRelative = null) {
            Utils.Utils.RequireArgument(nameof(boardID), boardID);
            Utils.Utils.RequireArgument(nameof(title), title);

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

        /// <inheritdoc />
        public async Task<Group> Update(string boardID, string groupID, GroupAttributes attribute, string newValue) {
            var mutation = new MutationQueryBuilder().WithUpdateGroup(
                new GroupQueryBuilder().WithAllScalarFields(),
                boardID: boardID,
                groupID: groupID,
                groupAttribute: attribute,
                newValue: newValue
            );

            var response = await client.RunMutation(mutation);
            return response.UpdateGroup;
        }

        public async Task<Group> Delete(string boardID, string groupID) {
            var mutation = new MutationQueryBuilder().WithDeleteGroup(
                new GroupQueryBuilder().WithAllScalarFields(),
                boardID: boardID,
                groupID: groupID
            );

            var response = await client.RunMutation(mutation);
            return response.DeleteGroup;
        }
    }
}
