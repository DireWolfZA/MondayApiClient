using Newtonsoft.Json;

namespace MondayApi.Schema {
    public class TranscriptEntry {
        public string? Text { get; set; }
        [JsonProperty("start_time")]
        public decimal? StartTime { get; set; }
        [JsonProperty("end_time")]
        public decimal? EndTime { get; set; }
        public string? Speaker { get; set; }
        public string? Language { get; set; }
    }
}
