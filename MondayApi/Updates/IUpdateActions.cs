using System.Collections.Generic;
using System.Threading.Tasks;
using MondayApi.Schema;

namespace MondayApi.Updates {
    public interface IUpdateActions {
        Task<IEnumerable<Update>> GetAsync(int pageNumber, int numPerPage, bool includeReplies = false);
        Task<IEnumerable<Update>> GetByBoardAsync(int pageNumber, int numPerPage, string boardID, bool includeReplies = false);
        Task<IEnumerable<Update>> GetByItemAsync(int pageNumber, int numPerPage, string itemID, bool includeReplies = false);
        Task<Update> CreateAsync(string itemID, string body, string parentUpdateID = null);
        /// <summary>Beware - returned data does not resemble the update, and the update ID is not valid</summary>
        Task<Update> LikeAsync(string updateID);
        Task<Update> DeleteAsync(string updateID);
        Task<Item> ClearForItemAsync(string itemID);
    }
}
