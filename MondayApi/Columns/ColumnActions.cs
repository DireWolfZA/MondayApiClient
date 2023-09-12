using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MondayApi.Schema;

//https://developer.monday.com/api-reference/docs/columns
namespace MondayApi.Columns {
    public class ColumnActions : IColumnActions {
        private readonly IMondayApiClient client;
        public ColumnActions(IMondayApiClient client) {
            this.client = client;
        }

        public async Task<IEnumerable<Column>> GetAsync(string boardID) {
            var query = new QueryQueryBuilder().WithBoards(
                new BoardQueryBuilder().WithColumns(new ColumnQueryBuilder().WithAllScalarFields()),
                ids: Utils.GetParameterToMulti(boardID)
            );
            var response = await client.RunQuery(query);
            return response.Boards?.FirstOrDefault()?.Columns;
        }

        public async Task<Column> GetOneAsync(string boardID, string columnID) {
            var query = new QueryQueryBuilder().WithBoards(
                new BoardQueryBuilder().WithColumns(
                    new ColumnQueryBuilder().WithAllScalarFields(),
                    ids: Utils.GetParameterToMulti(columnID)
                ),
                ids: Utils.GetParameterToMulti(boardID)
            );
            var response = await client.RunQuery(query);
            return response.Boards?.FirstOrDefault()?.Columns?.FirstOrDefault();
        }

        public async Task<Item> ChangeMultipleValuesAsync(string boardID, string itemID, Dictionary<string, IColumnValue> values, bool? createLabelsIfMissing = null) {
            var mutation = new MutationQueryBuilder().WithChangeMultipleColumnValues(
                new ItemQueryBuilder().WithAllScalarFields().WithColumnValues(
                    new ColumnValueQueryBuilder().WithAllScalarFields()
                ),
                boardID: boardID,
                columnValues: Utils.SerializeColumnValues(values),
                itemID: itemID,
                createLabelsIfMissing: createLabelsIfMissing
            );
            var response = await client.RunMutation(mutation);
            return response.ChangeMultipleColumnValues;
        }
    }
}
