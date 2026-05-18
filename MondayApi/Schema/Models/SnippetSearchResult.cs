using System;
using Newtonsoft.Json;

namespace MondayApi.Schema {
    public class SnippetSearchResult {
        public string? ID { get; set; }
        public string? Title { get; set; }
        public string? Text { get; set; }
        [JsonProperty("parent_id")]
        public string? ParentID { get; set; }
        [JsonProperty("created_at")]
        public DateTimeOffset? CreatedAt { get; set; }
        [JsonProperty("updated_at")]
        public DateTimeOffset? UpdatedAt { get; set; }
        public decimal? Distance { get; set; }
        public string? URL { get; set; }
    }
}
