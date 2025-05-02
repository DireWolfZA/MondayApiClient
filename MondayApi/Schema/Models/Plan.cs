using Newtonsoft.Json;

namespace MondayApi.Schema {
    public class Plan {
        [JsonProperty("max_users")]
        public int? MaxUsers { get; set; }
        public string? Period { get; set; }
        public string? Tier { get; set; }
        public int? Version { get; set; }
    }
}
