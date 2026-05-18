using Newtonsoft.Json;

namespace MondayApi.Schema {
    public class CreateMarketplaceAppDiscountResult {
        [JsonProperty("granted_discount")]
        public CreateMarketplaceAppDiscount? GrantedDiscount { get; set; }
    }
}
