using System;
using Newtonsoft.Json;

namespace MondayApi.Schema {
    public class ActivityLogType {
        [JsonProperty("account_id")]
        public string AccountId { get; set; }
        [JsonProperty("created_at")]
        public DateTimeOffset? CreatedAt { get; set; }
        public string Data { get; set; }
        public string Entity { get; set; }
        public string Event { get; set; }
        public string Id { get; set; }
        [JsonProperty("user_id")]
        public string UserId { get; set; }
    }
}
