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
            var limit = new GraphQlQueryParameter<int?>(null, numPerPage);
            var page = new GraphQlQueryParameter<int?>(null, pageNumber);

            var query = new QueryQueryBuilder().WithBoards(new BoardQueryBuilder().WithAllScalarFields(), limit, page);
            var response = await client.RunQuery(query);
            return response.Boards;
        }

        //public async Task<Board> GetOneAsync(int id) {
        //    var ids = new GraphQlQueryParameter<IEnumerable<int?>>(null, new int?[] { id });

        //    var query = new QueryQueryBuilder().WithBoards(new BoardQueryBuilder().WithAllScalarFields(), ids: ids);
        //    var response =  await client.RunQuery(query);
        //    return response.Boards?.FirstOrDefault();
        //}
    }
}
