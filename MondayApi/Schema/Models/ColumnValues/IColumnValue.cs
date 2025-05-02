namespace MondayApi.Schema {
    public interface IColumnValue {
        Column? Column { get; set; }
        string? ID { get; set; }
        string? Text { get; set; }
        ColumnType? Type { get; set; }
        object? Value { get; set; }
    }
}
