using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MondayApi.Schema;

//https://developer.monday.com/api-reference/reference/updates
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

        public async Task<IEnumerable<Update>> Get(int pageNumber, int numPerPage, bool includeReplies = false) {
            var query = new QueryQueryBuilder().WithUpdates(
                getUpdateQueryBuilder(includeReplies),
                page: pageNumber,
                limit: numPerPage
            );
            var response = await client.RunQuery(query);
            return response.Updates!;
        }

        public async Task<IEnumerable<Update>?> GetByBoard(int pageNumber, int numPerPage, string boardID, bool includeReplies = false) {
            var query = new QueryQueryBuilder().WithBoards(
                new BoardQueryBuilder().WithUpdates(
                    getUpdateQueryBuilder(includeReplies),
                    page: pageNumber,
                    limit: numPerPage
                ),
                ids: new string[] { boardID }
            );
            var response = await client.RunQuery(query);
            return response.Boards?.FirstOrDefault()?.Updates;
        }

        public async Task<IEnumerable<Update>?> GetByItem(int pageNumber, int numPerPage, string itemID, bool includeReplies = false) {
            var query = new QueryQueryBuilder().WithItems(
                new ItemQueryBuilder().WithUpdates(
                    getUpdateQueryBuilder(includeReplies),
                    page: pageNumber,
                    limit: numPerPage
                ),
                ids: new string[] { itemID }
            );
            var response = await client.RunQuery(query);
            return response.Items?.FirstOrDefault()?.Updates;
        }

        public async Task<Update> Create(string itemID, string body) {
            Utils.Utils.RequireArgument(nameof(itemID), itemID);
            Utils.Utils.RequireArgument(nameof(body), body);

            var mutation = new MutationQueryBuilder().WithCreateUpdate(
                getUpdateQueryBuilder(true),
                body: body,
                itemID: itemID,
                parentID: null
            );
            var response = await client.RunMutation(mutation);
            return response.CreateUpdate!;
        }

        public async Task<Update> CreateReply(string parentUpdateID, string body) {
            Utils.Utils.RequireArgument(nameof(parentUpdateID), parentUpdateID);
            Utils.Utils.RequireArgument(nameof(body), body);

            var mutation = new MutationQueryBuilder().WithCreateUpdate(
                getUpdateQueryBuilder(true),
                body: body,
                itemID: null,
                parentID: parentUpdateID
            );
            var response = await client.RunMutation(mutation);
            return response.CreateUpdate!;
        }

        /// <inheritdoc />
        public async Task<Update> Like(string updateID) {
            var mutation = new MutationQueryBuilder().WithLikeUpdate(
                new UpdateQueryBuilder().WithID().WithCreatorID().WithCreatedAt().WithUpdatedAt(),
                updateID: updateID
            );
            var response = await client.RunMutation(mutation);
            return response.LikeUpdate!;
        }

        public async Task<Update> Delete(string updateID) {
            var mutation = new MutationQueryBuilder().WithDeleteUpdate(
                getUpdateQueryBuilder(true),
                id: updateID
            );
            var response = await client.RunMutation(mutation);
            return response.DeleteUpdate!;
        }

        public async Task<Item> ClearForItem(string itemID) {
            var mutation = new MutationQueryBuilder().WithClearItemUpdates(
                new ItemQueryBuilder().WithUpdates(new UpdateQueryBuilder().WithAllScalarFields()),
                itemID: itemID
            );
            var response = await client.RunMutation(mutation);
            return response.ClearItemUpdates!;
        }
    }
}
