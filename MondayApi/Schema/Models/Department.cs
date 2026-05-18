using System.Collections.Generic;
using Newtonsoft.Json;

namespace MondayApi.Schema {
    public class Department {
        public string? ID { get; set; }
        public string? Name { get; set; }
        [JsonProperty("reserved_seats")]
        public int? ReservedSeats { get; set; }
        [JsonProperty("assigned_seats")]
        public int? AssignedSeats { get; set; }
        public ICollection<User>? Members { get; set; }
        public ICollection<User>? Owners { get; set; }
    }
}
