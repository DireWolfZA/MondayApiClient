using Newtonsoft.Json;

namespace MondayApi.Schema {
    public class DiffBlock {
        public string? ID { get; set; }
        public string? Type { get; set; }
        public string? Content { get; set; }
        public string? Summary { get; set; }
        [JsonProperty("parent_block_id")]
        public string? ParentBlockID { get; set; }
        public BlockChanges? Changes { get; set; }
    }
}
