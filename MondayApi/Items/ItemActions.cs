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

        private ItemQueryBuilder getItemQueryBuilder(bool withColumnValues, IEnumerable<string> columnIDs) {
            var itemQueryBuilder = new ItemQueryBuilder().WithAllScalarFields();
            if (withColumnValues)
                itemQueryBuilder = itemQueryBuilder.WithColumnValues(
                    new ColumnValueQueryBuilder()
                        .WithAllScalarFields()
                        .WithPeopleValueFragment(new PeopleValueQueryBuilder().WithPersonsAndTeams(new PeopleEntityQueryBuilder().WithAllScalarFields()))
                        .WithDropdownValueFragment(new DropdownValueQueryBuilder().WithValues(new DropdownValueOptionQueryBuilder().WithAllScalarFields()))
                        .WithBoardRelationValueFragment(new BoardRelationValueQueryBuilder().WithLinkedItemIDs())
                        .WithStatusValueFragment(new StatusValueQueryBuilder().WithIndex())
                        .WithNumbersValueFragment(new NumbersValueQueryBuilder().WithNumber())
                        .WithCheckboxValueFragment(new CheckboxValueQueryBuilder().WithChecked())
                        .WithPhoneValueFragment(new PhoneValueQueryBuilder().WithCountryShortName())
                    ,
                    Utils.GetParameterIfNotNull(columnIDs)
                );
            return itemQueryBuilder;
        }

        public async Task<ItemsResponse> GetByBoardAsync(string cursor, int numPerPage, string boardID, bool withColumnValues = false, IEnumerable<string> columnIDs = null) {
            var query = new QueryQueryBuilder().WithBoards(
                new BoardQueryBuilder().WithItemsPage(
                    new ItemsResponseQueryBuilder().WithCursor().WithItems(getItemQueryBuilder(withColumnValues, columnIDs)),
                    limit: numPerPage,
                    cursor: cursor
                ),
                ids: Utils.GetParameterToMulti(boardID)
            );
            var response = await client.RunQuery(query);
            return response.Boards?.FirstOrDefault()?.ItemsPage;
        }

        //https://developer.monday.com/api-reference/docs/items-page-by-column-values
        public async Task<ItemsResponse> GetByBoardAsync(string cursor, int numPerPage, string boardID, bool withColumnValues = false, IEnumerable<string> columnIDs = null, IEnumerable<ItemsPageByColumnValuesQuery> columnFilters = null) {
            var query = new QueryQueryBuilder().WithItemsPageByColumnValues(
                new ItemsResponseQueryBuilder().WithCursor().WithItems(getItemQueryBuilder(withColumnValues, columnIDs)),
                limit: numPerPage,
                boardID: boardID,
                cursor: cursor,
                columns: Utils.GetParameterIfNotNull(columnFilters)
            );
            var response = await client.RunQuery(query);
            return response.ItemsPageByColumnValues;
        }

        public async Task<ItemsResponse> GetByBoardGroupAsync(string cursor, int numPerPage, string boardID, string groupID, bool withColumnValues = false, IEnumerable<string> columnIDs = null) {
            var query = new QueryQueryBuilder().WithBoards(
                new BoardQueryBuilder().WithGroups(
                    new GroupQueryBuilder().WithItemsPage(
                        new ItemsResponseQueryBuilder().WithCursor().WithItems(getItemQueryBuilder(withColumnValues, columnIDs)),
                        limit: numPerPage,
                        cursor: cursor
                    ),
                    ids: Utils.GetParameterToMulti(groupID)
                ),
                ids: Utils.GetParameterToMulti(boardID)
            );
            var response = await client.RunQuery(query);
            return response.Boards?.FirstOrDefault().Groups?.FirstOrDefault()?.ItemsPage;
        }

        public async Task<Item> GetOneAsync(string id, bool withColumnValues = false, IEnumerable<string> columnIDs = null) {
            var query = new QueryQueryBuilder().WithItems(
                getItemQueryBuilder(withColumnValues, columnIDs),
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
            return $"https://{response.Account.Slug}.monday.com{response.Items?.FirstOrDefault()?.RelativeLink}";
        }

        public async Task<Item> CreateAsync(string itemName, string boardID, string groupID = null, IEnumerable<IColumnValue> columnValues = null, bool? createLabelsIfMissing = null) {
            Utils.RequireArgument(nameof(itemName), itemName);
            Utils.RequireArgument(nameof(boardID), boardID);

            var mutation = new MutationQueryBuilder().WithCreateItem(
                getItemQueryBuilder(true, null),
                itemName: itemName,
                boardID: boardID,
                groupID: groupID,
                columnValues: Utils.SerializeColumnValues(columnValues),
                createLabelsIfMissing: createLabelsIfMissing
            );

            var response = await client.RunMutation(mutation);
            return response.CreateItem;
        }

        public async Task<IEnumerable<Item>> CreateMultipleAsync(IEnumerable<Item> items, bool? createLabelsIfMissing = null) {
            var mutation = new MutationQueryBuilder();

            int createIndex = 0;
            foreach (var item in items) {
                Utils.RequireArgument($"{nameof(items)}.{nameof(item.Name)}", item.Name);
                Utils.RequireArgument($"{nameof(items)}.{nameof(item.Board)}.{nameof(item.Board.ID)}", item.Board.ID);

                mutation = mutation.WithCreateItem(
                    getItemQueryBuilder(true, null),
                    itemName: item.Name,
                    boardID: item.Board.ID,
                    groupID: item.Group?.ID,
                    columnValues: Utils.SerializeColumnValues(item.ColumnValues),
                    createLabelsIfMissing: createLabelsIfMissing,

                    alias: $"createItem{createIndex}"
                );
                createIndex++;
            }

            var response = await client.RunMutation<Newtonsoft.Json.Linq.JObject>(mutation);
            return response.AsEnumerable<KeyValuePair<string, Newtonsoft.Json.Linq.JToken>>().Select(i => i.Value.ToObject<Item>());
        }

        public async Task<Item> MoveToGroupAsync(string itemID, string groupID) {
            Utils.RequireArgument(nameof(itemID), itemID);
            Utils.RequireArgument(nameof(groupID), groupID);

            var mutation = new MutationQueryBuilder().WithMoveItemToGroup(new ItemQueryBuilder().WithAllScalarFields(), groupID: groupID, itemID: itemID);

            var response = await client.RunMutation(mutation);
            return response.MoveItemToGroup;
        }

        public async Task<Item> MoveToBoardAsync(string itemID, string boardID, string groupID, IEnumerable<ColumnMappingInput> columnsMapping = null, IEnumerable<ColumnMappingInput> subitemsColumnsMapping = null) {
            Utils.RequireArgument(nameof(itemID), itemID);
            Utils.RequireArgument(nameof(boardID), boardID);
            Utils.RequireArgument(nameof(groupID), groupID);

            var mutation = new MutationQueryBuilder().WithMoveItemToBoard(new ItemQueryBuilder().WithAllScalarFields(),
                boardID: boardID,
                groupID: groupID,
                itemID: itemID,
                columnsMapping: Utils.GetParameterIfNotNull(columnsMapping),
                subitemsColumnsMapping: Utils.GetParameterIfNotNull(subitemsColumnsMapping)
            );

            var response = await client.RunMutation(mutation);
            return response.MoveItemToBoard;
        }

        public async Task<Item> DuplicateAsync(string itemID, string boardID, bool? withUpdates = false) {
            Utils.RequireArgument(nameof(itemID), itemID);
            Utils.RequireArgument(nameof(boardID), boardID);

            var mutation = new MutationQueryBuilder().WithDuplicateItem(new ItemQueryBuilder().WithAllScalarFields(),
                boardID: boardID,
                withUpdates: withUpdates,
                itemID: itemID
            );

            var response = await client.RunMutation(mutation);
            return response.DuplicateItem;
        }

        public async Task<Item> DeleteAsync(string id) {
            var mutation = new MutationQueryBuilder().WithDeleteItem(new ItemQueryBuilder().WithAllScalarFields(), id);

            var response = await client.RunMutation(mutation);
            return response.DeleteItem;
        }
    }
}
