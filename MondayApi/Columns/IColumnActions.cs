using System.Collections.Generic;
using System.Threading.Tasks;
using MondayApi.Schema;

namespace MondayApi.Columns {
    public interface IColumnActions {
        Task<IEnumerable<Column>> GetAsync(string boardID);
        Task<ICollection<ColumnMappingInput>> FillColumnMapping(string boardID, ICollection<ColumnMappingInput> columnMapping);
        Task<Column> GetOneAsync(string boardID, string columnID);
        Task<string> GetSubitemsBoardIDAsync(string boardID);

        Task<Item> ChangeValueAsync(string boardID, string itemID, IColumnValue value, bool? createLabelsIfMissing = null);
        Task<Item> ChangeValueSimpleAsync(string boardID, string columnID, string itemID, string value, bool? createLabelsIfMissing = null);
        Task<Item> ChangeMultipleValuesAsync(string boardID, string itemID, IEnumerable<IColumnValue> values, bool? createLabelsIfMissing = null);
        Task<IEnumerable<Item>> ChangeMultipleItemsAsync(IEnumerable<ColumnMultipleUpdateValue> values, bool? createLabelsIfMissing = null);
    }
}
