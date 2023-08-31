using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace MondayApi.Schema {
    public class Folder {
        public ICollection<Board> Children { get; set; }
        public FolderColor? Color { get; set; }
        [JsonProperty("created_at")]
        public DateTimeOffset? CreatedAt { get; set; }
        public int? ID { get; set; }
        public string Name { get; set; }
        [JsonProperty("owner_id")]
        public int? OwnerID { get; set; }
        public Folder Parent { get; set; }
        [JsonProperty("sub_folders")]
        public ICollection<Folder> SubFolders { get; set; }
        public Workspace Workspace { get; set; }
    }
}
