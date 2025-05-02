using Newtonsoft.Json;

namespace MondayApi.Schema {
    public class GrantMarketplaceAppDiscountResult {
        [JsonProperty("granted_discount")]
        public GrantMarketplaceAppDiscount? GrantedDiscount { get; set; }
    }
}
