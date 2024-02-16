using System.Collections.Generic;
using Newtonsoft.Json;

namespace MondayApi.Schema {
    [GraphQlObjectType("MirrorValue")]
    public class MirrorValue : IMirroredValue, IColumnValue {
        public Column Column { get; set; }
        [JsonProperty("display_value")]
        public string DisplayValue { get; set; }
        public string ID { get; set; }
        [JsonProperty("mirrored_items")]
        public ICollection<MirroredItem> MirroredItems { get; set; }
        public string Text { get; set; }
        public ColumnType? Type { get; set; }
        public object Value { get; set; }
    }
}
