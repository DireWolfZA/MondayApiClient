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

        static readonly ColumnType?[] bannedMoveTypes = new ColumnType?[] { ColumnType.Name, ColumnType.Subtasks, ColumnType.Formula };
        public async Task<ICollection<ColumnMappingInput>> FillColumnMapping(string boardID, ICollection<ColumnMappingInput> columnMapping) {
            var columns = await GetAsync(boardID);

            foreach (var column in columns.Where(c => !bannedMoveTypes.Contains(c.Type) && !columnMapping.Any(cm => cm.Source == c.ID)))
                columnMapping.Add(new ColumnMappingInput() { Source = column.ID, Target = null });
            return columnMapping;
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
                    types: Utils.GetParameterWithNameToMulti(ColumnType.Subtasks)
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

        public async Task<Item> ChangeMultipleValuesAsync(string boardID, string itemID, IEnumerable<IColumnValue> values, bool? createLabelsIfMissing = null) {
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

        public async Task<IEnumerable<Item>> ChangeMultipleItemsAsync(IEnumerable<ColumnMultipleUpdateValue> values, bool? createLabelsIfMissing = null) {
            var mutation = new MutationQueryBuilder();

            int createIndex = 0;
            foreach (var value in values) {
                mutation = mutation.WithChangeColumnValue(
                    new ItemQueryBuilder().WithAllScalarFields().WithColumnValues(
                        new ColumnValueQueryBuilder().WithAllScalarFields(),
                        ids: Utils.GetParameterToMulti(value.Value.ID)
                    ),
                    columnID: value.Value.ID,
                    boardID: value.BoardID,
                    value: Utils.SerializeColumnValue(value.Value),
                    itemID: value.ItemID,
                    createLabelsIfMissing: createLabelsIfMissing,

                    alias: $"changeColumnValue{createIndex}"
                );
                createIndex++;
            }

            var response = await client.RunMutation<Newtonsoft.Json.Linq.JObject>(mutation);
            return response.AsEnumerable<KeyValuePair<string, Newtonsoft.Json.Linq.JToken>>().Select(i => i.Value.ToObject<Item>());
        }
    }
}
