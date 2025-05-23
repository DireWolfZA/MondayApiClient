using System;
using Newtonsoft.Json;

namespace MondayApi.Schema {
    public class Like {
        public string? ID { get; set; }
        [JsonProperty("creator_id")]
        public string? CreatorID { get; set; }
        public User? Creator { get; set; }
        [JsonProperty("reaction_type")]
        public string? ReactionType { get; set; }
        [JsonProperty("created_at")]
        public DateTimeOffset? CreatedAt { get; set; }
        [JsonProperty("updated_at")]
        public DateTimeOffset? UpdatedAt { get; set; }
    }
}
