using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace MondayApi.Schema {
    [System.Diagnostics.DebuggerDisplay("{ID}: {TextBody}")]
    public class Reply {
        public string? ID { get; set; }
        public string? Body { get; set; }
        public string? Kind { get; set; }
        [JsonProperty("creator_id")]
        public string? CreatorID { get; set; }
        [JsonProperty("edited_at")]
        public DateTimeOffset? EditedAt { get; set; }
        public User? Creator { get; set; }
        public ICollection<Like>? Likes { get; set; }
        [JsonProperty("pinned_to_top")]
        public ICollection<UpdatePin>? PinnedToTop { get; set; }
        public ICollection<Watcher>? Viewers { get; set; }
        [JsonProperty("created_at")]
        public DateTimeOffset? CreatedAt { get; set; }
        [JsonProperty("updated_at")]
        public DateTimeOffset? UpdatedAt { get; set; }
        [JsonProperty("text_body")]
        public string? TextBody { get; set; }
    }
}
