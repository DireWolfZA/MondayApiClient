using Newtonsoft.Json;

namespace MondayApi.Schema {
    [GraphQlObjectType("AggregateGroupByResult")]
    public class AggregateGroupByResult : IAggregateResult {
        [JsonProperty("value_string")]
        public string? ValueString { get; set; }
        [JsonProperty("value_int")]
        public int? ValueInt { get; set; }
        [JsonProperty("value_float")]
        public decimal? ValueFloat { get; set; }
        [JsonProperty("value_boolean")]
        public bool? ValueBoolean { get; set; }
    }
}
