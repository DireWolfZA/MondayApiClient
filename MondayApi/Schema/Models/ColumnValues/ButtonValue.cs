namespace MondayApi.Schema {
    [System.Diagnostics.DebuggerDisplay("{Type.ToString(),nq}:{ID}: {Text}")]
    [GraphQlObjectType("ButtonValue")]
    public class ButtonValue : IMirroredValue, IColumnValue {
        public string Color { get; set; }
        public Column Column { get; set; }
        public string ID { get; set; }
        public string Label { get; set; }
        public string Text { get; set; }
        public ColumnType? Type { get; set; }
        public object Value { get; set; }
    }
}
