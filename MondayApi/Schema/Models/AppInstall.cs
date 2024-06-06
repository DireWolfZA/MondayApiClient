using System;
using Newtonsoft.Json;

namespace MondayApi.Schema {
    public class AppInstall {
        [JsonProperty("app_id")]
        public string AppID { get; set; }
        [JsonProperty("app_install_account")]
        public AppInstallAccount AppInstallAccount { get; set; }
        [JsonProperty("app_install_user")]
        public AppInstallUser AppInstallUser { get; set; }
        [JsonProperty("app_version")]
        public AppVersion AppVersion { get; set; }
        public AppInstallPermissions Permissions { get; set; }
        public DateTimeOffset? Timestamp { get; set; }
    }
}
