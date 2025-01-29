using MondayApi.Schema;

namespace MondayApi.Columns {
    [System.Diagnostics.DebuggerDisplay("{BoardID}/{ItemID} {Value.Type}")]
    public class ColumnMultipleUpdateValue {
        public string BoardID;
        public string ItemID;
        public IColumnValue Value;
    }
}
