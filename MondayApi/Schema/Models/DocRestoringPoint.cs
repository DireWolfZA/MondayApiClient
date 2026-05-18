using System.Collections.Generic;
using Newtonsoft.Json;

namespace MondayApi.Schema {
    public class DocRestoringPoint {
        public string? Date { get; set; }
        [JsonProperty("user_ids")]
        public ICollection<string>? UserIDs { get; set; }
        public string? Type { get; set; }
        [JsonProperty("agent_attributions")]
        public ICollection<RestoringPointAgentAttribution>? AgentAttributions { get; set; }
    }
}
