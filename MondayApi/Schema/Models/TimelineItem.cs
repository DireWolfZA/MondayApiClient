using System;
using Newtonsoft.Json;

namespace MondayApi.Schema {
    [System.Diagnostics.DebuggerDisplay("{ID}: {Title}")]
    public class TimelineItem {
        public string? ID { get; set; }
        public string? Type { get; set; }
        public Item? Item { get; set; }
        public Board? Board { get; set; }
        public User? User { get; set; }
        public string? Title { get; set; }
        [JsonProperty("custom_activity_id")]
        public string? CustomActivityID { get; set; }
        public string? Content { get; set; }
        [JsonProperty("created_at")]
        public DateTimeOffset? CreatedAt { get; set; }
    }
}
