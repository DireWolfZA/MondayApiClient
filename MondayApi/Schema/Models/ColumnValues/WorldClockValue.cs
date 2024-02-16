using System;
using Newtonsoft.Json;

namespace MondayApi.Schema {
    [GraphQlObjectType("WorldClockValue")]
    public class WorldClockValue : IMirroredValue, IColumnValue {
        public Column Column { get; set; }
        public string ID { get; set; }
        public string Text { get; set; }
        public string Timezone { get; set; }
        public ColumnType? Type { get; set; }
        [JsonProperty("updated_at")]
        public DateTimeOffset? UpdatedAt { get; set; }
        public object Value { get; set; }
    }
}
