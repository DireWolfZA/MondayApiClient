using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace MondayApi.Schema {
    [GraphQlObjectType("VoteValue")]
    public class VoteValue : IMirroredValue, IColumnValue {
        public Column Column { get; set; }
        public string ID { get; set; }
        public string Text { get; set; }
        public ColumnType? Type { get; set; }
        [JsonProperty("updated_at")]
        public DateTimeOffset? UpdatedAt { get; set; }
        public object Value { get; set; }
        [JsonProperty("vote_count")]
        public int? VoteCount { get; set; }
        [JsonProperty("voter_ids")]
        public ICollection<string> VoterIDs { get; set; }
        public ICollection<User> Voters { get; set; }
    }
}
