using Newtonsoft.Json;

namespace MondayApi.Schema {
    public class ObjectTypeUniqueKeyData {
        [JsonProperty("app_name")]
        public string? AppName { get; set; }
        [JsonProperty("app_feature_name")]
        public string? AppFeatureName { get; set; }
        public string? Description { get; set; }
        [JsonProperty("object_type_unique_key")]
        public string? ObjectTypeUniqueKey { get; set; }
    }
}
