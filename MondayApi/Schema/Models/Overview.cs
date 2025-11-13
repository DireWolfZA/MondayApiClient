using System;
using Newtonsoft.Json;

namespace MondayApi.Schema {
    public class Overview {
        [JsonProperty("created_at")]
        public DateTimeOffset? CreatedAt { get; set; }
        public User? Creator { get; set; }
        [JsonProperty("folder_id")]
        public string? FolderID { get; set; }
        public string? ID { get; set; }
        public string? Kind { get; set; }
        public string? Name { get; set; }
        public string? State { get; set; }
        [JsonProperty("updated_at")]
        public DateTimeOffset? UpdatedAt { get; set; }
        [JsonProperty("workspace_id")]
        public string? WorkspaceID { get; set; }
    }
}
