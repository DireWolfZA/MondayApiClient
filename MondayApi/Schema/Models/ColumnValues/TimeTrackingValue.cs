using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace MondayApi.Schema {
    [GraphQlObjectType("TimeTrackingValue")]
    public class TimeTrackingValue : IMirroredValue, IColumnValue {
        public Column Column { get; set; }
        public int? Duration { get; set; }
        public ICollection<TimeTrackingHistoryItem> History { get; set; }
        public string ID { get; set; }
        public bool? Running { get; set; }
        [JsonProperty("started_at")]
        public object StartedAt { get; set; }
        public string Text { get; set; }
        public ColumnType? Type { get; set; }
        [JsonProperty("updated_at")]
        public DateTimeOffset? UpdatedAt { get; set; }
        public object Value { get; set; }
    }
}
