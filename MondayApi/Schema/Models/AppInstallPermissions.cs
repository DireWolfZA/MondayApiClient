using System.Collections.Generic;
using Newtonsoft.Json;

namespace MondayApi.Schema {
    public class AppInstallPermissions {
        [JsonProperty("approved_scopes")]
        public ICollection<string>? ApprovedScopes { get; set; }
        [JsonProperty("required_scopes")]
        public ICollection<string>? RequiredScopes { get; set; }
    }
}
