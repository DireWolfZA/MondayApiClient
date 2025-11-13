using System.Collections.Generic;
using Newtonsoft.Json;

namespace MondayApi.Schema {
    [System.Diagnostics.DebuggerDisplay("{ID}: {Name}")]
    public class BoardView {
        public string? ID { get; set; }
        public string? Name { get; set; }
        public string? Type { get; set; }
        [JsonProperty("settings_str")]
        public string? SettingsStr { get; set; }
        [JsonProperty("view_specific_data_str")]
        public string? ViewSpecificDataStr { get; set; }
        [JsonProperty("source_view_id")]
        public string? SourceViewID { get; set; }
        public object? Settings { get; set; }
        public object? Sort { get; set; }
        [JsonProperty("filter_user_id")]
        public int? FilterUserID { get; set; }
        [JsonProperty("filter_team_id")]
        public int? FilterTeamID { get; set; }
        public ICollection<string>? Tags { get; set; }
        public object? Filter { get; set; }
        [JsonProperty("access_level")]
        public BoardViewAccessLevel? AccessLevel { get; set; }
    }
}
