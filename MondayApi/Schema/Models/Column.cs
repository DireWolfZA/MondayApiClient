namespace MondayApi.Schema {
    [System.Diagnostics.DebuggerDisplay("{ID}: {Title} ({Type})")]
    public class Column {
        public string? ID { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        public ColumnType? Type { get; set; }
        public int? Width { get; set; }
        public bool? Archived { get; set; }
        public ColumnSettings? Settings { get; set; }
        public string? Revision { get; set; }
        public ColumnCapabilities? Capabilities { get; set; }
    }
}
