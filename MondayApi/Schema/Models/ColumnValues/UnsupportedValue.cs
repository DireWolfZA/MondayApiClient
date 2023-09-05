namespace MondayApi.Schema {
    [GraphQlObjectType("UnsupportedValue")]
    public class UnsupportedValue : IColumnValue {
        public Column Column { get; set; }
        public string ID { get; set; }
        public string Text { get; set; }
        public ColumnType? Type { get; set; }
        public object Value { get; set; }
    }
}
