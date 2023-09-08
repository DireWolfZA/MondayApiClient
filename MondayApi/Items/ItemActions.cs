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

        public async Task<ItemsResponse> GetByBoardAsync(string cursor, int numPerPage, string boardID) {
            var limit = new GraphQlQueryParameter<int>(null, defaultValue: numPerPage);
            var cursorParameter = new GraphQlQueryParameter<string>(null, defaultValue: cursor);
            var boardIDs = new GraphQlQueryParameter<IEnumerable<string>>(null, defaultValue: new string[] { boardID });

            var query = new QueryQueryBuilder().WithBoards(
                new BoardQueryBuilder().WithItemsPage(
                    new ItemsResponseQueryBuilder().WithCursor().WithItems(
                        new ItemQueryBuilder().WithAllScalarFields()
                    ),
                    limit,
                    cursor: cursorParameter
                ),
                ids: boardIDs
            );

            var response = await client.RunQuery(query);
            return response.Boards?.FirstOrDefault()?.ItemsPage;
        }

        public async Task<ItemsResponse> GetByBoardGroupAsync(string cursor, int numPerPage, string boardID, string groupID) {
            var limit = new GraphQlQueryParameter<int>(null, defaultValue: numPerPage);
            var cursorParameter = new GraphQlQueryParameter<string>(null, defaultValue: cursor);
            var boardIDs = new GraphQlQueryParameter<IEnumerable<string>>(null, defaultValue: new string[] { boardID });
            var groupIDs = new GraphQlQueryParameter<IEnumerable<string>>(null, defaultValue: new string[] { groupID });

            var query = new QueryQueryBuilder().WithBoards(
                new BoardQueryBuilder().WithGroups(
                    new GroupQueryBuilder().WithItemsPage(
                        new ItemsResponseQueryBuilder().WithCursor().WithItems(
                            new ItemQueryBuilder().WithAllScalarFields()
                        ),
                        limit,
                        cursor: cursorParameter
                    ),
                    ids: groupIDs
                ),
                ids: boardIDs
            );

            var response = await client.RunQuery(query);
            return response.Boards?.FirstOrDefault().Groups?.FirstOrDefault()?.ItemsPage;
        }

        public async Task<Item> GetOneAsync(string id) {
            var ids = new GraphQlQueryParameter<IEnumerable<string>>(null, defaultValue: new string[] { id });

            var query = new QueryQueryBuilder().WithItems(new ItemQueryBuilder().WithAllScalarFields(), ids: ids);
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
