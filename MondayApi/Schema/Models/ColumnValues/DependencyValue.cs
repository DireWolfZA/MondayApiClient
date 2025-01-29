using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace MondayApi.Schema {
    [System.Diagnostics.DebuggerDisplay("{Type.ToString(),nq}:{ID}: {Text}")]
    [GraphQlObjectType("DependencyValue")]
    public class DependencyValue : IMirroredValue, IColumnValue {
        public Column Column { get; set; }
        [JsonProperty("display_value")]
        public string DisplayValue { get; set; }
        public string ID { get; set; }
        [JsonProperty("linked_item_ids")]
        public string LinkedItemIDs { get; set; }
        [JsonProperty("linked_items")]
        public ICollection<Item> LinkedItems { get; set; }
        public string Text { get; set; }
        public ColumnType? Type { get; set; }
        [JsonProperty("updated_at")]
        public DateTimeOffset? UpdatedAt { get; set; }
        public object Value { get; set; }
    }
}
