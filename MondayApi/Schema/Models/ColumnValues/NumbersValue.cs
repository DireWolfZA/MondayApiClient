namespace MondayApi.Schema {
    [System.Diagnostics.DebuggerDisplay("{Type.ToString(),nq}:{ID}: {Number}")]
    [GraphQlObjectType("NumbersValue")]
    public class NumbersValue : IMirroredValue, IColumnValue {
        public Column Column { get; set; }
        public NumberValueUnitDirection? Direction { get; set; }
        public string ID { get; set; }
        public decimal? Number { get; set; }
        public string Symbol { get; set; }
        public string Text { get; set; }
        public ColumnType? Type { get; set; }
        public object Value { get; set; }
    }
}
