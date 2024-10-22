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
            var itemQueryBuilder = new ItemQueryBuilder().WithAllScalarFields().WithGroup(new GroupQueryBuilder().WithID());
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
                        .WithEmailValueFragment(new EmailValueQueryBuilder().WithEmail())
                        .WithMirrorValueFragment(new MirrorValueQueryBuilder().WithDisplayValue())
                    ,
                    ids: Utils.Utils.GetParameter(columnIDs)
                );
            return itemQueryBuilder;
        }

        public async Task<ItemsResponse> GetByBoard(string cursor, int numPerPage, string boardID, bool withColumnValues = false, IEnumerable<string> columnIDs = null, ItemsQuery queryParams = null) {
            var query = new QueryQueryBuilder().WithBoards(
                new BoardQueryBuilder().WithItemsPage(
                    new ItemsResponseQueryBuilder().WithCursor().WithItems(getItemQueryBuilder(withColumnValues, columnIDs)),
                    cursor: cursor,
                    limit: numPerPage,
                    queryParams: queryParams
                ),
                ids: new string[] { boardID }
            );
            var response = await client.RunQuery(query);
            return response.Boards?.FirstOrDefault()?.ItemsPage;
        }

        //https://developer.monday.com/api-reference/docs/items-page-by-column-values
        public async Task<ItemsResponse> GetByBoardColumnValues(string cursor, int numPerPage, string boardID, bool withColumnValues = false, IEnumerable<string> columnIDs = null, IEnumerable<ItemsPageByColumnValuesQuery> columnFilters = null) {
            var query = new QueryQueryBuilder().WithItemsPageByColumnValues(
                new ItemsResponseQueryBuilder().WithCursor().WithItems(getItemQueryBuilder(withColumnValues, columnIDs)),
                cursor: cursor,
                limit: numPerPage,
                boardID: boardID,
                columns: Utils.Utils.GetParameter(columnFilters)
            );
            var response = await client.RunQuery(query);
            return response.ItemsPageByColumnValues;
        }


        public async Task<ItemsResponse> GetByBoardNextPage(string cursor, int numPerPage, bool withColumnValues = false, IEnumerable<string> columnIDs = null) {
            Utils.Utils.RequireArgument(nameof(cursor), cursor);
            var query = new QueryQueryBuilder().WithNextItemsPage(
                new ItemsResponseQueryBuilder().WithCursor().WithItems(getItemQueryBuilder(withColumnValues, columnIDs)),
                cursor: cursor,
                limit: numPerPage
            );
            var response = await client.RunQuery(query);
            return response.NextItemsPage;
        }

        public async Task<ItemsResponse> GetByBoardGroup(string cursor, int numPerPage, string boardID, string groupID, bool withColumnValues = false, IEnumerable<string> columnIDs = null) {
            var query = new QueryQueryBuilder().WithBoards(
                new BoardQueryBuilder().WithGroups(
                    new GroupQueryBuilder().WithItemsPage(
                        new ItemsResponseQueryBuilder().WithCursor().WithItems(getItemQueryBuilder(withColumnValues, columnIDs)),
                        cursor: cursor,
                        limit: numPerPage
                    ),
                    ids: new string[] { groupID }
                ),
                ids: new string[] { boardID }
            );
            var response = await client.RunQuery(query);
            return response.Boards?.FirstOrDefault().Groups?.FirstOrDefault()?.ItemsPage;
        }

        public async Task<Item> GetOne(string id, bool withColumnValues = false, IEnumerable<string> columnIDs = null) {
            var query = new QueryQueryBuilder().WithItems(
                getItemQueryBuilder(withColumnValues, columnIDs),
                ids: new string[] { id }
            );
            var response = await client.RunQuery(query);
            return response.Items?.FirstOrDefault();
        }

        /// <inheritdoc />
        public async Task<Item> Create(string itemName, string boardID, string groupID = null, IEnumerable<IColumnValue> columnValues = null,
            bool? createLabelsIfMissing = null, string relativeTo = null, PositionRelative? positionRelative = null
        ) {
            Utils.Utils.RequireArgument(nameof(itemName), itemName);
            Utils.Utils.RequireArgument(nameof(boardID), boardID);

            var mutation = new MutationQueryBuilder().WithCreateItem(
                getItemQueryBuilder(true, null),
                itemName: itemName,
                boardID: boardID,
                groupID: groupID,
                columnValues: Utils.Utils.SerializeColumnValues(columnValues),
                createLabelsIfMissing: createLabelsIfMissing,
                relativeTo: relativeTo,
                positionRelativeMethod: positionRelative
            );

            var response = await client.RunMutation(mutation);
            return response.CreateItem;
        }

        /// <inheritdoc />
        public async Task<IEnumerable<Item>> CreateMultiple(IEnumerable<Item> items, bool? createLabelsIfMissing = null) {
            Utils.Utils.RequireArgument(nameof(items), items);
            var mutation = new MutationQueryBuilder();

            int createIndex = 0;
            foreach (var item in items) {
                Utils.Utils.RequireArgument($"{nameof(items)}.{nameof(item.Name)}", item.Name);
                Utils.Utils.RequireArgument($"{nameof(items)}.{nameof(item.Board)}.{nameof(item.Board.ID)}", item.Board.ID);

                mutation = mutation.WithCreateItem(
                    getItemQueryBuilder(true, null),
                    itemName: item.Name,
                    boardID: item.Board.ID,
                    groupID: item.Group?.ID,
                    columnValues: Utils.Utils.SerializeColumnValues(item.ColumnValues),
                    createLabelsIfMissing: createLabelsIfMissing,

                    alias: $"createItem{createIndex}"
                );
                createIndex++;
            }

            var response = await client.Run<Newtonsoft.Json.Linq.JObject>(mutation);
            return response.AsEnumerable<KeyValuePair<string, Newtonsoft.Json.Linq.JToken>>().Select(i => i.Value.ToObject<Item>());
        }

        public async Task<Item> MoveToGroup(string itemID, string groupID) {
            Utils.Utils.RequireArgument(nameof(itemID), itemID);
            Utils.Utils.RequireArgument(nameof(groupID), groupID);

            var mutation = new MutationQueryBuilder().WithMoveItemToGroup(
                new ItemQueryBuilder().WithAllScalarFields(),
                itemID: itemID,
                groupID: groupID
            );

            var response = await client.RunMutation(mutation);
            return response.MoveItemToGroup;
        }

        /// <inheritdoc />
        public async Task<Item> MoveToBoard(string itemID, string boardID, string groupID, IEnumerable<ColumnMappingInput> columnsMapping = null, IEnumerable<ColumnMappingInput> subitemsColumnsMapping = null) {
            Utils.Utils.RequireArgument(nameof(itemID), itemID);
            Utils.Utils.RequireArgument(nameof(boardID), boardID);
            Utils.Utils.RequireArgument(nameof(groupID), groupID);

            var mutation = new MutationQueryBuilder().WithMoveItemToBoard(new ItemQueryBuilder().WithAllScalarFields(),
                itemID: itemID,
                boardID: boardID,
                groupID: groupID,
                columnsMapping: Utils.Utils.GetParameter(columnsMapping),
                subitemsColumnsMapping: Utils.Utils.GetParameter(subitemsColumnsMapping)
            );

            var response = await client.RunMutation(mutation);
            return response.MoveItemToBoard;
        }

        public async Task<Item> Duplicate(string itemID, string boardID, bool? withUpdates = false) {
            Utils.Utils.RequireArgument(nameof(itemID), itemID);
            Utils.Utils.RequireArgument(nameof(boardID), boardID);

            var mutation = new MutationQueryBuilder().WithDuplicateItem(new ItemQueryBuilder().WithAllScalarFields(),
                itemID: itemID,
                boardID: boardID,
                withUpdates: withUpdates
            );

            var response = await client.RunMutation(mutation);
            return response.DuplicateItem;
        }

        public async Task<Item> Delete(string id) {
            var mutation = new MutationQueryBuilder().WithDeleteItem(new ItemQueryBuilder().WithAllScalarFields(), id);

            var response = await client.RunMutation(mutation);
            return response.DeleteItem;
        }

        public async Task<IEnumerable<Item>> DeleteMultiple(IEnumerable<string> ids) {
            Utils.Utils.RequireArgument($"{nameof(ids)}", ids);
            var mutation = new MutationQueryBuilder();

            int deleteIndex = 0;
            foreach (string id in ids) {
                Utils.Utils.RequireArgument($"{nameof(ids)}.Item", id);

                mutation = mutation.WithDeleteItem(
                    new ItemQueryBuilder().WithAllScalarFields(),
                    id,
                    alias: $"deleteItem{deleteIndex}"
                );
                deleteIndex++;
            }

            var response = await client.Run<Newtonsoft.Json.Linq.JObject>(mutation);
            return response.AsEnumerable<KeyValuePair<string, Newtonsoft.Json.Linq.JToken>>().Select(i => i.Value.ToObject<Item>());
        }
    }
}
