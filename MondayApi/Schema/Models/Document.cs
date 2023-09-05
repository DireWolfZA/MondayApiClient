using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace MondayApi.Schema {
    public class Document {
        public ICollection<DocumentBlock> Blocks { get; set; }
        [JsonProperty("created_at")]
        public DateTimeOffset? CreatedAt { get; set; }
        [JsonProperty("created_by")]
        public User CreatedBy { get; set; }
        [JsonProperty("doc_folder_id")]
        public string DocFolderID { get; set; }
        [JsonProperty("doc_kind")]
        public BoardKind? DocKind { get; set; }
        public string ID { get; set; }
        public string Name { get; set; }
        [JsonProperty("object_id")]
        public string ObjectID { get; set; }
        [JsonProperty("relative_url")]
        public string RelativeURL { get; set; }
        public object Settings { get; set; }
        public string URL { get; set; }
        public Workspace Workspace { get; set; }
        [JsonProperty("workspace_id")]
        public string WorkspaceID { get; set; }
    }
}
