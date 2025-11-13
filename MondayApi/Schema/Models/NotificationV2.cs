using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace MondayApi.Schema {
    public class NotificationV2 {
        public string? ID { get; set; }
        [JsonProperty("created_at")]
        public DateTimeOffset? CreatedAt { get; set; }
        public string? Title { get; set; }
        public string? Text { get; set; }
        public ICollection<User>? Creators { get; set; }
        public bool? Read { get; set; }
        public Update? Update { get; set; }
        public Item? Item { get; set; }
        public Board? Board { get; set; }
    }
}
