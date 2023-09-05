namespace MondayApi.Schema {
    [GraphQlObjectType("NumbersValue")]
    public class NumbersValue : IColumnValue {
        public Column Column { get; set; }
        public string ID { get; set; }
        public decimal? Number { get; set; }
        public string Text { get; set; }
        public ColumnType? Type { get; set; }
        public object Value { get; set; }
    }
}
