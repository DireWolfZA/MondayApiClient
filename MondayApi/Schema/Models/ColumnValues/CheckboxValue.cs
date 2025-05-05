using System;
using Newtonsoft.Json;

namespace MondayApi.Schema {
    [System.Diagnostics.DebuggerDisplay("{Type.ToString(),nq}:{ID}: Checked: {Checked}")]
    [GraphQlObjectType("CheckboxValue")]
    public class CheckboxValue : IMirroredValue, IColumnValue {
        public bool? Checked { get; set; }
        public Column? Column { get; set; }
        public string? ID { get; set; }
        public string? Text { get; set; }
        public ColumnType? Type { get; set; }
        [JsonProperty("updated_at")]
        public DateTimeOffset? UpdatedAt { get; set; }
        public object? Value { get; set; }
    }

    internal class CheckboxValueForUpdate { // https://developer.monday.com/api-reference/reference/checkbox#json
        public string? Checked { get; set; }
    }
}
