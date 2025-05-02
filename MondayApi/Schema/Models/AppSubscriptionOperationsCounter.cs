using Newtonsoft.Json;

namespace MondayApi.Schema {
    public class AppSubscriptionOperationsCounter {
        [JsonProperty("app_subscription")]
        public AppSubscription? AppSubscription { get; set; }
        [JsonProperty("counter_value")]
        public int? CounterValue { get; set; }
        public string? Kind { get; set; }
        [JsonProperty("period_key")]
        public string? PeriodKey { get; set; }
    }
}
