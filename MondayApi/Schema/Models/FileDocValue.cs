using System;
using Newtonsoft.Json;

namespace MondayApi.Schema {
    public class FileDocValue : IFileValueItem {
        [JsonProperty("created_at")]
        public DateTimeOffset? CreatedAt { get; set; }
        public User Creator { get; set; }
        [JsonProperty("creator_id")]
        public string CreatorID { get; set; }
        public Document Doc { get; set; }
        [JsonProperty("file_id")]
        public string FileID { get; set; }
        [JsonProperty("object_id")]
        public string ObjectID { get; set; }
        public string URL { get; set; }
    }
}
