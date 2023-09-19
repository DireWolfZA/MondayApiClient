using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MondayApi.Schema;

//https://developer.monday.com/api-reference/docs/updates
namespace MondayApi.Updates {
    public class UpdateActions : IUpdateActions {
        private readonly IMondayApiClient client;
        public UpdateActions(IMondayApiClient client) {
            this.client = client;
        }

        private UpdateQueryBuilder getUpdateQueryBuilder(bool includeReplies) {
            var updateQueryBuilder = new UpdateQueryBuilder().WithAllScalarFields();
            if (includeReplies)
                updateQueryBuilder = updateQueryBuilder.WithReplies(new ReplyQueryBuilder().WithAllScalarFields());
            return updateQueryBuilder;
        }

        public async Task<IEnumerable<Update>> GetAsync(int pageNumber, int numPerPage, bool includeReplies = false) {
            var query = new QueryQueryBuilder().WithUpdates(
                getUpdateQueryBuilder(includeReplies),
                limit: Utils.GetParameter<int?>(numPerPage),
                page: Utils.GetParameter<int?>(pageNumber)
            );
            var response = await client.RunQuery(query);
            return response.Updates;
        }

        public async Task<IEnumerable<Update>> GetByBoardAsync(int pageNumber, int numPerPage, string boardID, bool includeReplies = false) {
            var query = new QueryQueryBuilder().WithBoards(
                new BoardQueryBuilder().WithUpdates(
                    getUpdateQueryBuilder(includeReplies),
                    limit: Utils.GetParameter<int?>(numPerPage),
                    page: Utils.GetParameter<int?>(pageNumber)
                ),
                ids: Utils.GetParameterToMulti(boardID)
            );
            var response = await client.RunQuery(query);
            return response.Boards?.FirstOrDefault()?.Updates;
        }

        public async Task<IEnumerable<Update>> GetByItemAsync(int pageNumber, int numPerPage, string itemID, bool includeReplies = false) {
            var query = new QueryQueryBuilder().WithItems(
                new ItemQueryBuilder().WithUpdates(
                    getUpdateQueryBuilder(includeReplies),
                    limit: Utils.GetParameter<int?>(numPerPage),
                    page: Utils.GetParameter<int?>(pageNumber)
                ),
                ids: Utils.GetParameterToMulti(itemID)
            );
            var response = await client.RunQuery(query);
            return response.Items?.FirstOrDefault()?.Updates;
        }

        public async Task<Update> CreateAsync(string itemID, string body, string parentUpdateID = null) {
            Utils.RequireArgument(nameof(itemID), itemID);
            Utils.RequireArgument(nameof(body), body);

            var mutation = new MutationQueryBuilder().WithCreateUpdate(
                getUpdateQueryBuilder(true),
                body: body,
                itemID: itemID,
                parentID: parentUpdateID
            );
            var response = await client.RunMutation(mutation);
            return response.CreateUpdate;
        }

        public async Task<Update> LikeAsync(string updateID) {
            var mutation = new MutationQueryBuilder().WithLikeUpdate(
                new UpdateQueryBuilder().WithID().WithCreatorID().WithCreatedAt().WithUpdatedAt(),
                updateID: updateID
            );
            var response = await client.RunMutation(mutation);
            return response.LikeUpdate;
        }

        public async Task<Update> DeleteAsync(string updateID) {
            var mutation = new MutationQueryBuilder().WithDeleteUpdate(
                getUpdateQueryBuilder(true),
                id: updateID
            );
            var response = await client.RunMutation(mutation);
            return response.DeleteUpdate;
        }

        public async Task<Item> ClearForItemAsync(string itemID) {
            var mutation = new MutationQueryBuilder().WithClearItemUpdates(
                new ItemQueryBuilder().WithUpdates(new UpdateQueryBuilder().WithAllScalarFields()),
                itemID: itemID
            );
            var response = await client.RunMutation(mutation);
            return response.ClearItemUpdates;
        }
    }
}
