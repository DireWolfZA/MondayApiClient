using System.Collections.Generic;
using Newtonsoft.Json;

namespace MondayApi.Schema {
    public class LifecycleEventInput : IGraphQlInputObject {
        private InputPropertyInfo _eventType;
        private InputPropertyInfo _webhookURL;
        private InputPropertyInfo _isSync;

        [JsonProperty("event_type")]
        [JsonConverter(typeof(QueryBuilderParameterConverter<string?>))]
        public QueryBuilderParameter<string?>? EventType {
            get => (QueryBuilderParameter<string?>?)_eventType.Value;
            set => _eventType = new InputPropertyInfo { Name = "event_type", Value = value };
        }

        [JsonProperty("webhook_url")]
        [JsonConverter(typeof(QueryBuilderParameterConverter<string?>))]
        public QueryBuilderParameter<string?>? WebhookURL {
            get => (QueryBuilderParameter<string?>?)_webhookURL.Value;
            set => _webhookURL = new InputPropertyInfo { Name = "webhook_url", Value = value };
        }

        [JsonProperty("is_sync")]
        [JsonConverter(typeof(QueryBuilderParameterConverter<bool?>))]
        public QueryBuilderParameter<bool?>? IsSync {
            get => (QueryBuilderParameter<bool?>?)_isSync.Value;
            set => _isSync = new InputPropertyInfo { Name = "is_sync", Value = value };
        }

        IEnumerable<InputPropertyInfo> IGraphQlInputObject.GetPropertyValues() {
            if (_eventType.Name != null) yield return _eventType;
            if (_webhookURL.Name != null) yield return _webhookURL;
            if (_isSync.Name != null) yield return _isSync;
        }
    }
}
