using System.Collections.Generic;
using Newtonsoft.Json;

namespace MondayApi.Schema {
    public class StatusColumnCapabilitiesInput : IGraphQlInputObject {
        private InputPropertyInfo _calculated;

        [JsonConverter(typeof(QueryBuilderParameterConverter<StatusCalculatedCapabilityInput?>))]
        public QueryBuilderParameter<StatusCalculatedCapabilityInput?>? Calculated {
            get => (QueryBuilderParameter<StatusCalculatedCapabilityInput?>?)_calculated.Value;
            set => _calculated = new InputPropertyInfo { Name = "calculated", Value = value };
        }

        IEnumerable<InputPropertyInfo> IGraphQlInputObject.GetPropertyValues() {
            if (_calculated.Name != null) yield return _calculated;
        }
    }
}
