using Newtonsoft.Json;

namespace MondayApi.Schema {
    public class DropdownLabel {
        public int? ID { get; set; }
        public string? Label { get; set; }
        [JsonProperty("is_deactivated")]
        public bool? IsDeactivated { get; set; }
    }
}
