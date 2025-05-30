using Newtonsoft.Json;

namespace MondayApi.Schema {
    public class AppSubscription {
        [JsonProperty("billing_period")]
        public string? BillingPeriod { get; set; }
        [JsonProperty("days_left")]
        public int? DaysLeft { get; set; }
        [JsonProperty("is_trial")]
        public bool? IsTrial { get; set; }
        [JsonProperty("max_units")]
        public int? MaxUnits { get; set; }
        [JsonProperty("plan_id")]
        public string? PlanID { get; set; }
        [JsonProperty("pricing_version")]
        public int? PricingVersion { get; set; }
        [JsonProperty("renewal_date")]
        public object? RenewalDate { get; set; }
    }
}
