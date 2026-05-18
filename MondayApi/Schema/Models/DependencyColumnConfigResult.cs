using System.Collections.Generic;
using Newtonsoft.Json;

namespace MondayApi.Schema {
    public class DependencyColumnConfigResult {
        [JsonProperty("board_id")]
        public string? BoardID { get; set; }
        [JsonProperty("dependency_columns")]
        public ICollection<DependencyColumnConfig>? DependencyColumns { get; set; }
    }
}
