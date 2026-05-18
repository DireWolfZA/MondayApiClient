using Newtonsoft.Json;

namespace MondayApi.Schema {
    [System.Diagnostics.DebuggerDisplay("{Type.ToString(),nq}:{ID}: {Text}")]
    [GraphQlObjectType("UnsupportedValue")]
    public class UnsupportedValue : AddShallowCopy<IColumnValue>, IMirroredValue, IColumnValue {
        public Column? Column { get; set; }
        public string? ID { get; set; }
        [JsonProperty("is_leaf")]
        public bool? IsLeaf { get; set; }
        public string? Text { get; set; }
        public ColumnType? Type { get; set; }
        public object? Value { get; set; }
    }
}
