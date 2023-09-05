using System;
using Newtonsoft.Json;

namespace MondayApi.Schema {
    public class Webhook {
        [JsonProperty("board_id")]
        public string BoardID { get; set; }
        public string Config { get; set; }
        public WebhookEventType? Event { get; set; }
        public string ID { get; set; }
    }
}
