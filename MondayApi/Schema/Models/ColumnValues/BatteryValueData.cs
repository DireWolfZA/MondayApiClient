using System.Collections.Generic;
using Newtonsoft.Json;

namespace MondayApi.Schema {
    [System.Diagnostics.DebuggerDisplay("{Type.ToString(),nq}:{ID}: {Text}")]
    [GraphQlObjectType("BatteryValue")]
    public class BatteryValueData : IMirroredValue, IColumnValue {
        [JsonProperty("battery_value")]
        public ICollection<BatteryValueItem>? BatteryValue { get; set; }
        public Column? Column { get; set; }
        public string? ID { get; set; }
        public string? Text { get; set; }
        public ColumnType? Type { get; set; }
        public object? Value { get; set; }
    }
}
