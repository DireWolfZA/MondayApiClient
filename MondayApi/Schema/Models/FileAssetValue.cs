using System;
using Newtonsoft.Json;

namespace MondayApi.Schema {
    [GraphQlObjectType("FileAssetValue")]
    public class FileAssetValue : IFileValueItem {
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
    }
}
