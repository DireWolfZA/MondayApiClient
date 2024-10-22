using Newtonsoft.Json;

namespace MondayApi.Schema {
    public class UpdatePin {
        [JsonProperty("item_id")]
        public int? ItemID { get; set; }
    }
}
