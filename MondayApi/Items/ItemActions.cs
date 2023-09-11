using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MondayApi.Schema;

//https://developer.monday.com/api-reference/docs/items
namespace MondayApi.Items {
    public class ItemActions : IItemActions {
        private readonly IMondayApiClient client;
        public ItemActions(IMondayApiClient client) {
            this.client = client;
        }

        public async Task<ItemsResponse> GetByBoardAsync(string cursor, int numPerPage, string boardID, bool withColumnValues = false, IEnumerable<string> columnIDs = null) {
            var itemQueryBuilder = new ItemQueryBuilder().WithAllScalarFields();
            if (withColumnValues)
                itemQueryBuilder = itemQueryBuilder.WithColumnValues(
                    new ColumnValueQueryBuilder().WithAllScalarFields(),
                    Utils.GetParameterIfNotNull(columnIDs)
                );
            var query = new QueryQueryBuilder().WithBoards(
                new BoardQueryBuilder().WithItemsPage(
                    new ItemsResponseQueryBuilder().WithCursor().WithItems(itemQueryBuilder),
                    limit: Utils.GetParameter(numPerPage),
                    cursor: Utils.GetParameter(cursor)
                ),
                ids: Utils.GetParameterToMulti(boardID)
            );
            var response = await client.RunQuery(query);
            return response.Boards?.FirstOrDefault()?.ItemsPage;
        }

        public async Task<ItemsResponse> GetByBoardGroupAsync(string cursor, int numPerPage, string boardID, string groupID, bool withColumnValues = false, IEnumerable<string> columnIDs = null) {
            var itemQueryBuilder = new ItemQueryBuilder().WithAllScalarFields();
            if (withColumnValues)
                itemQueryBuilder = itemQueryBuilder.WithColumnValues(
                    new ColumnValueQueryBuilder().WithAllScalarFields(),
                    Utils.GetParameterIfNotNull(columnIDs)
                );
            var query = new QueryQueryBuilder().WithBoards(
                new BoardQueryBuilder().WithGroups(
                    new GroupQueryBuilder().WithItemsPage(
                        new ItemsResponseQueryBuilder().WithCursor().WithItems(itemQueryBuilder),
                        limit: Utils.GetParameter(numPerPage),
                        cursor: Utils.GetParameter(cursor)
                    ),
                    ids: Utils.GetParameterToMulti(groupID)
                ),
                ids: Utils.GetParameterToMulti(boardID)
            );
            var response = await client.RunQuery(query);
            return response.Boards?.FirstOrDefault().Groups?.FirstOrDefault()?.ItemsPage;
        }

        public async Task<Item> GetOneAsync(string id, bool withColumnValues = false, IEnumerable<string> columnIDs = null) {
            var itemQueryBuilder = new ItemQueryBuilder().WithAllScalarFields();
            if (withColumnValues)
                itemQueryBuilder = itemQueryBuilder.WithColumnValues(
                    new ColumnValueQueryBuilder().WithAllScalarFields(),
                    Utils.GetParameterIfNotNull(columnIDs)
                );
            var query = new QueryQueryBuilder().WithItems(
                itemQueryBuilder,
                ids: Utils.GetParameterToMulti(id)
            );
            var response = await client.RunQuery(query);
            return response.Items?.FirstOrDefault();
        }

        public async Task<string> GetLinkAsync(string id) {
            var query = new QueryQueryBuilder()
                .WithItems(new ItemQueryBuilder().WithRelativeLink(), ids: Utils.GetParameterToMulti(id))
                .WithAccount(new AccountQueryBuilder().WithSlug());
            var response = await client.RunQuery(query);
            return string.Concat("https://", response.Account.Slug, ".monday.com", response.Items?.FirstOrDefault()?.RelativeLink);
        }

        public async Task<Item> CreateAsync(Item item, string boardID, string groupID = null, bool? createLabelsIfMissing = null) {
            Utils.RequireArgument(nameof(item.Name), item.Name);
            Utils.RequireArgument(boardID, boardID);

            var mutation = new MutationQueryBuilder().WithCreateItem(
                new ItemQueryBuilder().WithAllScalarFields(),
                itemName: item.Name,
                boardID: boardID,
                groupID: groupID,
                columnValues: null,
                createLabelsIfMissing: createLabelsIfMissing
            );

            var response = await client.RunMutation(mutation);
            return response.CreateItem;
        }

        public async Task<Item> MoveToGroupAsync(string itemID, string groupID) {
            var mutation = new MutationQueryBuilder().WithMoveItemToGroup(new ItemQueryBuilder().WithAllScalarFields(), groupID: groupID, itemID: itemID);

            var response = await client.RunMutation(mutation);
            return response.MoveItemToGroup;
        }

        public async Task<Item> DeleteAsync(string id) {
            var mutation = new MutationQueryBuilder().WithDeleteItem(new ItemQueryBuilder().WithAllScalarFields(), id);

            var response = await client.RunMutation(mutation);
            return response.DeleteItem;
        }
    }
}
