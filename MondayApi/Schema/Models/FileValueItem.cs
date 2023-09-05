using System;
using Newtonsoft.Json;

namespace MondayApi.Schema {
    public class FileValueItem {
        public Asset Asset { get; set; }
        [JsonProperty("asset_id")]
        public string AssetID { get; set; }
        [JsonProperty("created_at")]
        public DateTimeOffset? CreatedAt { get; set; }
        public User Creator { get; set; }
        [JsonProperty("creator_id")]
        public string CreatorID { get; set; }
        [JsonProperty("is_image")]
        public bool? IsImage { get; set; }
        public string Name { get; set; }
        public Document Doc { get; set; }
        [JsonProperty("file_id")]
        public string FileID { get; set; }
        [JsonProperty("object_id")]
        public string ObjectID { get; set; }
        public string Url { get; set; }
        public FileLinkValueKind? Kind { get; set; }
    }
}
