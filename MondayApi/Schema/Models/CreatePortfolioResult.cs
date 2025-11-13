using Newtonsoft.Json;

namespace MondayApi.Schema {
    public class CreatePortfolioResult {
        [JsonProperty("solution_live_version_id")]
        public string? SolutionLiveVersionID { get; set; }
        public bool? Success { get; set; }
        public string? Message { get; set; }
    }
}
