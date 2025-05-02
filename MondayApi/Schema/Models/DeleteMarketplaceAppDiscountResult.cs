using Newtonsoft.Json;

namespace MondayApi.Schema {
    public class DeleteMarketplaceAppDiscountResult {
        [JsonProperty("deleted_discount")]
        public DeleteMarketplaceAppDiscount? DeletedDiscount { get; set; }
    }
}
