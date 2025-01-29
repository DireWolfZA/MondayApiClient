using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace MondayApi.Schema {
    [System.Diagnostics.DebuggerDisplay("{Type.ToString(),nq}:{ID}: {LinkedItemIDs} {Text}")]
    [GraphQlObjectType("BoardRelationValue")]
    public class BoardRelationValue : IMirroredValue, IColumnValue {
        public Column Column { get; set; }
        [JsonProperty("display_value")]
        public string DisplayValue { get; set; }
        public string ID { get; set; }
        [JsonProperty("linked_item_ids")]
        public ICollection<string> LinkedItemIDs { get; set; }
        [JsonProperty("linked_items")]
        public ICollection<Item> LinkedItems { get; set; }
        public string Text { get; set; }
        public ColumnType? Type { get; set; }
        [JsonProperty("updated_at")]
        public DateTimeOffset? UpdatedAt { get; set; }
        public object Value { get; set; }
    }

    internal class BoardRelationValueForUpdate { // https://developer.monday.com/api-reference/reference/connect#json
        [JsonProperty("item_ids")]
        public ICollection<string> ItemIDs { get; set; }
    }
}
