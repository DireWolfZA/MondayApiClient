using System;
using Newtonsoft.Json;

namespace MondayApi.Schema {
    [GraphQlObjectType("PhoneValue")]
    public class PhoneValue : IMirroredValue, IColumnValue {
        public Column Column { get; set; }
        [JsonProperty("country_short_name")]
        public string CountryShortName { get; set; }
        public string ID { get; set; }
        public string Phone { get; set; }
        public string Text { get; set; }
        public ColumnType? Type { get; set; }
        [JsonProperty("updated_at")]
        public DateTimeOffset? UpdatedAt { get; set; }
        public object Value { get; set; }
    }

    [GraphQlObjectType("PhoneValue__unused")]
    public class PhoneValueForUpdate : PhoneValue {
        [JsonProperty("countryShortName")] // see https://developer.monday.com/api-reference/docs/phone#json
        public new string CountryShortName { get; set; }
    }
}
