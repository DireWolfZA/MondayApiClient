using System.Threading.Tasks;
using MondayApi.Schema;

namespace MondayApi.Items {
    public interface IItemActions {
        Task<ItemsResponse> GetByBoardAsync(string cursor, int numPerPage, string boardID);
        Task<ItemsResponse> GetByBoardGroupAsync(string cursor, int numPerPage, string boardID, string groupID);
        Task<Item> GetOneAsync(string id);
    }
}
