using System;
using Newtonsoft.Json;

namespace MondayApi.Schema {
    public class GraphQLFolder {
        public string? ID { get; set; }
        public string? AccountID { get; set; }
        public string? Name { get; set; }
        public DateTimeOffset? CreatedAt { get; set; }
        public DateTimeOffset? UpdatedAt { get; set; }
        public string? CreatedBy { get; set; }
        [JsonProperty("app_feature_slug")]
        public string? AppFeatureSlug { get; set; }
    }
}
