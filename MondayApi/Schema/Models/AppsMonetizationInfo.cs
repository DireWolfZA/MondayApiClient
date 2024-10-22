using Newtonsoft.Json;

namespace MondayApi.Schema {
    public class AppsMonetizationInfo {
        [JsonProperty("seats_count")]
        public int? SeatsCount { get; set; }
    }
}
