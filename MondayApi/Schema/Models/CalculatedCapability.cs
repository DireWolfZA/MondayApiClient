using Newtonsoft.Json;

namespace MondayApi.Schema {
    public class CalculatedCapability {
        public CalculatedFunction? Function { get; set; }
        [JsonProperty("calculated_type")]
        public ColumnType? CalculatedType { get; set; }
    }
}
