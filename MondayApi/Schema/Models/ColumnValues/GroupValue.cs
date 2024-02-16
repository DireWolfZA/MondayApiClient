using Newtonsoft.Json;

namespace MondayApi.Schema {
    [GraphQlObjectType("GroupValue")]
    public class GroupValue : IMirroredValue, IColumnValue {
        public Column Column { get; set; }
        public Group Group { get; set; }
        [JsonProperty("group_id")]
        public string GroupID { get; set; }
        public string ID { get; set; }
        public string Text { get; set; }
        public ColumnType? Type { get; set; }
        public object Value { get; set; }
    }
}
