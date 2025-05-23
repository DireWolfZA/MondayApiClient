using Newtonsoft.Json;

namespace MondayApi.Schema {
    public class PlatformAPIDailyAnalyticsByApp {
        public AppType? App { get; set; }
        public int? Usage { get; set; }
        [JsonProperty("api_app_id")]
        public string? APIAppID { get; set; }
    }
}
