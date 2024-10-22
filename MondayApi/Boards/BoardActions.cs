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

        public async Task<IEnumerable<Board>> Get(int pageNumber, int numPerPage) {
            var query = new QueryQueryBuilder().WithBoards(
                new BoardQueryBuilder().WithAllScalarFields(),
                page: pageNumber,
                limit: numPerPage
            );
            var response = await client.RunQuery(query);
            return response.Boards;
        }

        public async Task<Board> GetOne(string id) {
            var query = new QueryQueryBuilder().WithBoards(
                new BoardQueryBuilder().WithAllScalarFields(),
                ids: new string[] { id }
            );
            var response = await client.RunQuery(query);
            return response.Boards?.FirstOrDefault();
        }

        public async Task<Board> Create(Board board, string templateID = null, bool? empty = null) {
            Utils.Utils.RequireArgument(nameof(board.Name), board.Name);
            Utils.Utils.RequireArgument(nameof(board.BoardKind), board.BoardKind);

            var mutation = new MutationQueryBuilder().WithCreateBoard(
                new BoardQueryBuilder().WithAllScalarFields(),
                boardName: board.Name,
                boardKind: board.BoardKind.Value,
                description: board.Description,
                folderID: board.BoardFolderID,
                workspaceID: board.WorkspaceID,
                templateID: templateID,
                boardOwnerIDs: null,
                boardOwnerTeamIDs: null,
                boardSubscriberIDs: null,
                boardSubscriberTeamsIDs: null,
                empty: empty
            );

            var response = await client.RunMutation(mutation);
            return response.CreateBoard;
        }

        public async Task<UpdateBoardResponse> Update(string id, BoardAttributes attribute, string newValue) {
            var mutation = new MutationQueryBuilder().WithUpdateBoard(
                boardID: id,
                boardAttribute: attribute,
                newValue: newValue
            );

            var response = await client.RunMutation(mutation);
            return Newtonsoft.Json.JsonConvert.DeserializeObject<UpdateBoardResponse>(response.UpdateBoard);
        }

        public async Task<Board> Delete(string id) {
            var mutation = new MutationQueryBuilder().WithDeleteBoard(new BoardQueryBuilder().WithAllScalarFields(), id);

            var response = await client.RunMutation(mutation);
            return response.DeleteBoard;
        }
    }
}
