using Newtonsoft.Json;

namespace MondayApi.Schema {
    public class IntegrationExecutionResult {
        [JsonProperty("output_fields")]
        public object? OutputFields { get; set; }
    }
}
