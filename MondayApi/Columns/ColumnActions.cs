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

        public async Task<string> GetSubitemsBoardIDAsync(string boardID) {
            var query = new QueryQueryBuilder().WithBoards(
                new BoardQueryBuilder().WithColumns(
                    new ColumnQueryBuilder().WithSettingsStr(),
                    types: new GraphQlQueryParameter<IEnumerable<ColumnType>>(null, nameof(ColumnType), defaultValue: new ColumnType[] { ColumnType.Subtasks })
                ),
                ids: Utils.GetParameterToMulti(boardID)
            );
            var response = await client.RunQuery(query);

            var columnSettingsStr = response.Boards?.FirstOrDefault()?.Columns?.FirstOrDefault()?.SettingsStr;
            if (columnSettingsStr == null)
                return null;

            using (var sr = new System.IO.StringReader(columnSettingsStr))
            using (var reader = new Newtonsoft.Json.JsonTextReader(sr)) {
                var serializer = Newtonsoft.Json.JsonSerializer.Create();
                var columnSettings = serializer.Deserialize<ColumnSettings>(reader);
                return columnSettings.BoardIDs.FirstOrDefault();
            }
        }

        public async Task<Item> ChangeValueAsync(string boardID, string itemID, IColumnValue value, bool? createLabelsIfMissing = null) {
            var mutation = new MutationQueryBuilder().WithChangeColumnValue(
                new ItemQueryBuilder().WithAllScalarFields().WithColumnValues(
                    new ColumnValueQueryBuilder().WithAllScalarFields(),
                    ids: Utils.GetParameterToMulti(value.ID)
                ),
                columnID: value.ID,
                boardID: boardID,
                value: Utils.SerializeColumnValue(value),
                itemID: itemID,
                createLabelsIfMissing: createLabelsIfMissing
            );
            var response = await client.RunMutation(mutation);
            return response.ChangeColumnValue;
        }

        public async Task<Item> ChangeValueSimpleAsync(string boardID, string columnID, string itemID, string value, bool? createLabelsIfMissing = null) {
            var mutation = new MutationQueryBuilder().WithChangeSimpleColumnValue(
                new ItemQueryBuilder().WithAllScalarFields().WithColumnValues(
                    new ColumnValueQueryBuilder().WithAllScalarFields(),
                    ids: Utils.GetParameterToMulti(columnID)
                ),
                columnID: columnID,
                boardID: boardID,
                itemID: itemID,
                value: value,
                createLabelsIfMissing: createLabelsIfMissing
            );
            var response = await client.RunMutation(mutation);
            return response.ChangeSimpleColumnValue;
        }

        public async Task<Item> ChangeMultipleValuesAsync(string boardID, string itemID, List<IColumnValue> values, bool? createLabelsIfMissing = null) {
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
