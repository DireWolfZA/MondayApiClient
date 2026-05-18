using System.Collections.Generic;
using Newtonsoft.Json;

namespace MondayApi.Schema {
    public class EnrollToSequenceResult {
        [JsonProperty("succeeded_item_ids")]
        public ICollection<string>? SucceededItemIDs { get; set; }
        [JsonProperty("failed_item_ids")]
        public ICollection<string>? FailedItemIDs { get; set; }
    }
}
