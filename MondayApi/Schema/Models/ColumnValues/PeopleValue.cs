using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace MondayApi.Schema {
    [GraphQlObjectType("PeopleValue")]
    public class PeopleValue : IColumnValue {
        public Column Column { get; set; }
        public string ID { get; set; }
        [JsonProperty("persons_and_teams")]
        public ICollection<PeopleEntity> PersonsAndTeams { get; set; }
        public string Text { get; set; }
        public ColumnType? Type { get; set; }
        [JsonProperty("updated_at")]
        public DateTimeOffset? UpdatedAt { get; set; }
        public object Value { get; set; }
    }

    internal class PeopleValueForUpdate {
        [JsonProperty("personsAndTeams")] // see https://developer.monday.com/api-reference/docs/people#json
        public ICollection<PeopleEntityForUpdate> PersonsAndTeams { get; set; }
    }
    internal class PeopleEntityForUpdate {
        public string ID { get; set; }
        public string Kind { get; set; }
    }
}
