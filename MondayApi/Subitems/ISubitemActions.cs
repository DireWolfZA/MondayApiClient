using System.Collections.Generic;
using System.Threading.Tasks;
using MondayApi.Schema;

namespace MondayApi.Subitems {
    public interface ISubitemActions {
        Task<IEnumerable<Item>> GetAsync(string parentItemID, bool withColumnValues = false, IEnumerable<string> columnIDs = null);
        /// <param name="columnValues"><see cref="KeyValuePair{TKey, TValue}.Key"/> in this Dictionary is the column ID</param>
        Task<Item> CreateSubitem(string itemName, string parentItemID, Dictionary<string, IColumnValue> columnValues = null, bool? createLabelsIfMissing = null);
    }
}
