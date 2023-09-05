using System;
using Newtonsoft.Json;

namespace MondayApi.Schema {
    public class TimeTrackingHistoryItem {
        [JsonProperty("created_at")]
        public DateTimeOffset? CreatedAt { get; set; }
        [JsonProperty("ended_at")]
        public object EndedAt { get; set; }
        [JsonProperty("ended_user_id")]
        public string EndedUserID { get; set; }
        public string ID { get; set; }
        [JsonProperty("manually_entered_end_date")]
        public bool? ManuallyEnteredEndDate { get; set; }
        [JsonProperty("manually_entered_end_time")]
        public bool? ManuallyEnteredEndTime { get; set; }
        [JsonProperty("manually_entered_start_date")]
        public bool? ManuallyEnteredStartDate { get; set; }
        [JsonProperty("manually_entered_start_time")]
        public bool? ManuallyEnteredStartTime { get; set; }
        [JsonProperty("started_at")]
        public object StartedAt { get; set; }
        [JsonProperty("started_user_id")]
        public string StartedUserID { get; set; }
        public string Status { get; set; }
        [JsonProperty("updated_at")]
        public DateTimeOffset? UpdatedAt { get; set; }
    }
}
