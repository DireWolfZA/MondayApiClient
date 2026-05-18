using System;
using Newtonsoft.Json;

namespace MondayApi.Schema {
    [GraphQlObjectType("FileAssetInvalidValue")]
    public class FileAssetInvalidValue : IFileValueItem {
        [JsonProperty("asset_id")]
        public string? AssetID { get; set; }
        [JsonProperty("created_at")]
        public DateTimeOffset? CreatedAt { get; set; }
        public User? Creator { get; set; }
        [JsonProperty("creator_id")]
        public string? CreatorID { get; set; }
        public string? Error { get; set; }
        public string? Name { get; set; }
    }
}
