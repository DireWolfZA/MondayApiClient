using Newtonsoft.Json;

namespace MondayApi.Schema {
    public class ExtendTrialPeriod {
        [JsonProperty("account_slug")]
        public string? AccountSlug { get; set; }
        public string? Reason { get; set; }
        public bool? Success { get; set; }
    }
}
