using System.Collections.Generic;
using System.Threading.Tasks;
using MondayApi.Schema;

namespace MondayApi.Boards {
    public interface IBoardActions {
        Task<IEnumerable<Board>> GetAsync(int pageNumber, int numPerPage);
        Task<Board> GetOneAsync(string id);
        Task<Board> CreateAsync(Board board, string templateID = null, bool? empty = null);
        Task<UpdateBoardResponse> UpdateAsync(string id, BoardAttributes attribute, string newValue);
        Task<Board> DeleteAsync(string id);
    }
}
