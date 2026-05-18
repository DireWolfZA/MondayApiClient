using System.Collections.Generic;
using Newtonsoft.Json;

namespace MondayApi.Schema {
    public class UpdateLifecycleSubscriptionsInput : IGraphQlInputObject {
        private InputPropertyInfo _lifecycleEvents;

        [JsonProperty("lifecycle_events")]
        [JsonConverter(typeof(QueryBuilderParameterConverter<ICollection<LifecycleEventInput>?>))]
        public QueryBuilderParameter<ICollection<LifecycleEventInput>?>? LifecycleEvents {
            get => (QueryBuilderParameter<ICollection<LifecycleEventInput>?>?)_lifecycleEvents.Value;
            set => _lifecycleEvents = new InputPropertyInfo { Name = "lifecycle_events", Value = value };
        }

        IEnumerable<InputPropertyInfo> IGraphQlInputObject.GetPropertyValues() {
            if (_lifecycleEvents.Name != null) yield return _lifecycleEvents;
        }
    }
}
