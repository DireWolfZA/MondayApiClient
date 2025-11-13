using System.Collections.Generic;
using Newtonsoft.Json;

namespace MondayApi.Schema {
    public class SprintSnapshotItem {
        public string? ID { get; set; }
        [JsonProperty("column_values")]
        public ICollection<SprintSnapshotItemColumnValue>? ColumnValues { get; set; }
    }
}
