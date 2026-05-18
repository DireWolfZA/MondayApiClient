using Newtonsoft.Json;

namespace MondayApi.Schema {
    public class PageInfo {
        [JsonProperty("has_next_page")]
        public bool? HasNextPage { get; set; }
        public string? Cursor { get; set; }
    }
}
