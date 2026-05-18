using Newtonsoft.Json;

namespace MondayApi.Schema {
    public class ActionItem {
        public string? ID { get; set; }
        public string? Content { get; set; }
        [JsonProperty("is_completed")]
        public bool? IsCompleted { get; set; }
        public string? Owner { get; set; }
        [JsonProperty("due_date")]
        public object? DueDate { get; set; }
    }
}
