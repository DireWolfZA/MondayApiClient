using Newtonsoft.Json;

namespace MondayApi.Schema {
    public class AggregateResultEntry {
        public string? Alias { get; set; }
        [JsonConverter(typeof(GraphQlInterfaceJsonConverter))]
        public IAggregateResult? Value { get; set; }
    }
}
