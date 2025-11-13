using System;
using Newtonsoft.Json;

namespace MondayApi.Schema {
    public class ArticleBlock {
        public string? ID { get; set; }
        public object? Content { get; set; }
        [JsonProperty("created_at")]
        public DateTimeOffset? CreatedAt { get; set; }
        [JsonProperty("created_by")]
        public User? CreatedBy { get; set; }
        [JsonProperty("published_article_id")]
        public string? PublishedArticleID { get; set; }
        [JsonProperty("parent_block_id")]
        public string? ParentBlockID { get; set; }
        public decimal? Position { get; set; }
        public string? Type { get; set; }
        [JsonProperty("updated_at")]
        public DateTimeOffset? UpdatedAt { get; set; }
    }
}
