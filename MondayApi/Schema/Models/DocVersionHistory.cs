using System.Collections.Generic;
using Newtonsoft.Json;

namespace MondayApi.Schema {
    public class DocVersionHistory {
        [JsonProperty("doc_id")]
        public string? DocID { get; set; }
        [JsonProperty("restoring_points")]
        public ICollection<DocRestoringPoint>? RestoringPoints { get; set; }
    }
}
