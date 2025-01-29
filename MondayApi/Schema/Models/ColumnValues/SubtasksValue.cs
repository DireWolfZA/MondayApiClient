using System.Collections.Generic;
using Newtonsoft.Json;

namespace MondayApi.Schema {
    [System.Diagnostics.DebuggerDisplay("{Type.ToString(),nq}:{ID}: {Text}")]
    [GraphQlObjectType("SubtasksValue")]
    public class SubtasksValue : IMirroredValue, IColumnValue {
        public Column Column { get; set; }
        [JsonProperty("display_value")]
        public string DisplayValue { get; set; }
        public string ID { get; set; }
        public ICollection<Item> Subitems { get; set; }
        [JsonProperty("subitems_ids")]
        public ICollection<string> SubitemsIDs { get; set; }
        public string Text { get; set; }
        public ColumnType? Type { get; set; }
        public object Value { get; set; }
    }
}
