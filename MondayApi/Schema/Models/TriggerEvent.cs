using System;

namespace MondayApi.Schema {
    public class TriggerEvent {
        public int? AccountID { get; set; }
        public string? TriggerUuid { get; set; }
        public string? EventKind { get; set; }
        public string? EventState { get; set; }
        public decimal? TriggerStarted { get; set; }
        public object? TriggerStartedAt { get; set; }
        public DateTimeOffset? CreatedAt { get; set; }
        public string? ErrorReason { get; set; }
        public int? BillingActionsCount { get; set; }
        public string? WaitingForTriggerName { get; set; }
        public decimal? TriggerDuration { get; set; }
        public string? EntityKind { get; set; }
        public string? ReignitionSubscriptionID { get; set; }
        public string? HostType { get; set; }
        public string? HostInstanceID { get; set; }
        public string? CreatorAppFeatureReferenceID { get; set; }
    }
}
