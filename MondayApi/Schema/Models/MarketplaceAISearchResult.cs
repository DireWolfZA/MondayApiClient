using System.Collections.Generic;
using Newtonsoft.Json;

namespace MondayApi.Schema {
    public class MarketplaceAISearchResult {
        [JsonProperty("marketplace_app_id")]
        public string? MarketplaceAppID { get; set; }
        public string? Name { get; set; }
        [JsonProperty("match_percentage")]
        public decimal? MatchPercentage { get; set; }
        public ICollection<string>? Features { get; set; }
    }
}
