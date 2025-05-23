using System.Collections.Generic;
using Newtonsoft.Json;

namespace MondayApi.Schema {
    public class AppSubscriptionDetails {
        [JsonProperty("account_id")]
        public int? AccountID { get; set; }
        [JsonProperty("plan_id")]
        public string? PlanID { get; set; }
        [JsonProperty("pricing_version_id")]
        public int? PricingVersionID { get; set; }
        [JsonProperty("monthly_price")]
        public decimal? MonthlyPrice { get; set; }
        public string? Currency { get; set; }
        [JsonProperty("period_type")]
        public SubscriptionPeriodType? PeriodType { get; set; }
        [JsonProperty("renewal_date")]
        public string? RenewalDate { get; set; }
        [JsonProperty("end_date")]
        public string? EndDate { get; set; }
        public SubscriptionStatus? Status { get; set; }
        public ICollection<SubscriptionDiscount>? Discounts { get; set; }
        [JsonProperty("days_left")]
        public int? DaysLeft { get; set; }
    }
}
