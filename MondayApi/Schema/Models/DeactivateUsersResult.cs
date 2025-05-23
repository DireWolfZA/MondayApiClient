using System.Collections.Generic;
using Newtonsoft.Json;

namespace MondayApi.Schema {
    public class DeactivateUsersResult {
        [JsonProperty("deactivated_users")]
        public ICollection<User>? DeactivatedUsers { get; set; }
        public ICollection<DeactivateUsersError>? Errors { get; set; }
    }
}
