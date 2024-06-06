using Newtonsoft.Json;

namespace MondayApi.Schema {
    public class AccountProduct {
        [JsonProperty("default_workspace_id")]
        public string DefaultWorkspaceID { get; set; }
        public string ID { get; set; }
        public string Kind { get; set; }
    }
}
