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
            var ids = new GraphQlQueryParameter<IEnumerable<string>>(null, defaultValue: new string[] { boardID });

            var query = new QueryQueryBuilder().WithBoards(new BoardQueryBuilder().WithColumns(new ColumnQueryBuilder().WithAllScalarFields()), ids: ids);
            var response = await client.RunQuery(query);
            return response.Boards?.FirstOrDefault()?.Columns;
        }

        public async Task<Column> GetOneAsync(string boardID, string columnID) {
            var boardIDs = new GraphQlQueryParameter<IEnumerable<string>>(null, defaultValue: new string[] { boardID });
            var columnIDs = new GraphQlQueryParameter<IEnumerable<string>>(null, defaultValue: new string[] { columnID });

            var query = new QueryQueryBuilder().WithBoards(new BoardQueryBuilder().WithColumns(new ColumnQueryBuilder().WithAllScalarFields(), ids: columnIDs), ids: boardIDs);
            var response = await client.RunQuery(query);
            return response.Boards?.FirstOrDefault()?.Columns?.FirstOrDefault();
        }
    }
}
