using System.Collections.Generic;
using Newtonsoft.Json;

namespace MondayApi.Schema {
    public class SprintSnapshotColumnMetadata {
        public string? ID { get; set; }
        [JsonProperty("done_status_indexes")]
        public ICollection<int>? DoneStatusIndexes { get; set; }
    }
}
