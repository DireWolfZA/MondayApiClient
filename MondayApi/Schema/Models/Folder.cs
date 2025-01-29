using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace MondayApi.Schema {
    [System.Diagnostics.DebuggerDisplay("{ID}: {Name}")]
    public class Folder {
        public ICollection<Board> Children { get; set; }
        public FolderColor? Color { get; set; }
        [JsonProperty("created_at")]
        public DateTimeOffset? CreatedAt { get; set; }
        [JsonProperty("custom_icon")]
        public FolderCustomIcon? CustomIcon { get; set; }
        [JsonProperty("font_weight")]
        public FolderFontWeight? FontWeight { get; set; }
        public string ID { get; set; }
        public string Name { get; set; }
        [JsonProperty("owner_id")]
        public string OwnerID { get; set; }
        public Folder Parent { get; set; }
        [JsonProperty("sub_folders")]
        public ICollection<Folder> SubFolders { get; set; }
        public Workspace Workspace { get; set; }
    }
}
