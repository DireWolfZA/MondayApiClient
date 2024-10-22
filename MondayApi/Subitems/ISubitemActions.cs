using System.Collections.Generic;
using System.Threading.Tasks;
using MondayApi.Schema;

namespace MondayApi.Subitems {
    public interface ISubitemActions {
        Task<IEnumerable<Item>> Get(string parentItemID, bool withColumnValues = false, IEnumerable<string> columnIDs = null);
        Task<Item> CreateSubitem(string itemName, string parentItemID, IEnumerable<IColumnValue> columnValues = null, bool? createLabelsIfMissing = null);
    }
}
