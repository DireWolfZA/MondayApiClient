using System.Collections.Generic;
using Newtonsoft.Json;

namespace MondayApi.Schema {
    public class ClearUsersDepartmentResult {
        [JsonProperty("cleared_users")]
        public ICollection<User>? ClearedUsers { get; set; }
    }
}
