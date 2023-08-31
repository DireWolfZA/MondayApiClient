using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace MondayApi.Schema {
    public class Item {
        public ICollection<Asset> Assets { get; set; }
        public Board Board { get; set; }
        [JsonProperty("column_values")]
        public ICollection<ColumnValue> ColumnValues { get; set; }
        [JsonProperty("created_at")]
        public DateTimeOffset? CreatedAt { get; set; }
        public User Creator { get; set; }
        [JsonProperty("creator_id")]
        public string CreatorID { get; set; }
        public string Email { get; set; }
        public Group Group { get; set; }
        public Guid? ID { get; set; }
        public string Name { get; set; }
        [JsonProperty("parent_item")]
        public Item ParentItem { get; set; }
        [JsonProperty("relative_link")]
        public string RelativeLink { get; set; }
        public State? State { get; set; }
        public ICollection<Item> Subitems { get; set; }
        public ICollection<User> Subscribers { get; set; }
        [JsonProperty("updated_at")]
        public DateTimeOffset? UpdatedAt { get; set; }
        public ICollection<Update> Updates { get; set; }
    }
}
