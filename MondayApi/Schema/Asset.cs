using System;
using Newtonsoft.Json;

namespace MondayApi.Schema {
    public class Asset {
        [JsonProperty("created_at")]
        public DateTimeOffset? CreatedAt { get; set; }
        [JsonProperty("file_extension")]
        public string FileExtension { get; set; }
        [JsonProperty("file_size")]
        public int? FileSize { get; set; }
        public Guid? Id { get; set; }
        public string Name { get; set; }
        [JsonProperty("original_geometry")]
        public string OriginalGeometry { get; set; }
        [JsonProperty("public_url")]
        public string PublicUrl { get; set; }
        [JsonProperty("uploaded_by")]
        public User UploadedBy { get; set; }
        public string Url { get; set; }
        [JsonProperty("url_thumbnail")]
        public string UrlThumbnail { get; set; }
    }
}
