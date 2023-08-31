using Newtonsoft.Json;

namespace MondayApi.Schema {
    public class Complexity {
        public int? After { get; set; }
        public int? Before { get; set; }
        public int? Query { get; set; }
        [JsonProperty("reset_in_x_seconds")]
        public int? ResetInXSeconds { get; set; }
    }
}
