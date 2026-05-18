using System.Collections.Generic;
using Newtonsoft.Json;

namespace MondayApi.Schema {
    public class MeetingsResponse {
        public ICollection<Meeting>? Meetings { get; set; }
        [JsonProperty("page_info")]
        public PageInfo? PageInfo { get; set; }
    }
}
