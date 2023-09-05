using System.Collections.Generic;

namespace MondayApi.Schema {
    [GraphQlObjectType("DropdownValue")]
    public class DropdownValue : IColumnValue {
        public Column Column { get; set; }
        public string ID { get; set; }
        public string Text { get; set; }
        public ColumnType? Type { get; set; }
        public object Value { get; set; }
        public ICollection<DropdownValueOption> Values { get; set; }
    }
}
