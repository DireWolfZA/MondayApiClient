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
    }
}
