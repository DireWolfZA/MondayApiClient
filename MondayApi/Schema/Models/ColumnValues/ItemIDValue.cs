using Newtonsoft.Json;

namespace MondayApi.Schema {
    [System.Diagnostics.DebuggerDisplay("{Type.ToString(),nq}:{ID}: {Text}")]
    [GraphQlObjectType("ItemIdValue")]
    public class ItemIDValue : AddShallowCopy<IColumnValue>, IMirroredValue, IColumnValue {
        public Column? Column { get; set; }
        public string? ID { get; set; }
        [JsonProperty("item_id")]
        public string? ItemID { get; set; }
        public string? Text { get; set; }
        public ColumnType? Type { get; set; }
        public object? Value { get; set; }
    }
}
