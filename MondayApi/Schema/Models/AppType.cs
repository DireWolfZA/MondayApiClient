using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace MondayApi.Schema {
    public class AppType {
        public string? ID { get; set; }
        [JsonProperty("created_at")]
        public DateTimeOffset? CreatedAt { get; set; }
        [JsonProperty("updated_at")]
        public DateTimeOffset? UpdatedAt { get; set; }
        public string? Name { get; set; }
        [JsonProperty("api_app_id")]
        public string? ApiAppID { get; set; }
        [JsonProperty("client_id")]
        public string? ClientID { get; set; }
        public string? Kind { get; set; }
        public string? State { get; set; }
        [JsonProperty("user_id")]
        public string? UserID { get; set; }
        public ICollection<AppFeatureType>? Features { get; set; }
    }
}
