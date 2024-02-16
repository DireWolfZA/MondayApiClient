using System;
using Newtonsoft.Json;

namespace MondayApi.Schema {
    [GraphQlObjectType("LinkValue")]
    public class LinkValue : IMirroredValue, IColumnValue {
        public Column Column { get; set; }
        public string ID { get; set; }
        public string Text { get; set; }
        public ColumnType? Type { get; set; }
        [JsonProperty("updated_at")]
        public DateTimeOffset? UpdatedAt { get; set; }
        public string URL { get; set; }
        [JsonProperty("url_text")]
        public string URLText { get; set; }
        public object Value { get; set; }
    }
}
