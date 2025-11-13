using Newtonsoft.Json;

namespace MondayApi.Schema {
    public class AuditEventCatalogueEntry {
        public string? Name { get; set; }
        public string? Description { get; set; }
        [JsonProperty("metadata_details")]
        public object? MetadataDetails { get; set; }
    }
}
