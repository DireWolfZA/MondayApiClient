using Newtonsoft.Json;

namespace MondayApi.Schema {
    public class ToolEvent {
        public string? ID { get; set; }
        [JsonProperty("account_id")]
        public string? AccountID { get; set; }
        [JsonProperty("user_id")]
        public string? UserID { get; set; }
        [JsonProperty("trigger_uuid")]
        public string? TriggerUUID { get; set; }
        [JsonProperty("atomic_action_id")]
        public string? AtomicActionID { get; set; }
        [JsonProperty("recipe_id")]
        public string? RecipeID { get; set; }
        [JsonProperty("integration_id")]
        public string? IntegrationID { get; set; }
        [JsonProperty("tool_name")]
        public string? ToolName { get; set; }
        [JsonProperty("mcp_server")]
        public string? MCPServer { get; set; }
        [JsonProperty("event_status")]
        public string? EventStatus { get; set; }
        [JsonProperty("error_message")]
        public string? ErrorMessage { get; set; }
        [JsonProperty("tool_start_timestamp")]
        public decimal? ToolStartTimestamp { get; set; }
        [JsonProperty("tool_finish_timestamp")]
        public decimal? ToolFinishTimestamp { get; set; }
        [JsonProperty("execution_duration_ms")]
        public int? ExecutionDurationMs { get; set; }
    }
}
