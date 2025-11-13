using System.Collections.Generic;
using Newtonsoft.Json;

namespace MondayApi.Schema {
    public class SetBoardPermissionResponse {
        [JsonProperty("edit_permissions")]
        public BoardEditPermissions? EditPermissions { get; set; }
        [JsonProperty("failed_actions")]
        public ICollection<string>? FailedActions { get; set; }
    }
}
