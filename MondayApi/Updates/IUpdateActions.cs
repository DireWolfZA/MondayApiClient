using System.Collections.Generic;
using System.Threading.Tasks;
using MondayApi.Schema;

namespace MondayApi.Updates {
    public interface IUpdateActions {
        Task<IEnumerable<Update>> Get(int pageNumber, int numPerPage, bool includeReplies = false);
        Task<IEnumerable<Update>?> GetByBoard(int pageNumber, int numPerPage, string boardID, bool includeReplies = false);
        Task<IEnumerable<Update>?> GetByItem(int pageNumber, int numPerPage, string itemID, bool includeReplies = false);
        Task<Update> Create(string itemID, string body, string? parentUpdateID = null);
        /// <summary>Beware - returned data does not resemble the update, and the update ID is not valid</summary>
        Task<Update> Like(string updateID);
        Task<Update> Delete(string updateID);
        Task<Item> ClearForItem(string itemID);
    }
}
