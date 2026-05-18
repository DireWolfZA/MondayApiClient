using System.Collections.Generic;
using Newtonsoft.Json;

namespace MondayApi.Schema {
    public class ToolEventsPage {
        [JsonProperty("tool_events")]
        public ICollection<ToolEvent>? ToolEvents { get; set; }
    }
}
