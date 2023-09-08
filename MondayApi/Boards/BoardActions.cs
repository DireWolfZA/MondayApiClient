using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MondayApi.Schema;

//https://developer.monday.com/api-reference/docs/boards
namespace MondayApi.Boards {
    public class BoardActions : IBoardActions {
        private readonly IMondayApiClient client;
        public BoardActions(IMondayApiClient client) {
            this.client = client;
        }

        public async Task<IEnumerable<Board>> GetAsync(int pageNumber, int numPerPage) {
            var query = new QueryQueryBuilder().WithBoards(
                new BoardQueryBuilder().WithAllScalarFields(),
                limit: Utils.GetParameter<int?>(numPerPage),
                page: Utils.GetParameter<int?>(pageNumber)
            );
            var response = await client.RunQuery(query);
            return response.Boards;
        }

        public async Task<Board> GetOneAsync(string id) {
            var query = new QueryQueryBuilder().WithBoards(
                new BoardQueryBuilder().WithAllScalarFields(),
                ids: Utils.GetParameterToMulti(id)
            );
            var response = await client.RunQuery(query);
            return response.Boards?.FirstOrDefault();
        }
    }
}
