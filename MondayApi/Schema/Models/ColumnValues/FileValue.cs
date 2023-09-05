using System.Collections.Generic;

namespace MondayApi.Schema {
    [GraphQlObjectType("FileValue")]
    public class FileValue : IColumnValue {
        public Column Column { get; set; }
        public ICollection<FileValueItem> Files { get; set; }
        public string ID { get; set; }
        public string Text { get; set; }
        public ColumnType? Type { get; set; }
        public object Value { get; set; }
    }
}
