using System.Collections.Generic;
using System.Threading.Tasks;
using MondayApi.Schema;

namespace MondayApi.Boards {
    public interface IBoardActions {
        Task<IEnumerable<Board>> Get(int pageNumber, int numPerPage);
        Task<Board> GetOne(string id);
        Task<Board> Create(Board board, string templateID = null, bool? empty = null);
        Task<UpdateBoardResponse> Update(string id, BoardAttributes attribute, string newValue);
        Task<Board> Delete(string id);
    }
}
