using System.Collections.Generic;
using Newtonsoft.Json;

namespace MondayApi.Schema {
    public class AssignDepartmentMembersResult {
        [JsonProperty("successful_users")]
        public ICollection<User>? SuccessfulUsers { get; set; }
        [JsonProperty("failed_users")]
        public ICollection<User>? FailedUsers { get; set; }
    }
}
