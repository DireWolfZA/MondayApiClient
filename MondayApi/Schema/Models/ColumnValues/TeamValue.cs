using System;
using Newtonsoft.Json;

namespace MondayApi.Schema {
    [System.Diagnostics.DebuggerDisplay("{Type.ToString(),nq}:{ID}: {Text}")]
    [GraphQlObjectType("TeamValue"), Obsolete("This column type is deprecated, see https://developer.monday.com/api-reference/reference/team")]
    public class TeamValue : AddShallowCopy<IColumnValue>, IMirroredValue, IColumnValue {
        public Column? Column { get; set; }
        public string? ID { get; set; }
        [JsonProperty("team_id")]
        public int? TeamID { get; set; }
        public string? Text { get; set; }
        public ColumnType? Type { get; set; }
        [JsonProperty("updated_at")]
        public DateTimeOffset? UpdatedAt { get; set; }
        public object? Value { get; set; }
    }
}
