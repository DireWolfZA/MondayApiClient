using System.Collections.Generic;
using Newtonsoft.Json;

namespace MondayApi.Schema {
    [System.Diagnostics.DebuggerDisplay("{Type.ToString(),nq}:{ID}: {Text}")]
    [GraphQlObjectType("FileValue")]
    public class FileValue : IMirroredValue, IColumnValue {
        public Column Column { get; set; }
        [JsonConverter(typeof(GraphQlInterfaceJsonConverter))]
        public ICollection<IFileValueItem> Files { get; set; }
        public string ID { get; set; }
        public string Text { get; set; }
        public ColumnType? Type { get; set; }
        public object Value { get; set; }
    }
}
