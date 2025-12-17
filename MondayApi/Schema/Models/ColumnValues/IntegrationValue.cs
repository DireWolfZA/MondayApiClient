using Newtonsoft.Json;

namespace MondayApi.Schema {
    [System.Diagnostics.DebuggerDisplay("{Type.ToString(),nq}:{ID}: {Text}")]
    [GraphQlObjectType("IntegrationValue")]
    public class IntegrationValue : AddShallowCopy<IColumnValue>, IMirroredValue, IColumnValue {
        public Column? Column { get; set; }
        [JsonProperty("entity_id")]
        public string? EntityID { get; set; }
        public string? ID { get; set; }
        [JsonProperty("issue_api_url")]
        public string? IssueAPIURL { get; set; }
        [JsonProperty("issue_id")]
        public string? IssueID { get; set; }
        public string? Text { get; set; }
        public ColumnType? Type { get; set; }
        public object? Value { get; set; }
    }
}
