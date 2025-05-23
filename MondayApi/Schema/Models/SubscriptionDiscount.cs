using Newtonsoft.Json;

namespace MondayApi.Schema {
    public class SubscriptionDiscount {
        public int? Value { get; set; }
        [JsonProperty("discount_model_type")]
        public SubscriptionDiscountModelType? DiscountModelType { get; set; }
        [JsonProperty("discount_type")]
        public SubscriptionDiscountType? DiscountType { get; set; }
    }
}
