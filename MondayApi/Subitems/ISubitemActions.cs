using System.Collections.Generic;
using System.Threading.Tasks;
using MondayApi.Schema;

namespace MondayApi.Subitems {
    public interface ISubitemActions {
        Task<IEnumerable<Item>> Get(string parentItemID, bool withColumnValues = false, IEnumerable<string> columnIDs = null);
        Task<Item> GetParentItem(string subitemID, bool withColumnValues = false, IEnumerable<string> columnIDs = null);

        Task<Item> CreateSubitem(string itemName, string parentItemID, IEnumerable<IColumnValue> columnValues = null, bool? createLabelsIfMissing = null);
        /// <summary>Allows creating multiple subitems with one request</summary>
        /// <param name="items">Subitems to be created. Properties used are <see cref="Item.Name"/> and <see cref="Item.ColumnValues"/></param>
        Task<IEnumerable<Item>> CreateMultiple(string parentItemID, IEnumerable<Item> items, bool? createLabelsIfMissing = null);
    }
}
