using Newtonsoft.Json;

namespace MondayApi.Schema {
    public class MirroredItem {
        [JsonProperty("linked_board")]
        public Board LinkedBoard { get; set; }
        [JsonProperty("linked_board_id")]
        public string LinkedBoardID { get; set; }
        [JsonProperty("linked_item")]
        public Item LinkedItem { get; set; }
        [JsonProperty("mirrored_value")]
        [JsonConverter(typeof(GraphQlInterfaceJsonConverter))]
        public IMirroredValue MirroredValue { get; set; }
    }
}
