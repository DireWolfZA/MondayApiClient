using System.Collections.Generic;
using Newtonsoft.Json;

namespace MondayApi.Schema {
    public class Meeting {
        public string? ID { get; set; }
        public string? Title { get; set; }
        [JsonProperty("start_time")]
        public object? StartTime { get; set; }
        [JsonProperty("end_time")]
        public object? EndTime { get; set; }
        [JsonProperty("recording_duration")]
        public int? RecordingDuration { get; set; }
        [JsonProperty("access_type")]
        public MeetingAccess? AccessType { get; set; }
        [JsonProperty("meeting_link")]
        public string? MeetingLink { get; set; }
        public ICollection<Participant>? Participants { get; set; }
        public string? Summary { get; set; }
        public ICollection<Topic>? Topics { get; set; }
        [JsonProperty("action_items")]
        public ICollection<ActionItem>? ActionItems { get; set; }
        public ICollection<TranscriptEntry>? Transcript { get; set; }
    }
}
