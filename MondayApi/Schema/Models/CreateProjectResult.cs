using Newtonsoft.Json;

namespace MondayApi.Schema {
    public class CreateProjectResult {
        public bool? Success { get; set; }
        public string? Message { get; set; }
        public string? Error { get; set; }
        [JsonProperty("process_id")]
        public string? ProcessID { get; set; }
    }
}
