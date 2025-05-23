using Newtonsoft.Json;

namespace MondayApi.Schema {
    public class CustomFieldValue {
        [JsonProperty("custom_field_meta_id")]
        public string? CustomFieldMetaID { get; set; }
        public string? Value { get; set; }
    }
}
