using System;
using Newtonsoft.Json;

namespace MondayApi.Schema {
    [System.Diagnostics.DebuggerDisplay("{Type.ToString(),nq}:{ID}: {Text}")]
    [GraphQlObjectType("LocationValue")]
    public class LocationValue : IMirroredValue, IColumnValue {
        public string Address { get; set; }
        public string City { get; set; }
        [JsonProperty("city_short")]
        public string CityShort { get; set; }
        public Column Column { get; set; }
        public string Country { get; set; }
        [JsonProperty("country_short")]
        public string CountryShort { get; set; }
        public string ID { get; set; }
        public decimal? Lat { get; set; }
        public decimal? Lng { get; set; }
        [JsonProperty("place_id")]
        public string PlaceID { get; set; }
        public string Street { get; set; }
        [JsonProperty("street_number")]
        public string StreetNumber { get; set; }
        [JsonProperty("street_number_short")]
        public string StreetNumberShort { get; set; }
        [JsonProperty("street_short")]
        public string StreetShort { get; set; }
        public string Text { get; set; }
        public ColumnType? Type { get; set; }
        [JsonProperty("updated_at")]
        public DateTimeOffset? UpdatedAt { get; set; }
        public object Value { get; set; }
    }
}
