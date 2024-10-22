using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace MondayApi.Schema {
    public class MarketplaceAppDiscount {
        [JsonProperty("account_slug")]
        public string AccountSlug { get; set; }
        [JsonProperty("account_id")]
        public string AccountID { get; set; }
        public int? Discount { get; set; }
        [JsonProperty("is_recurring")]
        public bool? IsRecurring { get; set; }
        [JsonProperty("app_plan_ids")]
        public ICollection<string> AppPlanIDs { get; set; }
        public DiscountPeriod? Period { get; set; }
        [JsonProperty("valid_until")]
        public string ValidUntil { get; set; }
        [JsonProperty("created_at")]
        public DateTimeOffset? CreatedAt { get; set; }
    }
}
