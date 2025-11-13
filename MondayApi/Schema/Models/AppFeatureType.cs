using System;
using Newtonsoft.Json;

namespace MondayApi.Schema {
    public class AppFeatureType {
        public string? ID { get; set; }
        [JsonProperty("created_at")]
        public DateTimeOffset? CreatedAt { get; set; }
        [JsonProperty("updated_at")]
        public DateTimeOffset? UpdatedAt { get; set; }
        public string? Name { get; set; }
        [JsonProperty("app_id")]
        public string? AppID { get; set; }
        public string? Type { get; set; }
        public object? Data { get; set; }
        public object? Deployment { get; set; }
    }
}
