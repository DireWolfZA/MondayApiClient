using System.Collections.Generic;
using Newtonsoft.Json;

namespace MondayApi.Schema {
    public class ActivateUsersResult {
        [JsonProperty("activated_users")]
        public ICollection<User>? ActivatedUsers { get; set; }
        public ICollection<ActivateUsersError>? Errors { get; set; }
    }
}
