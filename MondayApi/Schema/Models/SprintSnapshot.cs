using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace MondayApi.Schema {
    public class SprintSnapshot {
        public string? ID { get; set; }
        public SprintSnapshotKind? Type { get; set; }
        public ICollection<SprintSnapshotItem>? Items { get; set; }
        [JsonProperty("columns_metadata")]
        public ICollection<SprintSnapshotColumnMetadata>? ColumnsMetadata { get; set; }
        [JsonProperty("sprint_id")]
        public string? SprintID { get; set; }
        [JsonProperty("created_at")]
        public DateTimeOffset? CreatedAt { get; set; }
        [JsonProperty("updated_at")]
        public DateTimeOffset? UpdatedAt { get; set; }
    }
}
