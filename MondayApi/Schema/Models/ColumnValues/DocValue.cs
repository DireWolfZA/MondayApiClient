namespace MondayApi.Schema {
    [GraphQlObjectType("DocValue")]
    public class DocValue : IColumnValue {
        public Column Column { get; set; }
        public FileDocValue File { get; set; }
        public string ID { get; set; }
        public string Text { get; set; }
        public ColumnType? Type { get; set; }
        public object Value { get; set; }
    }
}
