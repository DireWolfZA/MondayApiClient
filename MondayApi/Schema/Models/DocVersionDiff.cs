using System.Collections.Generic;
using Newtonsoft.Json;

namespace MondayApi.Schema {
    public class DocVersionDiff {
        [JsonProperty("doc_id")]
        public string? DocID { get; set; }
        public string? Date { get; set; }
        [JsonProperty("prev_date")]
        public string? PrevDate { get; set; }
        public ICollection<DiffBlock>? Blocks { get; set; }
    }
}
