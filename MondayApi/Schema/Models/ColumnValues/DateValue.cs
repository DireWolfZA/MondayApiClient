using System;
using Newtonsoft.Json;

namespace MondayApi.Schema {
    [System.Diagnostics.DebuggerDisplay("{Type.ToString(),nq}:{ID}: {Text}/{Date}")]
    [GraphQlObjectType("DateValue")]
    public class DateValue : AddShallowCopy<IColumnValue>, IMirroredValue, IColumnValue {
        public Column? Column { get; set; }
        public string? Date { get; set; }
        public string? Icon { get; set; }
        public string? ID { get; set; }
        public string? Text { get; set; }
        public string? Time { get; set; }
        public ColumnType? Type { get; set; }
        [JsonProperty("updated_at")]
        public DateTimeOffset? UpdatedAt { get; set; }
        public object? Value { get; set; }
    }
}
