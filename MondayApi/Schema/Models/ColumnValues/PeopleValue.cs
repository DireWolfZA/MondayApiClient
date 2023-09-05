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
}