using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace MondayApi.Schema {
    [System.Diagnostics.DebuggerDisplay("{ID}: {Name} G:{Group.ID}")]
    public class Item {
        public string? ID { get; set; }
        public ICollection<Update>? Updates { get; set; }
        public ICollection<Asset?>? Assets { get; set; }
        public Board? Board { get; set; }
        [JsonProperty("column_values")]
        [JsonConverter(typeof(GraphQlInterfaceJsonConverter))]
        public ICollection<IColumnValue>? ColumnValues { get; set; }
        [JsonProperty("created_at")]
        public DateTimeOffset? CreatedAt { get; set; }
        public User? Creator { get; set; }
        [JsonProperty("creator_id")]
        public string? CreatorID { get; set; }
        public ItemDescription? Description { get; set; }
        public string? Email { get; set; }
        public Group? Group { get; set; }
        [JsonProperty("linked_items")]
        public ICollection<Item>? LinkedItems { get; set; }
        public string? Name { get; set; }
        [JsonProperty("parent_item")]
        public Item? ParentItem { get; set; }
        [JsonProperty("relative_link")]
        public string? RelativeLink { get; set; }
        public State? State { get; set; }
        public ICollection<Item?>? Subitems { get; set; }
        public ICollection<User?>? Subscribers { get; set; }
        [JsonProperty("updated_at")]
        public DateTimeOffset? UpdatedAt { get; set; }
        public string? URL { get; set; }
    }
}
