namespace MondayApi.Schema {
    [GraphQlObjectType("TextValue")]
    public class TextValue : IMirroredValue, IColumnValue {
        public Column Column { get; set; }
        public string ID { get; set; }
        public string Text { get; set; }
        public ColumnType? Type { get; set; }
        public object Value { get; set; }
    }
}
