using Newtonsoft.Json;

namespace MondayApi.Schema {
    [System.Diagnostics.DebuggerDisplay("{ID}: {Title} ({Type})")]
    public class Column {
        public bool? Archived { get; set; }
        public string Description { get; set; }
        public string ID { get; set; }
        [JsonProperty("settings_str")]
        public string SettingsStr { get; set; }
        public string Title { get; set; }
        public ColumnType? Type { get; set; }
        public int? Width { get; set; }
    }
}
