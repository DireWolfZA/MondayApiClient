using System.Collections.Generic;
using Newtonsoft.Json;

namespace MondayApi.Schema {
    public class ChangeTeamMembershipsResult {
        [JsonProperty("failed_users")]
        public ICollection<User>? FailedUsers { get; set; }
        [JsonProperty("successful_users")]
        public ICollection<User>? SuccessfulUsers { get; set; }
    }
}
