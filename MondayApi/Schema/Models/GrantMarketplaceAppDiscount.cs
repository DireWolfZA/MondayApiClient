using System.Collections.Generic;
using Newtonsoft.Json;

namespace MondayApi.Schema {
    public class GrantMarketplaceAppDiscount {
        [JsonProperty("days_valid")]
        public int? DaysValid { get; set; }
        public int? Discount { get; set; }
        [JsonProperty("is_recurring")]
        public bool? IsRecurring { get; set; }
        public DiscountPeriod? Period { get; set; }
        [JsonProperty("app_plan_ids")]
        public ICollection<string>? AppPlanIDs { get; set; }
        [JsonProperty("app_id")]
        public string? AppID { get; set; }
    }
}
