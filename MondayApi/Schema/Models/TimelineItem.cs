using Newtonsoft.Json;

namespace MondayApi.Schema {
    public class TimelineItem {
        public string ID { get; set; }
        public string Type { get; set; }
        public Item Item { get; set; }
        public Board Board { get; set; }
        public User User { get; set; }
        public string Title { get; set; }
        [JsonProperty("custom_activity_id")]
        public string CustomActivityID { get; set; }
    }
}