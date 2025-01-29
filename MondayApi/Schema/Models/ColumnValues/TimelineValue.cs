using System;
using Newtonsoft.Json;

namespace MondayApi.Schema {
    [System.Diagnostics.DebuggerDisplay("{Type.ToString(),nq}:{ID}: {Text}")]
    [GraphQlObjectType("TimelineValue")]
    public class TimelineValue : IMirroredValue, IColumnValue {
        public Column Column { get; set; }
        public DateTimeOffset? From { get; set; }
        public string ID { get; set; }
        public string Text { get; set; }
        public DateTimeOffset? To { get; set; }
        public ColumnType? Type { get; set; }
        [JsonProperty("updated_at")]
        public DateTimeOffset? UpdatedAt { get; set; }
        public object Value { get; set; }
        [JsonProperty("visualization_type")]
        public string VisualizationType { get; set; }
    }
}
