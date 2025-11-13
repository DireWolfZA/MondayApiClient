using Newtonsoft.Json;

namespace MondayApi.Schema {
    public class MarketplaceSearchAppDocument {
        [JsonProperty("marketplace_app_id")]
        public string? MarketplaceAppID { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        [JsonProperty("short_description")]
        public string? ShortDescription { get; set; }
        public string? Keywords { get; set; }
        public MarketplaceAppMetadata? Metadata { get; set; }
    }
}
