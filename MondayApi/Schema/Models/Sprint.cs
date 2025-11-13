using System.Collections.Generic;
using Newtonsoft.Json;

namespace MondayApi.Schema {
    public class Sprint {
        public string? ID { get; set; }
        public string? Name { get; set; }
        public ICollection<Item>? Items { get; set; }
        [JsonProperty("start_date")]
        public object? StartDate { get; set; }
        [JsonProperty("end_date")]
        public object? EndDate { get; set; }
        public SprintTimeline? Timeline { get; set; }
        public SprintState? State { get; set; }
        public ICollection<SprintSnapshot>? Snapshots { get; set; }
    }
}
