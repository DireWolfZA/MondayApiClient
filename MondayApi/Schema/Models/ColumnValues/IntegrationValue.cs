using System;
using Newtonsoft.Json;

namespace MondayApi.Schema {
    [GraphQlObjectType("IntegrationValue")]
    public class IntegrationValue : IColumnValue {
        public Column Column { get; set; }
        [JsonProperty("entity_id")]
        public Guid? EntityID { get; set; }
        public string ID { get; set; }
        [JsonProperty("issue_api_url")]
        public Guid? IssueAPIURL { get; set; }
        [JsonProperty("issue_id")]
        public string IssueID { get; set; }
        public string Text { get; set; }
        public ColumnType? Type { get; set; }
        public object Value { get; set; }
    }
}
