using System;
using Newtonsoft.Json;

namespace MondayApi.Schema {
    [GraphQlObjectType("CreationLogValue")]
    public class CreationLogValue : IColumnValue {
        public Column Column { get; set; }
        [JsonProperty("created_at")]
        public DateTimeOffset? CreatedAt { get; set; }
        public User Creator { get; set; }
        [JsonProperty("creator_id")]
        public string CreatorID { get; set; }
        public string ID { get; set; }
        public string Text { get; set; }
        public ColumnType? Type { get; set; }
        public object Value { get; set; }
    }
}
