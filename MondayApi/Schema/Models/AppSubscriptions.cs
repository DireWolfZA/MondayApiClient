using System.Collections.Generic;
using Newtonsoft.Json;

namespace MondayApi.Schema {
    public class AppSubscriptions {
        public ICollection<AppSubscriptionDetails>? Subscriptions { get; set; }
        [JsonProperty("total_count")]
        public int? TotalCount { get; set; }
        public string? Cursor { get; set; }
    }
}
