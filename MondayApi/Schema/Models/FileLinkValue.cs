using System;
using Newtonsoft.Json;

namespace MondayApi.Schema {
    public class FileLinkValue {
        [JsonProperty("created_at")]
        public DateTimeOffset? CreatedAt { get; set; }
        public User Creator { get; set; }
        [JsonProperty("creator_id")]
        public string CreatorID { get; set; }
        [JsonProperty("file_id")]
        public string FileID { get; set; }
        public FileLinkValueKind? Kind { get; set; }
        public string Name { get; set; }
        public string URL { get; set; }
    }
}
