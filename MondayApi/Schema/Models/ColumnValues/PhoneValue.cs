using System;
using Newtonsoft.Json;

namespace MondayApi.Schema {
    [System.Diagnostics.DebuggerDisplay("{Type.ToString(),nq}:{ID}: {CountryShortName}: {Text}")]
    [GraphQlObjectType("PhoneValue")]
    public class PhoneValue : IMirroredValue, IColumnValue {
        public Column? Column { get; set; }
        [JsonProperty("country_short_name")]
        public string? CountryShortName { get; set; }
        public string? ID { get; set; }
        public string? Phone { get; set; }
        public string? Text { get; set; }
        public ColumnType? Type { get; set; }
        [JsonProperty("updated_at")]
        public DateTimeOffset? UpdatedAt { get; set; }
        public object? Value { get; set; }
    }

    internal class PhoneValueForUpdate { // https://developer.monday.com/api-reference/reference/phone#json
        public string? Phone { get; set; }
        [JsonProperty("countryShortName")]
        public string? CountryShortName { get; set; }
    }
}
