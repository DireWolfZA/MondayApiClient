using Newtonsoft.Json;

namespace MondayApi.Schema {
    public class CustomFieldMetas {
        public string? Description { get; set; }
        public bool? Editable { get; set; }
        [JsonProperty("field_type")]
        public string? FieldType { get; set; }
        public bool? Flagged { get; set; }
        public string? Icon { get; set; }
        public string? ID { get; set; }
        public string? Position { get; set; }
        public string? Title { get; set; }
    }
}
