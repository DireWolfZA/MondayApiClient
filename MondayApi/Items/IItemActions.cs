using System.Collections.Generic;
using System.Threading.Tasks;
using MondayApi.Schema;

namespace MondayApi.Items {
    public interface IItemActions {
        Task<ItemsResponse> GetByBoardAsync(string cursor, int numPerPage, string boardID,
            bool withColumnValues = false, IEnumerable<string> columnIDs = null);
        Task<ItemsResponse> GetByBoardGroupAsync(string cursor, int numPerPage, string boardID, string groupID,
            bool withColumnValues = false, IEnumerable<string> columnIDs = null);
        Task<Item> GetOneAsync(string id,
            bool withColumnValues = false, IEnumerable<string> columnIDs = null);
        Task<string> GetLinkAsync(string id);

        Task<Item> CreateAsync(string itemName, string boardID, string groupID = null, IEnumerable<IColumnValue> columnValues = null, bool? createLabelsIfMissing = null);
        Task<Item> MoveToGroupAsync(string itemID, string groupID);
        Task<Item> DeleteAsync(string id);
    }
}
