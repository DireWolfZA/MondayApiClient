using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace MondayApi.Schema {
    public class ArticleMetadata {
        [JsonProperty("object_id")]
        public string? ObjectID { get; set; }
        [JsonProperty("draft_article_id")]
        public string? DraftArticleID { get; set; }
        [JsonProperty("published_article_id")]
        public string? PublishedArticleID { get; set; }
        public string? Name { get; set; }
        [JsonProperty("privacy_kind")]
        public string? PrivacyKind { get; set; }
        [JsonProperty("workspace_id")]
        public string? WorkspaceID { get; set; }
        [JsonProperty("folder_id")]
        public string? FolderID { get; set; }
        [JsonProperty("updated_at")]
        public DateTimeOffset? UpdatedAt { get; set; }
        public string? State { get; set; }
        public string? Creator { get; set; }
        public ICollection<User>? Owners { get; set; }
        public ICollection<User>? Subscribers { get; set; }
    }
}
