using Newtonsoft.Json;

namespace MondayApi.Schema {
    public class Watcher {
        [JsonProperty("user_id")]
        public string? UserID { get; set; }
        public string? Medium { get; set; }
        public User? User { get; set; }
    }
}
