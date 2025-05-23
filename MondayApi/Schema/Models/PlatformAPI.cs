using Newtonsoft.Json;

namespace MondayApi.Schema {
    public class PlatformAPI {
        [JsonProperty("daily_limit")]
        public DailyLimit? DailyLimit { get; set; }
        [JsonProperty("daily_analytics")]
        public DailyAnalytics? DailyAnalytics { get; set; }
    }
}
