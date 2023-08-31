using Newtonsoft.Json;

namespace MondayApi.Schema {
    public class AppSubscription {
        [JsonProperty("billing_period")]
        public string BillingPeriod { get; set; }
        [JsonProperty("days_left")]
        public int? DaysLeft { get; set; }
        [JsonProperty("is_trial")]
        public bool? IsTrial { get; set; }
        [JsonProperty("plan_id")]
        public string PlanId { get; set; }
        [JsonProperty("renewal_date")]
        public object RenewalDate { get; set; }
    }
}
