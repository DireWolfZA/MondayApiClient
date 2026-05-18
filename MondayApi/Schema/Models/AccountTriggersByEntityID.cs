using Newtonsoft.Json;

namespace MondayApi.Schema {
    public class AccountTriggersByEntityID {
        public string? ID { get; set; }
        [JsonProperty("automation_statistics")]
        public object? AutomationStatistics { get; set; }
        [JsonProperty("workflow_statistics")]
        public object? WorkflowStatistics { get; set; }
    }
}
