using System;
using Newtonsoft.Json;

namespace MondayApi.Schema {
    [System.Diagnostics.DebuggerDisplay("{Type.ToString(),nq}:{ID}: {Text}")]
    [GraphQlObjectType("HourValue")]
    public class HourValue : IMirroredValue, IColumnValue {
        public Column Column { get; set; }
        public int? Hour { get; set; }
        public string ID { get; set; }
        public int? Minute { get; set; }
        public string Text { get; set; }
        public ColumnType? Type { get; set; }
        [JsonProperty("updated_at")]
        public DateTimeOffset? UpdatedAt { get; set; }
        public object Value { get; set; }
    }
}
