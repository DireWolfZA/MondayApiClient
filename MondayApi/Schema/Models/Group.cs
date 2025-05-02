using Newtonsoft.Json;

namespace MondayApi.Schema {
    [System.Diagnostics.DebuggerDisplay("{ID}: {Title}")]
    [GraphQlObjectType("Group")]
    public class Group : IMirroredValue {
        public bool? Archived { get; set; }
        public string? Color { get; set; }
        public bool? Deleted { get; set; }
        public string? ID { get; set; }
        [JsonProperty("items_page")]
        public ItemsResponse? ItemsPage { get; set; }
        public string? Position { get; set; }
        public string? Title { get; set; }
    }
}
