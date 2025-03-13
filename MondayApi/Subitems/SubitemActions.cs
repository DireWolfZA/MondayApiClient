using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MondayApi.Schema;

//https://developer.monday.com/api-reference/docs/subitems
namespace MondayApi.Subitems {
    public class SubitemActions : ISubitemActions {
        private readonly IMondayApiClient client;
        public SubitemActions(IMondayApiClient client) {
            this.client = client;
        }

        private ItemQueryBuilder getSubitemQueryBuilder(bool withColumnValues, IEnumerable<string> columnIDs) {
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
                    ,
                    ids: Utils.Utils.GetParameter(columnIDs)
                );
            return itemQueryBuilder;
        }

        public async Task<IEnumerable<Item>> Get(string parentItemID, bool withColumnValues = false, IEnumerable<string> columnIDs = null) {
            var query = new QueryQueryBuilder().WithItems(
                new ItemQueryBuilder().WithSubitems(getSubitemQueryBuilder(withColumnValues, columnIDs)),
                ids: new string[] { parentItemID }
            );
            var response = await client.RunQuery(query);
            return response.Items?.FirstOrDefault().Subitems;
        }

        public async Task<Item> GetParentItem(string subitemID, bool withColumnValues = false, IEnumerable<string> columnIDs = null) {
            var query = new QueryQueryBuilder().WithItems(
                new ItemQueryBuilder().WithParentItem(getSubitemQueryBuilder(withColumnValues, columnIDs)),
                ids: new string[] { subitemID }
            );
            var response = await client.RunQuery(query);
            return response.Items?.FirstOrDefault()?.ParentItem;
        }

        public async Task<Item> CreateSubitem(string itemName, string parentItemID, IEnumerable<IColumnValue> columnValues = null, bool? createLabelsIfMissing = null) {
            Utils.Utils.RequireArgument(nameof(parentItemID), parentItemID);
            Utils.Utils.RequireArgument(nameof(itemName), itemName);

            var mutation = new MutationQueryBuilder().WithCreateSubitem(
                getSubitemQueryBuilder(true, null),
                itemName: itemName,
                parentItemID: parentItemID,
                columnValues: Utils.Utils.SerializeColumnValues(columnValues),
                createLabelsIfMissing: createLabelsIfMissing
            );

            var response = await client.RunMutation(mutation);
            return response.CreateSubitem;
        }

        /// <inheritdoc />
        public async Task<IEnumerable<Item>> CreateMultiple(string parentItemID, IEnumerable<Item> items, bool? createLabelsIfMissing = null) {
            Utils.Utils.RequireArgument(nameof(items), items);
            var mutation = new MutationQueryBuilder();

            int createIndex = 0;
            foreach (var item in items) {
                Utils.Utils.RequireArgument($"{nameof(items)}.{nameof(item.Name)}", item.Name);

                mutation = mutation.WithCreateSubitem(
                    getSubitemQueryBuilder(true, null),
                    itemName: item.Name,
                    parentItemID: parentItemID,
                    columnValues: Utils.Utils.SerializeColumnValues(item.ColumnValues),
                    createLabelsIfMissing: createLabelsIfMissing,

                    alias: $"createItem{createIndex}"
                );
                createIndex++;
            }

            var response = await client.Run<Dictionary<string, Item>>(mutation);
            return response.Select(kv => kv.Value);
        }
    }
}
