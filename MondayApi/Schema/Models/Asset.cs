using System;
using Newtonsoft.Json;

namespace MondayApi.Schema {
    [System.Diagnostics.DebuggerDisplay("{ID}: {Name}")]
    public class Asset {
        [JsonProperty("created_at")]
        public DateTimeOffset? CreatedAt { get; set; }
        [JsonProperty("file_extension")]
        public string FileExtension { get; set; }
        [JsonProperty("file_size")]
        public int? FileSize { get; set; }
        public string ID { get; set; }
        public string Name { get; set; }
        [JsonProperty("original_geometry")]
        public string OriginalGeometry { get; set; }
        [JsonProperty("public_url")]
        public string PublicURL { get; set; }
        [JsonProperty("uploaded_by")]
        public User UploadedBy { get; set; }
        public string URL { get; set; }
        [JsonProperty("url_thumbnail")]
        public string URLThumbnail { get; set; }
    }
}
