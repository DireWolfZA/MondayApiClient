using System;
using Newtonsoft.Json;

namespace MondayApi.Schema {
    [GraphQlObjectType("PersonValue")]
    public class PersonValue : IMirroredValue, IColumnValue {
        public Column Column { get; set; }
        public string ID { get; set; }
        [JsonProperty("person_id")]
        public string PersonID { get; set; }
        public string Text { get; set; }
        public ColumnType? Type { get; set; }
        [JsonProperty("updated_at")]
        public DateTimeOffset? UpdatedAt { get; set; }
        public object Value { get; set; }
    }
}
