using System;
using Newtonsoft.Json;

namespace MondayApi.Schema {
    public class DocumentBlock {
        public object? Content { get; set; }
        [JsonProperty("created_at")]
        public DateTimeOffset? CreatedAt { get; set; }
        [JsonProperty("created_by")]
        public User? CreatedBy { get; set; }
        [JsonProperty("doc_id")]
        public string? DocID { get; set; }
        public string? ID { get; set; }
        [JsonProperty("parent_block_id")]
        public string? ParentBlockID { get; set; }
        public decimal? Position { get; set; }
        public string? Type { get; set; }
        [JsonProperty("updated_at")]
        public DateTimeOffset? UpdatedAt { get; set; }
    }
}
