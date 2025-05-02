using Newtonsoft.Json;

namespace MondayApi.Schema {
    public class UpdatePin {
        [JsonProperty("item_id")]
        public string? ItemID { get; set; }
    }
}
