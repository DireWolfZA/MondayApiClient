using System.Collections.Generic;
using Newtonsoft.Json;

namespace MondayApi.Schema {
    public class DailyAnalytics {
        [JsonProperty("last_updated")]
        public object? LastUpdated { get; set; }
        [JsonProperty("by_day")]
        public ICollection<PlatformAPIDailyAnalyticsByDay>? ByDay { get; set; }
        [JsonProperty("by_app")]
        public ICollection<PlatformAPIDailyAnalyticsByApp>? ByApp { get; set; }
        [JsonProperty("by_user")]
        public ICollection<PlatformAPIDailyAnalyticsByUser>? ByUser { get; set; }
    }
}
