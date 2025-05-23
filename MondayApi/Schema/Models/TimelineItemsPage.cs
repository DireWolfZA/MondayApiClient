using System.Collections.Generic;
using Newtonsoft.Json;

namespace MondayApi.Schema {
    public class TimelineItemsPage {
        [JsonProperty("timeline_items")]
        public ICollection<TimelineItem>? TimelineItems { get; set; }
        public string? Cursor { get; set; }
    }
}
