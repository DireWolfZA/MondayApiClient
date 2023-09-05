using System;
using Newtonsoft.Json;

namespace MondayApi.Schema {
    [GraphQlObjectType("CountryValue")]
    public class CountryValue : IColumnValue {
        public Column Column { get; set; }
        public Country Country { get; set; }
        public string ID { get; set; }
        public string Text { get; set; }
        public ColumnType? Type { get; set; }
        [JsonProperty("updated_at")]
        public DateTimeOffset? UpdatedAt { get; set; }
        public object Value { get; set; }
    }
}
