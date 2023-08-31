using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace MondayApi.Schema {
    public class Update {
        public ICollection<Asset> Assets { get; set; }
        public string Body { get; set; }
        [JsonProperty("created_at")]
        public DateTimeOffset? CreatedAt { get; set; }
        public User Creator { get; set; }
        [JsonProperty("creator_id")]
        public string CreatorID { get; set; }
        public Guid? ID { get; set; }
        [JsonProperty("item_id")]
        public string ItemID { get; set; }
        public ICollection<Reply> Replies { get; set; }
        [JsonProperty("text_body")]
        public string TextBody { get; set; }
        [JsonProperty("updated_at")]
        public DateTimeOffset? UpdatedAt { get; set; }
    }
}
