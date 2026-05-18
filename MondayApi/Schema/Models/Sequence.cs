using System;
using Newtonsoft.Json;

namespace MondayApi.Schema {
    public class Sequence {
        public string? ID { get; set; }
        public string? Title { get; set; }
        public SequenceStatus? Status { get; set; }
        [JsonProperty("context_type")]
        public SequenceContext? ContextType { get; set; }
        [JsonProperty("context_id")]
        public string? ContextID { get; set; }
        [JsonProperty("user_id")]
        public string? UserID { get; set; }
        [JsonProperty("step_count")]
        public int? StepCount { get; set; }
        public int? Duration { get; set; }
        [JsonProperty("created_at")]
        public DateTimeOffset? CreatedAt { get; set; }
        [JsonProperty("updated_at")]
        public DateTimeOffset? UpdatedAt { get; set; }
    }
}
