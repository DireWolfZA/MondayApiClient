namespace MondayApi.Schema {
    [System.Diagnostics.DebuggerDisplay("{Type.ToString(),nq}:{ID}: {Text}")]
    [GraphQlObjectType("DocValue")]
    public class DocValue : AddShallowCopy<IColumnValue>, IMirroredValue, IColumnValue {
        public Column? Column { get; set; }
        public FileDocValue? File { get; set; }
        public string? ID { get; set; }
        public string? Text { get; set; }
        public ColumnType? Type { get; set; }
        public object? Value { get; set; }
    }
}
