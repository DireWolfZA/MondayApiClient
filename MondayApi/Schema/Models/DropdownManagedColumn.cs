using System;
using Newtonsoft.Json;

namespace MondayApi.Schema {
    public class DropdownManagedColumn {
        public string? ID { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        [JsonProperty("settings_json")]
        public object? SettingsJson { get; set; }
        [JsonProperty("created_by")]
        public string? CreatedBy { get; set; }
        [JsonProperty("updated_by")]
        public string? UpdatedBy { get; set; }
        public int? Revision { get; set; }
        public ManagedColumnState? State { get; set; }
        [JsonProperty("created_at")]
        public DateTimeOffset? CreatedAt { get; set; }
        [JsonProperty("updated_at")]
        public DateTimeOffset? UpdatedAt { get; set; }
        public DropdownColumnSettings? Settings { get; set; }
    }
}
