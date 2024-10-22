using Newtonsoft.Json;

namespace MondayApi.Schema {
    public class DeleteMarketplaceAppDiscount {
        [JsonProperty("account_slug")]
        public string AccountSlug { get; set; }
        [JsonProperty("app_id")]
        public string AppID { get; set; }
    }
}
