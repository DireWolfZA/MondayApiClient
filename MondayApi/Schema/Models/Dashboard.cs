using Newtonsoft.Json;

namespace MondayApi.Schema {
    public class Dashboard {
        public string? ID { get; set; }
        public string? Name { get; set; }
        [JsonProperty("workspace_id")]
        public string? WorkspaceID { get; set; }
        public DashboardKind? Kind { get; set; }
        [JsonProperty("board_folder_id")]
        public string? BoardFolderID { get; set; }
    }
}
