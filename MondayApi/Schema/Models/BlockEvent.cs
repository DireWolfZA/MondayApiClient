namespace MondayApi.Schema {
    public class BlockEvent {
        public string? ID { get; set; }
        public int? AccountID { get; set; }
        public int? UserID { get; set; }
        public int? BoardID { get; set; }
        public string? EventKind { get; set; }
        public string? EventState { get; set; }
        public string? TriggerUuid { get; set; }
        public decimal? TriggerStarted { get; set; }
        public object? TriggerStartedAt { get; set; }
        public decimal? BlockStartTimestamp { get; set; }
        public decimal? BlockFinishTimestamp { get; set; }
        public string? AtomicActionID { get; set; }
        public string? Title { get; set; }
        public bool? ConditionSatisfied { get; set; }
        public int? WorkflowNodeID { get; set; }
        public string? EntityKind { get; set; }
        public int? BillingActionCountForBlock { get; set; }
        public string? ErrorReason { get; set; }
    }
}
