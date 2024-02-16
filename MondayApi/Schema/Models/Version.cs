using Newtonsoft.Json;

namespace MondayApi.Schema {
    public class Version {
        [JsonProperty("display_name")]
        public string DisplayName { get; set; }
        public VersionKind? Kind { get; set; }
        public string Value { get; set; }
    }
}
