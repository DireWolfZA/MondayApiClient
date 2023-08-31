using System;
using Newtonsoft.Json;

namespace MondayApi.Schema {
    public class Webhook {
        [JsonProperty("board_id")]
        public int? BoardID { get; set; }
        public string Config { get; set; }
        public WebhookEventType? Event { get; set; }
        public Guid? ID { get; set; }
    }
}
