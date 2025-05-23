using Newtonsoft.Json;

namespace MondayApi.Schema {
    public class ConnectProjectResult {
        [JsonProperty("request_id")]
        public string? RequestID { get; set; }
        public bool? Success { get; set; }
        public string? Message { get; set; }
        [JsonProperty("portfolio_item_id")]
        public string? PortfolioItemID { get; set; }
    }
}
