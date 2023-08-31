using System;
using Newtonsoft.Json;

namespace MondayApi.Schema {
    public class Webhook {
        [JsonProperty("board_id")]
        public int? BoardId { get; set; }
        public string Config { get; set; }
        public WebhookEventType? Event { get; set; }
        public Guid? Id { get; set; }
    }
}
