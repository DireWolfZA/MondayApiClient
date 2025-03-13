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

        public async Task<IEnumerable<Column>> Get(string boardID) {
            var query = new QueryQueryBuilder().WithBoards(
                new BoardQueryBuilder().WithColumns(new ColumnQueryBuilder().WithAllScalarFields()),
                ids: new string[] { boardID }
            );
            var response = await client.RunQuery(query);
            return response.Boards?.FirstOrDefault()?.Columns;
        }

        static readonly ColumnType?[] bannedMoveTypes = new ColumnType?[] { ColumnType.Name, ColumnType.Subtasks, ColumnType.Formula };
        public async Task<ICollection<ColumnMappingInput>> FillColumnMapping(string boardID, ICollection<ColumnMappingInput> columnMapping) {
            var columns = await Get(boardID);

            foreach (var column in columns.Where(c => !bannedMoveTypes.Contains(c.Type) && !columnMapping.Any(cm => cm.Source == c.ID)))
                columnMapping.Add(new ColumnMappingInput() { Source = column.ID, Target = null });
            return columnMapping;
        }

        public async Task<Column> GetOne(string boardID, string columnID) {
            var query = new QueryQueryBuilder().WithBoards(
                new BoardQueryBuilder().WithColumns(
                    new ColumnQueryBuilder().WithAllScalarFields(),
                    ids: new string[] { columnID }
                ),
                ids: new string[] { boardID }
            );
            var response = await client.RunQuery(query);
            return response.Boards?.FirstOrDefault()?.Columns?.FirstOrDefault();
        }

        public async Task<string> GetSubitemsBoardID(string boardID) {
            var query = new QueryQueryBuilder().WithBoards(
                new BoardQueryBuilder().WithColumns(
                    new ColumnQueryBuilder().WithSettingsStr(),
                    types: new ColumnType?[] { ColumnType.Subtasks }
                ),
                ids: new string[] { boardID }
            );
            var response = await client.RunQuery(query);

            string columnSettingsStr = response.Boards?.FirstOrDefault()?.Columns?.FirstOrDefault()?.SettingsStr;
            if (columnSettingsStr == null)
                return null;

            using (var sr = new System.IO.StringReader(columnSettingsStr))
            using (var reader = new Newtonsoft.Json.JsonTextReader(sr)) {
                var serializer = Newtonsoft.Json.JsonSerializer.Create();
                var columnSettings = serializer.Deserialize<ColumnSettings>(reader);
                return columnSettings.BoardIDs.FirstOrDefault();
            }
        }


        public async Task<Item> ChangeValue(string boardID, string itemID, IColumnValue value, bool? createLabelsIfMissing = null) {
            var mutation = new MutationQueryBuilder().WithChangeColumnValue(
                new ItemQueryBuilder().WithAllScalarFields().WithColumnValues(
                    new ColumnValueQueryBuilder().WithAllScalarFields(),
                    ids: new string[] { value.ID }
                ),
                boardID: boardID,
                itemID: itemID,
                columnID: value.ID,
                value: Utils.Utils.SerializeColumnValue(value),
                createLabelsIfMissing: createLabelsIfMissing
            );
            var response = await client.RunMutation(mutation);
            return response.ChangeColumnValue;
        }

        public async Task<Item> ChangeValueSimple(string boardID, string columnID, string itemID, string value, bool? createLabelsIfMissing = null) {
            var mutation = new MutationQueryBuilder().WithChangeSimpleColumnValue(
                new ItemQueryBuilder().WithAllScalarFields().WithColumnValues(
                    new ColumnValueQueryBuilder().WithAllScalarFields(),
                    ids: new string[] { columnID }
                ),
                boardID: boardID,
                columnID: columnID,
                itemID: itemID,
                value: value,
                createLabelsIfMissing: createLabelsIfMissing
            );
            var response = await client.RunMutation(mutation);
            return response.ChangeSimpleColumnValue;
        }

        public async Task<Item> ChangeMultipleValues(string boardID, string itemID, IEnumerable<IColumnValue> values, bool? createLabelsIfMissing = null) {
            var mutation = new MutationQueryBuilder().WithChangeMultipleColumnValues(
                new ItemQueryBuilder().WithAllScalarFields().WithColumnValues(
                    new ColumnValueQueryBuilder().WithAllScalarFields()
                ),
                boardID: boardID,
                itemID: itemID,
                columnValues: Utils.Utils.SerializeColumnValues(values),
                createLabelsIfMissing: createLabelsIfMissing
            );
            var response = await client.RunMutation(mutation);
            return response.ChangeMultipleColumnValues;
        }

        public async Task<IEnumerable<Item>> ChangeMultipleItems(IEnumerable<ColumnMultipleUpdateValue> values, bool? createLabelsIfMissing = null) {
            var mutation = new MutationQueryBuilder();

            int createIndex = 0;
            foreach (var value in values) {
                mutation = mutation.WithChangeColumnValue(
                    new ItemQueryBuilder().WithAllScalarFields().WithColumnValues(
                        new ColumnValueQueryBuilder().WithAllScalarFields(),
                        ids: new string[] { value.Value.ID }
                    ),
                    boardID: value.BoardID,
                    itemID: value.ItemID,
                    columnID: value.Value.ID,
                    value: Utils.Utils.SerializeColumnValue(value.Value),
                    createLabelsIfMissing: createLabelsIfMissing,

                    alias: $"changeColumnValue{createIndex}"
                );
                createIndex++;
            }
            var response = await client.Run<Dictionary<string, Item>>(mutation);
            return response.Select(kv => kv.Value);
        }


        /// <inheritdoc />
        public async Task<Column> Create(string boardID, Column column, string afterColumnID = null, string defaults = null) {
            var mutation = new MutationQueryBuilder().WithCreateColumn(
                new ColumnQueryBuilder().WithAllScalarFields(),
                boardID: boardID,
                title: column.Title,
                columnType: column.Type,
                id: column.ID,
                description: column.Description,
                afterColumnID: afterColumnID,
                defaults: defaults
            );
            var response = await client.RunMutation(mutation);
            return response.CreateColumn;
        }
    }
}
