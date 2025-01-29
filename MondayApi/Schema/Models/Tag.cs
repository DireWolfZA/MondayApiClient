namespace MondayApi.Schema {
    [System.Diagnostics.DebuggerDisplay("{ID}: {Name}")]
    public class Tag {
        public string Color { get; set; }
        public string ID { get; set; }
        public string Name { get; set; }
    }
}
