using Newtonsoft.Json;

namespace MondayApi.Schema {
    public class RestoringPointAgentAttribution {
        [JsonProperty("agent_id")]
        public string? AgentID { get; set; }
        [JsonProperty("entity_type")]
        public string? EntityType { get; set; }
        [JsonProperty("agent_name")]
        public string? AgentName { get; set; }
    }
}
