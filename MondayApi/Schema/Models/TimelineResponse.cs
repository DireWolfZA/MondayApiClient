using Newtonsoft.Json;

namespace MondayApi.Schema {
    public class TimelineResponse {
        [JsonProperty("timeline_items_page")]
        public TimelineItemsPage? TimelineItemsPage { get; set; }
    }
}
