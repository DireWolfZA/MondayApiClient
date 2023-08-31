using Newtonsoft.Json;

namespace MondayApi.Schema {
    public class AppMonetizationStatus {
        [JsonProperty("is_supported")]
        public bool? IsSupported { get; set; }
    }
}
