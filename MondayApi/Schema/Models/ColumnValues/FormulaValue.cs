using Newtonsoft.Json;

namespace MondayApi.Schema {
    [System.Diagnostics.DebuggerDisplay("{Type.ToString(),nq}:{ID}: {DisplayValue}")]
    [GraphQlObjectType("FormulaValue")]
    public class FormulaValue : IMirroredValue, IColumnValue {
        public Column Column { get; set; }
        [JsonProperty("display_value")]
        public string DisplayValue { get; set; }
        public string ID { get; set; }
        public string Text { get; set; }
        public ColumnType? Type { get; set; }
        public object Value { get; set; }
    }
}
