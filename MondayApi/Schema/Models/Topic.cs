using System.Collections.Generic;
using Newtonsoft.Json;

namespace MondayApi.Schema {
    public class Topic {
        public string? Title { get; set; }
        [JsonProperty("talking_points")]
        public ICollection<TalkingPoint>? TalkingPoints { get; set; }
    }
}
