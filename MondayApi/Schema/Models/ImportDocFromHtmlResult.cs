using Newtonsoft.Json;

namespace MondayApi.Schema {
    public class ImportDocFromHtmlResult {
        public bool? Success { get; set; }
        [JsonProperty("doc_id")]
        public string? DocID { get; set; }
        public string? Error { get; set; }
    }
}
