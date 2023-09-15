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

        public async Task<IEnumerable<Item>> GetAsync(string parentItemID, bool withColumnValues = false, IEnumerable<string> columnIDs = null) {
            var subItemQueryBuilder = new ItemQueryBuilder().WithAllScalarFields();
            if (withColumnValues)
                subItemQueryBuilder = subItemQueryBuilder.WithColumnValues(
                    new ColumnValueQueryBuilder().WithAllScalarFields(),
                    Utils.GetParameterIfNotNull(columnIDs)
                );
            var query = new QueryQueryBuilder().WithItems(
                new ItemQueryBuilder().WithSubitems(subItemQueryBuilder),
                ids: Utils.GetParameterToMulti(parentItemID)
            );
            var response = await client.RunQuery(query);
            return response.Items?.FirstOrDefault().Subitems;
        }

        public async Task<Item> CreateSubitem(string itemName, string parentItemID, List<IColumnValue> columnValues = null, bool? createLabelsIfMissing = null) {
            Utils.RequireArgument(nameof(parentItemID), parentItemID);
            Utils.RequireArgument(nameof(itemName), itemName);

            var mutation = new MutationQueryBuilder().WithCreateSubitem(
                new ItemQueryBuilder().WithAllScalarFields().WithColumnValues(
                    new ColumnValueQueryBuilder().WithAllScalarFields()
                ),
                parentItemID: parentItemID,
                itemName: itemName,
                columnValues: Utils.SerializeColumnValues(columnValues),
                createLabelsIfMissing: createLabelsIfMissing
            );

            var response = await client.RunMutation(mutation);
            return response.CreateSubitem;
        }
    }
}
