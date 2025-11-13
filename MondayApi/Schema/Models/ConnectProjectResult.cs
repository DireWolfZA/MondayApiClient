using Newtonsoft.Json;

namespace MondayApi.Schema {
    public class ConnectProjectResult {
        public bool? Success { get; set; }
        public string? Message { get; set; }
        [JsonProperty("portfolio_item_id")]
        public string? PortfolioItemID { get; set; }
    }
}
