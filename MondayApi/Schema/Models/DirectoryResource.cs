using System.Collections.Generic;
using Newtonsoft.Json;

namespace MondayApi.Schema {
    public class DirectoryResource {
        public string? ID { get; set; }
        public string? Name { get; set; }
        public string? Email { get; set; }
        [JsonProperty("job_role")]
        public string? JobRole { get; set; }
        public ICollection<string>? Skills { get; set; }
        public string? Location { get; set; }
    }
}
