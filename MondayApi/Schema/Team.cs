using System.Collections.Generic;
using Newtonsoft.Json;

namespace MondayApi.Schema {
    public class Team {
        public int? Id { get; set; }
        public string Name { get; set; }
        [JsonProperty("picture_url")]
        public string PictureUrl { get; set; }
        public ICollection<User> Users { get; set; }
    }
}
