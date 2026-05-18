using System.Collections.Generic;
using Newtonsoft.Json;

namespace MondayApi.Schema {
    public class UnassignDepartmentOwnerResult {
        [JsonProperty("unassigned_users")]
        public ICollection<User>? UnassignedUsers { get; set; }
    }
}
