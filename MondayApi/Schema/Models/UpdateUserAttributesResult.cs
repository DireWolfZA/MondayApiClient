using System.Collections.Generic;
using Newtonsoft.Json;

namespace MondayApi.Schema {
    public class UpdateUserAttributesResult {
        [JsonProperty("updated_users")]
        public ICollection<User>? UpdatedUsers { get; set; }
        public ICollection<UpdateUserAttributesError>? Errors { get; set; }
    }
}
