using Newtonsoft.Json;

namespace MondayApi.Schema {
    public class CreateAppResponse {
        public string? ID { get; set; }
        [JsonProperty("api_app_id")]
        public string? APIAppID { get; set; }
        [JsonProperty("client_id")]
        public string? ClientID { get; set; }
        [JsonProperty("client_secret")]
        public string? ClientSecret { get; set; }
        [JsonProperty("signing_secret")]
        public string? SigningSecret { get; set; }
    }
}
