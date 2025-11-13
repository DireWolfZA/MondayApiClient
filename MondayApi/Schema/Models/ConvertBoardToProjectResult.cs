using Newtonsoft.Json;

namespace MondayApi.Schema {
    public class ConvertBoardToProjectResult {
        public bool? Success { get; set; }
        public string? Message { get; set; }
        public string? ProjectID { get; set; }
        [JsonProperty("process_id")]
        public string? ProcessID { get; set; }
    }
}
