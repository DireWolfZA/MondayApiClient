using System.Collections.Generic;
using Newtonsoft.Json;

namespace MondayApi.Schema {
    // this class generated manually as Monday API introspection doesn't include it
    public class ColumnSettings {
        [JsonProperty("hide_footer")]
        public bool? HideFooter { get; set; }
        // subtasks
        public string? DisplayType { get; set; }
        public string? ItemTypeName { get; set; }
        public bool? AllowMultipleItems { get; set; }
        public List<string?>? BoardIDs { get; set; }
        // people
        [JsonProperty("max_people_allowed")]
        public string? MaxPeopleAllowed { get; set; }
        // formula
        public string? Formula { get; set; }
        // button
        public string? ButtonText { get; set; }
        // item ID
        public string? CopyValueSetting { get; set; }
        public object? CustomKeySettings { get; set; }
        // date
        [JsonProperty("show_current_year")]
        public bool? ShowCurrentYear { get; set; }
        [JsonProperty("show_time_by_default")]
        public bool? ShowTimeByDefault { get; set; }
        [JsonProperty("date_format")]
        public string? DateFormat { get; set; }
        // status
        public List<StatusLabel>? Labels { get; set; }
        // numbers
        public NumberUnit? Unit { get; set; }
        public class NumberUnit {
            public string? Symbol { get; set; }
            [JsonProperty("custom_unit")]
            public string? CustomUnit { get; set; }
            public string? Direction { get; set; }
            public int? Precision { get; set; }
        }
        // board relation
        //public bool? AllowMultipleItems { get; set; }
        public bool? AllowCreateReflectionColumn { get; set; }
        //public List<int?>? BoardIDs { get; set; }
        public string? BoardID { get; set; }
        //public string? DisplayType { get; set; }
        public bool? HideOnEmptySearch { get; set; }
        public object? DataSourceLayoutConfigs { get; set; }
        public string? StaticImage { get; set; }
        // mirror
        [JsonProperty("relation_column")]
        public Dictionary<string, bool>? RelationColumn { get; set; }
        [JsonProperty("displayed_column")]
        public object? DisplayedColumn { get; set; }
        [JsonProperty("displayed_linked_columns")]
        public List<DisplayedLinkedColumn>? DisplayedLinkedColumns { get; set; }
        public class DisplayedLinkedColumn {
            [JsonProperty("board_id")]
            public string? BoardID { get; set; }
            [JsonProperty("column_ids")]
            public List<string>? ColumnIDs { get; set; }
        }
    }
}
