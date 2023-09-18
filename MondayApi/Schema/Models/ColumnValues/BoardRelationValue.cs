using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace MondayApi.Schema {
    [GraphQlObjectType("BoardRelationValue")]
    public class BoardRelationValue : IColumnValue {
        public Column Column { get; set; }
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

    [GraphQlObjectType("BoardRelationValue__unused")]
    public class BoardRelationValueForUpdate : BoardRelationValue {
        [JsonProperty("item_ids")] // `long` to workaround bug in current 2023-10 version of API: https://developer.monday.com/api-reference/docs/connect#json - requires non-quoted IDs
        public ICollection<long> ItemIDs { get; set; }
    }
}
