namespace MondayApi.Schema {
    public class Widget {
        public string? ID { get; set; }
        public WidgetParentOutput? Parent { get; set; }
        public ExternalWidget? Kind { get; set; }
        public string? Name { get; set; }
    }
}
