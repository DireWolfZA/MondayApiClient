using System;
using Newtonsoft.Json;

namespace MondayApi.Schema {
    [GraphQlObjectType("RatingValue")]
    public class RatingValue : IMirroredValue, IColumnValue {
        public Column Column { get; set; }
        public string ID { get; set; }
        public int? Rating { get; set; }
        public string Text { get; set; }
        public ColumnType? Type { get; set; }
        [JsonProperty("updated_at")]
        public DateTimeOffset? UpdatedAt { get; set; }
        public object Value { get; set; }
    }
}
