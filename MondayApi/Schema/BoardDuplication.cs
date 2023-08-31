using Newtonsoft.Json;

namespace MondayApi.Schema {
    public class BoardDuplication {
        public Board Board { get; set; }
        [JsonProperty("is_async")]
        public bool? IsAsync { get; set; }
    }
}
