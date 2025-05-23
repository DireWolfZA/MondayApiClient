using Newtonsoft.Json;

namespace MondayApi.Schema {
    public class UpdateUserAttributesError {
        public string? Message { get; set; }
        public UpdateUserAttributesErrorCode? Code { get; set; }
        [JsonProperty("user_id")]
        public string? UserID { get; set; }
    }
}
