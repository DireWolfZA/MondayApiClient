using System.Collections.Generic;
using Newtonsoft.Json;

namespace MondayApi.Schema {
    public class RequiredColumns {
        [JsonProperty("required_column_ids")]
        public ICollection<string>? RequiredColumnIDs { get; set; }
    }
}
