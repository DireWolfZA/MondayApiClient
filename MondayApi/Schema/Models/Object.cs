using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace MondayApi.Schema {
    public class Object {
        public string? ID { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        [JsonProperty("privacy_kind")]
        public string? PrivacyKind { get; set; }
        [JsonProperty("folder_id")]
        public string? FolderID { get; set; }
        [JsonProperty("updated_at")]
        public DateTimeOffset? UpdatedAt { get; set; }
        public string? State { get; set; }
        public string? Creator { get; set; }
        [JsonProperty("workspace_id")]
        public string? WorkspaceID { get; set; }
        public ICollection<User>? Owners { get; set; }
        public ICollection<User>? Subscribers { get; set; }
    }
}
