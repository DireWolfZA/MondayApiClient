namespace MondayApi.Schema {
    public class BoardGraphExport {
        public string? BoardID { get; set; }
        public object? GraphData { get; set; }
        public string? ExportedAt { get; set; }
        public int? NodeCount { get; set; }
        public int? EdgeCount { get; set; }
    }
}
