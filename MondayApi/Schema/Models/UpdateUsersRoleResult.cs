using System.Collections.Generic;
using Newtonsoft.Json;

namespace MondayApi.Schema {
    public class UpdateUsersRoleResult {
        [JsonProperty("updated_users")]
        public ICollection<User>? UpdatedUsers { get; set; }
        public ICollection<UpdateUsersRoleError>? Errors { get; set; }
    }
}
