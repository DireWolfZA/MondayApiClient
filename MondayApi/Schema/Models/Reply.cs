using System;
using Newtonsoft.Json;

namespace MondayApi.Schema {
    public class Reply {
        public string Body { get; set; }
        [JsonProperty("created_at")]
        public DateTimeOffset? CreatedAt { get; set; }
        public User Creator { get; set; }
        [JsonProperty("creator_id")]
        public string CreatorID { get; set; }
        public string ID { get; set; }
        [JsonProperty("text_body")]
        public string TextBody { get; set; }
        [JsonProperty("updated_at")]
        public DateTimeOffset? UpdatedAt { get; set; }
    }
}
