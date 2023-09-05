using System.Collections.Generic;
using Newtonsoft.Json;

namespace MondayApi.Schema {
    public class Account {
        [JsonProperty("country_code")]
        public string CountryCode { get; set; }
        [JsonProperty("first_day_of_the_week")]
        public FirstDayOfTheWeek? FirstDayOfTheWeek { get; set; }
        public string ID { get; set; }
        public string Logo { get; set; }
        public string Name { get; set; }
        public Plan Plan { get; set; }
        public ICollection<AccountProduct> Products { get; set; }
        [JsonProperty("show_timeline_weekends")]
        public bool? ShowTimelineWeekends { get; set; }
        [JsonProperty("sign_up_product_kind")]
        public string SignUpProductKind { get; set; }
        public string Slug { get; set; }
        public string Tier { get; set; }
    }
}
