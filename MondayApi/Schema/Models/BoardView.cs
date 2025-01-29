using Newtonsoft.Json;

namespace MondayApi.Schema {
    [System.Diagnostics.DebuggerDisplay("{ID}: {Name}")]
    public class BoardView {
        public string ID { get; set; }
        public string Name { get; set; }
        [JsonProperty("settings_str")]
        public string SettingsStr { get; set; }
        [JsonProperty("source_view_id")]
        public string SourceViewID { get; set; }
        public string Type { get; set; }
        [JsonProperty("view_specific_data_str")]
        public string ViewSpecificDataStr { get; set; }
    }
}
