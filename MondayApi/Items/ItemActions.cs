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
                    limit: Utils.GetParameter(numPerPage),
                    cursor: Utils.GetParameter(cursor)
                ),
                ids: Utils.GetParameterToMulti(boardID)
            );
            var response = await client.RunQuery(query);
            return response.Boards?.FirstOrDefault()?.ItemsPage;
        }

        public async Task<ItemsResponse> GetByBoardGroupAsync(string cursor, int numPerPage, string boardID, string groupID, bool withColumnValues = false, IEnumerable<string> columnIDs = null) {
            var query = new QueryQueryBuilder().WithBoards(
                new BoardQueryBuilder().WithGroups(
                    new GroupQueryBuilder().WithItemsPage(
                        new ItemsResponseQueryBuilder().WithCursor().WithItems(getItemQueryBuilder(withColumnValues, columnIDs)),
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
