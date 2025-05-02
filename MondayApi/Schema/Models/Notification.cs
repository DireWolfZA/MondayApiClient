namespace MondayApi.Schema {
    [System.Diagnostics.DebuggerDisplay("{ID}: {Text}")]
    public class Notification {
        public string? ID { get; set; }
        public string? Text { get; set; }
    }
}
