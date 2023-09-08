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
    }
}
