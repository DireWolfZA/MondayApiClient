using System;
using System.Collections.Generic;

//https://developer.monday.com/api-reference/reference/webhooks#sample-payload-for-webhook-events
namespace MondayApi.WebhookResponses {
    public class EventClassBase {
        public string App { get; set; }
        public string Type { get; set; }
        public DateTimeOffset? TriggerTime { get; set; }
        public long SubscriptionID { get; set; }
        public long UserID { get; set; }
        public string OriginalTriggerUUID { get; set; }
        public long BoardID { get; set; }
        public string GroupID { get; set; }
        /// <summary>Item ID</summary>
        public long PulseID { get; set; }
        public string TriggerUUID { get; set; }
    }

    public class EventClassItemCreated : EventClassBase {
        /// <summary>Item Name</summary>
        public string PulseName { get; set; }
        public string GroupName { get; set; }
        public string GroupColor { get; set; }
        public bool? IsTopGroup { get; set; }
        public Dictionary<string, object> ColumnValues { get; set; }
    }
    public class EventClassItemNameChanged : EventClassBase {
        public ValueWithName Value { get; set; }
        public ValueWithName PreviousValue { get; set; }
        public class ValueWithName {
            public string Name { get; set; }
        }
    }
    public class EventClassItemGroupChanged : EventClassBase {
        public string SourceGroupID { get; set; }
        public string DestGroupID { get; set; }
        public Group DestGroup { get; set; }
        public class Group {
            public string ID { get; set; }
            public string Title { get; set; }
            public string Color { get; set; }
            public bool? IsTopGroup { get; set; }
        }
    }
    public class EventClassColumnChanged : EventClassBase {
        /// <summary>Item Name</summary>
        public string PulseName { get; set; }
        public string ColumnID { get; set; }
        public string ColumnType { get; set; }
        public string ColumnTitle { get; set; }
        public object Value { get; set; }
        public object PreviousValue { get; set; }
        public decimal? ChangedAt { get; set; }
        public bool? IsTopGroup { get; set; }
    }
}
