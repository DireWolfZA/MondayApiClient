using Newtonsoft.Json;

namespace MondayApi.Schema {
    public class OutOfOffice {
        public bool? Active { get; set; }
        [JsonProperty("disable_notifications")]
        public bool? DisableNotifications { get; set; }
        [JsonProperty("end_date")]
        public object EndDate { get; set; }
        [JsonProperty("start_date")]
        public object StartDate { get; set; }
        public string Type { get; set; }
    }
}
