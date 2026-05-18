using Newtonsoft.Json;

namespace MondayApi.Schema {
    public class StatusLabel {
        public int? ID { get; set; }
        public string? Label { get; set; }
        public StatusColumnColors? Color { get; set; }
        public int? Index { get; set; }
        public string? Description { get; set; }
        [JsonProperty("is_deactivated")]
        public bool? IsDeactivated { get; set; }
        [JsonProperty("is_done")]
        public bool? IsDone { get; set; }
    }
}
