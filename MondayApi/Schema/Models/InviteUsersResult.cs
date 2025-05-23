using System.Collections.Generic;
using Newtonsoft.Json;

namespace MondayApi.Schema {
    public class InviteUsersResult {
        [JsonProperty("invited_users")]
        public ICollection<User>? InvitedUsers { get; set; }
        public ICollection<InviteUsersError>? Errors { get; set; }
    }
}
