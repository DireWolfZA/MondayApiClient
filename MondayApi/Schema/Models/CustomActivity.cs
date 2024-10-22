using Newtonsoft.Json;

namespace MondayApi.Schema {
    public class CustomActivity {
        public string ID { get; set; }
        public string Type { get; set; }
        public string Name { get; set; }
        [JsonProperty("icon_id")]
        public CustomActivityIcon? IconID { get; set; }
        public CustomActivityColor? Color { get; set; }
    }
}
