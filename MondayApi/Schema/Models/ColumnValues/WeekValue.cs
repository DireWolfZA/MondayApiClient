using Newtonsoft.Json;

namespace MondayApi.Schema {
    [GraphQlObjectType("WeekValue")]
    public class WeekValue : IMirroredValue, IColumnValue {
        public Column Column { get; set; }
        [JsonProperty("end_date")]
        public object EndDate { get; set; }
        public string ID { get; set; }
        [JsonProperty("start_date")]
        public object StartDate { get; set; }
        public string Text { get; set; }
        public ColumnType? Type { get; set; }
        public object Value { get; set; }
    }
}
