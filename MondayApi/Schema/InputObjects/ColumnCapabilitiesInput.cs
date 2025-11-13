using System.Collections.Generic;
using Newtonsoft.Json;

namespace MondayApi.Schema {
    public class ColumnCapabilitiesInput : IGraphQlInputObject {
        private InputPropertyInfo _calculated;

        [JsonConverter(typeof(QueryBuilderParameterConverter<CalculatedCapabilityInput?>))]
        public QueryBuilderParameter<CalculatedCapabilityInput?>? Calculated {
            get => (QueryBuilderParameter<CalculatedCapabilityInput?>?)_calculated.Value;
            set => _calculated = new InputPropertyInfo { Name = "calculated", Value = value };
        }

        IEnumerable<InputPropertyInfo> IGraphQlInputObject.GetPropertyValues() {
            if (_calculated.Name != null) yield return _calculated;
        }
    }
}
