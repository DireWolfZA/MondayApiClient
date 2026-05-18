using System;
using Newtonsoft.Json;

namespace MondayApi.Schema {
    public class Event {
        public string? ID { get; set; }
        public string? Type { get; set; }
        public string? State { get; set; }
        [JsonProperty("board_id")]
        public string? BoardID { get; set; }
        [JsonProperty("event_data")]
        public object? EventData { get; set; }
        [JsonProperty("origin_last_updated")]
        public string? OriginLastUpdated { get; set; }
        [JsonProperty("created_at")]
        public DateTimeOffset? CreatedAt { get; set; }
        [JsonProperty("updated_at")]
        public DateTimeOffset? UpdatedAt { get; set; }
    }
}
