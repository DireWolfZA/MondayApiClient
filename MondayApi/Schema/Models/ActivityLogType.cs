using System;
using Newtonsoft.Json;

namespace MondayApi.Schema {
    public class ActivityLogType {
        [JsonProperty("account_id")]
        public string AccountID { get; set; }
        [JsonProperty("created_at")]
        public DateTimeOffset? CreatedAt { get; set; }
        public string Data { get; set; }
        public string Entity { get; set; }
        public string Event { get; set; }
        public string ID { get; set; }
        [JsonProperty("user_id")]
        public string UserID { get; set; }
    }
}
