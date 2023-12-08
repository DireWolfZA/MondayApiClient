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
        /// <summary>Allows creating multiple items with one request</summary>
        /// <param name="items">Items to be created. Properties used are <see cref="Item.Name"/>, <see cref="Item"/>.<see cref="Board.ID"/>, <see cref="Item"/>.<see cref="Group.ID"/> and <see cref="Item.ColumnValues"/></param>
        Task<IEnumerable<Item>> CreateMultipleAsync(IEnumerable<Item> items, bool? createLabelsIfMissing = null);
        Task<Item> MoveToGroupAsync(string itemID, string groupID);
        Task<Item> MoveToBoardAsync(string itemID, string boardID, string groupID, IEnumerable<ColumnMappingInput> columnsMapping = null, IEnumerable<ColumnMappingInput> subitemsColumnsMapping = null);
        Task<Item> DuplicateAsync(string itemID, string boardID, bool? withUpdates = false);
        Task<Item> DeleteAsync(string id);
    }
}
