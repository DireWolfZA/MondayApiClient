using System;
using Newtonsoft.Json;

namespace MondayApi.Schema {
    [System.Diagnostics.DebuggerDisplay("{Type.ToString(),nq}:{ID}: {Index} {Text}")]
    [GraphQlObjectType("StatusValue")]
    public class StatusValue : IMirroredValue, IColumnValue {
        public Column? Column { get; set; }
        public string? ID { get; set; }
        public int? Index { get; set; }
        [JsonProperty("is_done")]
        public bool? IsDone { get; set; }
        public string? Label { get; set; }
        [JsonProperty("label_style")]
        public StatusLabelStyle? LabelStyle { get; set; }
        public string? Text { get; set; }
        public ColumnType? Type { get; set; }
        [JsonProperty("update_id")]
        public string? UpdateID { get; set; }
        [JsonProperty("updated_at")]
        public DateTimeOffset? UpdatedAt { get; set; }
        public object? Value { get; set; }
    }
}
