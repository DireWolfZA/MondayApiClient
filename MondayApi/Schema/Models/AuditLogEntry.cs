using System;
using Newtonsoft.Json;

namespace MondayApi.Schema {
    public class AuditLogEntry {
        public DateTimeOffset? Timestamp { get; set; }
        [JsonProperty("account_id")]
        public string? AccountID { get; set; }
        public User? User { get; set; }
        public string? Event { get; set; }
        public string? Slug { get; set; }
        [JsonProperty("ip_address")]
        public string? IPAddress { get; set; }
        [JsonProperty("user_agent")]
        public string? UserAgent { get; set; }
        [JsonProperty("client_name")]
        public string? ClientName { get; set; }
        [JsonProperty("client_version")]
        public string? ClientVersion { get; set; }
        [JsonProperty("os_name")]
        public string? OSName { get; set; }
        [JsonProperty("os_version")]
        public string? OSVersion { get; set; }
        [JsonProperty("device_name")]
        public string? DeviceName { get; set; }
        [JsonProperty("device_type")]
        public string? DeviceType { get; set; }
        [JsonProperty("activity_metadata")]
        public object? ActivityMetadata { get; set; }
    }
}
