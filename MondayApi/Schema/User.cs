using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace MondayApi.Schema {
    public class User {
        public Account Account { get; set; }
        public object Birthday { get; set; }
        [JsonProperty("country_code")]
        public string CountryCode { get; set; }
        [JsonProperty("created_at")]
        public DateTimeOffset? CreatedAt { get; set; }
        [JsonProperty("current_language")]
        public string CurrentLanguage { get; set; }
        public string Email { get; set; }
        public bool? Enabled { get; set; }
        public int? Id { get; set; }
        [JsonProperty("is_admin")]
        public bool? IsAdmin { get; set; }
        [JsonProperty("is_guest")]
        public bool? IsGuest { get; set; }
        [JsonProperty("is_pending")]
        public bool? IsPending { get; set; }
        [JsonProperty("is_verified")]
        public bool? IsVerified { get; set; }
        [JsonProperty("is_view_only")]
        public bool? IsViewOnly { get; set; }
        [JsonProperty("join_date")]
        public object JoinDate { get; set; }
        [JsonProperty("last_activity")]
        public object LastActivity { get; set; }
        public string Location { get; set; }
        [JsonProperty("mobile_phone")]
        public string MobilePhone { get; set; }
        public string Name { get; set; }
        [JsonProperty("out_of_office")]
        public OutOfOffice OutOfOffice { get; set; }
        public string Phone { get; set; }
        [JsonProperty("photo_original")]
        public string PhotoOriginal { get; set; }
        [JsonProperty("photo_small")]
        public string PhotoSmall { get; set; }
        [JsonProperty("photo_thumb")]
        public string PhotoThumb { get; set; }
        [JsonProperty("photo_thumb_small")]
        public string PhotoThumbSmall { get; set; }
        [JsonProperty("photo_tiny")]
        public string PhotoTiny { get; set; }
        [JsonProperty("sign_up_product_kind")]
        public string SignUpProductKind { get; set; }
        public ICollection<Team> Teams { get; set; }
        [JsonProperty("time_zone_identifier")]
        public string TimeZoneIdentifier { get; set; }
        public string Title { get; set; }
        public string Url { get; set; }
        [JsonProperty("utc_hours_diff")]
        public int? UtcHoursDiff { get; set; }
    }
}
