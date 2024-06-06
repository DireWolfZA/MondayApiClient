using Newtonsoft.Json;

namespace MondayApi.Schema {
    public class Template {
        [JsonProperty("process_id")]
        public string ProcessID { get; set; }
    }
}
