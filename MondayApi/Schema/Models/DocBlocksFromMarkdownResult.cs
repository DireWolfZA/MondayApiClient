using System.Collections.Generic;
using Newtonsoft.Json;

namespace MondayApi.Schema {
    public class DocBlocksFromMarkdownResult {
        public bool? Success { get; set; }
        [JsonProperty("block_ids")]
        public ICollection<string>? BlockIDs { get; set; }
        public string? Error { get; set; }
    }
}
