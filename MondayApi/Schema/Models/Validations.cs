using System.Collections.Generic;
using Newtonsoft.Json;

namespace MondayApi.Schema {
    public class Validations {
        [JsonProperty("required_column_ids")]
        public ICollection<string>? RequiredColumnIDs { get; set; }
        public object? Rules { get; set; }
    }
}
