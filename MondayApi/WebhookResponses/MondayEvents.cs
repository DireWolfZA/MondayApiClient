namespace MondayApi.WebhookResponses {
    public class MondayChallenge {
        public string? Challenge { get; set; }
    }

    public class MondayEventBase : MondayChallenge {
        public EventClassBase? Event { get; set; }
    }

    public class MondayItemCreated : MondayChallenge {
        public EventClassItemCreated? Event { get; set; }
    }
    public class MondayItemNameChanged : MondayChallenge {
        public EventClassItemNameChanged? Event { get; set; }
    }
    public class MondayItemGroupChanged : MondayChallenge {
        public EventClassItemGroupChanged? Event { get; set; }
    }
    public class MondayColumnChanged : MondayChallenge {
        public EventClassColumnChanged? Event { get; set; }
    }
}
