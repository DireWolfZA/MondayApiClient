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
            var limit = new GraphQlQueryParameter<int?>(null, defaultValue: numPerPage);
            var page = new GraphQlQueryParameter<int?>(null, defaultValue: pageNumber);

            var query = new QueryQueryBuilder().WithBoards(new BoardQueryBuilder().WithAllScalarFields(), limit, page);
            var response = await client.RunQuery(query);
            return response.Boards;
        }

        public async Task<Board> GetOneAsync(string id) {
            var ids = new GraphQlQueryParameter<IEnumerable<string>>(null, defaultValue: new string[] { id });

            var query = new QueryQueryBuilder().WithBoards(new BoardQueryBuilder().WithAllScalarFields(), ids: ids);
            var response = await client.RunQuery(query);
            return response.Boards?.FirstOrDefault();
        }
    }
}
