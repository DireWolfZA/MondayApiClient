using System.Collections.Generic;
using System.Threading.Tasks;
using MondayApi.Schema;

namespace MondayApi.Columns {
    public interface IColumnActions {
        Task<IEnumerable<Column>> GetAsync(string boardID);
        Task<Column> GetOneAsync(string boardID, string columnID);
        Task<string> GetSubitemsBoardIDAsync(string boardID);
        Task<Item> ChangeValueAsync(string boardID, string columnID, string itemID, IColumnValue value, bool? createLabelsIfMissing = null);
        Task<Item> ChangeValueSimpleAsync(string boardID, string columnID, string itemID, string value, bool? createLabelsIfMissing = null);
        /// <param name="values"><see cref="KeyValuePair{TKey, TValue}.Key"/> in this Dictionary is the column ID</param>
        Task<Item> ChangeMultipleValuesAsync(string boardID, string itemID, Dictionary<string, IColumnValue> values, bool? createLabelsIfMissing = null);
    }
}
