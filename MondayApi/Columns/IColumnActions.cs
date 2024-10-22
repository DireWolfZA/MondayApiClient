using System.Collections.Generic;
using System.Threading.Tasks;
using MondayApi.Schema;

namespace MondayApi.Columns {
    public interface IColumnActions {
        Task<IEnumerable<Column>> Get(string boardID);
        Task<ICollection<ColumnMappingInput>> FillColumnMapping(string boardID, ICollection<ColumnMappingInput> columnMapping);
        Task<Column> GetOne(string boardID, string columnID);
        Task<string> GetSubitemsBoardID(string boardID);

        Task<Item> ChangeValue(string boardID, string itemID, IColumnValue value, bool? createLabelsIfMissing = null);
        Task<Item> ChangeValueSimple(string boardID, string columnID, string itemID, string value, bool? createLabelsIfMissing = null);
        Task<Item> ChangeMultipleValues(string boardID, string itemID, IEnumerable<IColumnValue> values, bool? createLabelsIfMissing = null);
        Task<IEnumerable<Item>> ChangeMultipleItems(IEnumerable<ColumnMultipleUpdateValue> values, bool? createLabelsIfMissing = null);

        /// <summary>
        /// Creates a column in a board.
        /// <br />Please note that the <see cref="Column.ID"/> has the following restrictions:
        /// <br />- [1-20] characters in length (inclusive)
        /// <br />- Only lowercase letters (a-z) and underscores (_)
        /// <br />- Must be unique (no other column on the board can have the same ID)
        /// <br />- Can't reuse column IDs, even if the column has been deleted from the board
        /// <br />- Can't be null, blank, or an empty string
        /// </summary>
        Task<Column> Create(string boardID, Column column, string afterColumnID = null, string defaults = null);
    }
}
