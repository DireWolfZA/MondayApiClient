using Newtonsoft.Json;

namespace MondayApi.Schema {
    public class UpdateEmailDomainError {
        public string? Message { get; set; }
        public UpdateEmailDomainErrorCode? Code { get; set; }
        [JsonProperty("user_id")]
        public string? UserID { get; set; }
    }
}
