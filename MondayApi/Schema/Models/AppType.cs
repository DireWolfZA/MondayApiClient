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
        [JsonProperty("photo_url")]
        public string? PhotoURL { get; set; }
        [JsonProperty("photo_url_small")]
        public string? PhotoURLSmall { get; set; }
        public AppKind? Kind { get; set; }
        public AppStatus? Status { get; set; }
        [JsonProperty("version_type")]
        public string? VersionType { get; set; }
        public string? Description { get; set; }
        public string? Slug { get; set; }
        public ICollection<string>? Permissions { get; set; }
        [JsonProperty("webhook_url")]
        public string? WebhookURL { get; set; }
        [JsonProperty("created_by")]
        public string? CreatedBy { get; set; }
        [JsonProperty("account_id")]
        public string? AccountID { get; set; }
        public ICollection<User>? Collaborators { get; set; }
        public ICollection<AppFeatureType>? Features { get; set; }
    }
}
