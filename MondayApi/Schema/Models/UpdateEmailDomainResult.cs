using System.Collections.Generic;
using Newtonsoft.Json;

namespace MondayApi.Schema {
    public class UpdateEmailDomainResult {
        [JsonProperty("updated_users")]
        public ICollection<User>? UpdatedUsers { get; set; }
        public ICollection<UpdateEmailDomainError>? Errors { get; set; }
    }
}
