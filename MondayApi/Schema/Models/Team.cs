using System.Collections.Generic;
using Newtonsoft.Json;

namespace MondayApi.Schema {
    public class Team {
        public string ID { get; set; }
        public string Name { get; set; }
        public ICollection<User> Owners { get; set; }
        [JsonProperty("picture_url")]
        public string PictureURL { get; set; }
        public ICollection<User> Users { get; set; }
    }
}
