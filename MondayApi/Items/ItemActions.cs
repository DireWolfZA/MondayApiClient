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
            var paramLimit = new GraphQlQueryParameter<int>(null, defaultValue: numPerPage);
            var paramCursor = new GraphQlQueryParameter<string>(null, defaultValue: cursor);
            var paramBoardIDs = new GraphQlQueryParameter<IEnumerable<string>>(null, defaultValue: new string[] { boardID });
            var paramColumnIDs = columnIDs == null ? null : new GraphQlQueryParameter<IEnumerable<string>>(null, defaultValue: columnIDs);

            var itemQueryBuilder = new ItemQueryBuilder().WithAllScalarFields();
            if (withColumnValues)
                itemQueryBuilder = itemQueryBuilder.WithColumnValues(new ColumnValueQueryBuilder().WithAllScalarFields(), paramColumnIDs);

            var query = new QueryQueryBuilder().WithBoards(
                new BoardQueryBuilder().WithItemsPage(
                    new ItemsResponseQueryBuilder().WithCursor().WithItems(itemQueryBuilder),
                    paramLimit,
                    cursor: paramCursor
                ),
                ids: paramBoardIDs
            );

            var response = await client.RunQuery(query);
            return response.Boards?.FirstOrDefault()?.ItemsPage;
        }

        public async Task<ItemsResponse> GetByBoardGroupAsync(string cursor, int numPerPage, string boardID, string groupID, bool withColumnValues = false, IEnumerable<string> columnIDs = null) {
            var paramLimit = new GraphQlQueryParameter<int>(null, defaultValue: numPerPage);
            var paramCursor = new GraphQlQueryParameter<string>(null, defaultValue: cursor);
            var paramBoardIDs = new GraphQlQueryParameter<IEnumerable<string>>(null, defaultValue: new string[] { boardID });
            var paramGroupIDs = new GraphQlQueryParameter<IEnumerable<string>>(null, defaultValue: new string[] { groupID });
            var paramColumnIDs = columnIDs == null ? null : new GraphQlQueryParameter<IEnumerable<string>>(null, defaultValue: columnIDs);

            var itemQueryBuilder = new ItemQueryBuilder().WithAllScalarFields();
            if (withColumnValues)
                itemQueryBuilder = itemQueryBuilder.WithColumnValues(new ColumnValueQueryBuilder().WithAllScalarFields(), paramColumnIDs);

            var query = new QueryQueryBuilder().WithBoards(
                new BoardQueryBuilder().WithGroups(
                    new GroupQueryBuilder().WithItemsPage(
                        new ItemsResponseQueryBuilder().WithCursor().WithItems(itemQueryBuilder),
                        paramLimit,
                        cursor: paramCursor
                    ),
                    ids: paramGroupIDs
                ),
                ids: paramBoardIDs
            );

            var response = await client.RunQuery(query);
            return response.Boards?.FirstOrDefault().Groups?.FirstOrDefault()?.ItemsPage;
        }

        public async Task<Item> GetOneAsync(string id, bool withColumnValues = false, IEnumerable<string> columnIDs = null) {
            var ids = new GraphQlQueryParameter<IEnumerable<string>>(null, defaultValue: new string[] { id });
            var paramColumnIDs = columnIDs == null ? null : new GraphQlQueryParameter<IEnumerable<string>>(null, defaultValue: columnIDs);

            var itemQueryBuilder = new ItemQueryBuilder().WithAllScalarFields();
            if (withColumnValues)
                itemQueryBuilder = itemQueryBuilder.WithColumnValues(new ColumnValueQueryBuilder().WithAllScalarFields(), paramColumnIDs);

            var query = new QueryQueryBuilder().WithItems(itemQueryBuilder, ids: ids);
            var response = await client.RunQuery(query);
            return response.Items?.FirstOrDefault();
        }

        public async Task<string> GetLinkAsync(string id) {
            var ids = new GraphQlQueryParameter<IEnumerable<string>>(null, defaultValue: new string[] { id });

            var query = new QueryQueryBuilder()
                .WithItems(new ItemQueryBuilder().WithRelativeLink(), ids: ids)
                .WithAccount(new AccountQueryBuilder().WithSlug());
            var response = await client.RunQuery(query);

            return string.Concat("https://", response.Account.Slug, ".monday.com", response.Items?.FirstOrDefault()?.RelativeLink);
        }
    }
}
