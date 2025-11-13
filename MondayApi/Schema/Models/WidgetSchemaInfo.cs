using Newtonsoft.Json;

namespace MondayApi.Schema {
    public class WidgetSchemaInfo {
        [JsonProperty("widget_type")]
        public ExternalWidget? WidgetType { get; set; }
        public object? Schema { get; set; }
    }
}
