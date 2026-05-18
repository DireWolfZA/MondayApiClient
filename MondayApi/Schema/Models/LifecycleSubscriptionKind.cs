using System;
using Newtonsoft.Json;

namespace MondayApi.Schema {
    public class LifecycleSubscriptionKind {
        public string? ID { get; set; }
        [JsonProperty("entity_id")]
        public string? EntityID { get; set; }
        [JsonProperty("entity_type")]
        public string? EntityType { get; set; }
        [JsonProperty("event_type")]
        public string? EventType { get; set; }
        [JsonProperty("webhook_url")]
        public string? WebhookURL { get; set; }
        [JsonProperty("is_sync")]
        public bool? IsSync { get; set; }
        [JsonProperty("created_at")]
        public DateTimeOffset? CreatedAt { get; set; }
        [JsonProperty("updated_at")]
        public DateTimeOffset? UpdatedAt { get; set; }
    }
}
