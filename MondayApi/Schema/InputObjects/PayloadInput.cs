using System.Collections.Generic;
using Newtonsoft.Json;

namespace MondayApi.Schema {
    public class PayloadInput : IGraphQlInputObject {
        private InputPropertyInfo _dependencyType;
        private InputPropertyInfo _lag;

        [JsonProperty("dependency_type")]
        [JsonConverter(typeof(QueryBuilderParameterConverter<DependencyRelation?>))]
        public QueryBuilderParameter<DependencyRelation?>? DependencyType {
            get => (QueryBuilderParameter<DependencyRelation?>?)_dependencyType.Value;
            set => _dependencyType = new InputPropertyInfo { Name = "dependency_type", Value = value };
        }

        [JsonConverter(typeof(QueryBuilderParameterConverter<int?>))]
        public QueryBuilderParameter<int?>? Lag {
            get => (QueryBuilderParameter<int?>?)_lag.Value;
            set => _lag = new InputPropertyInfo { Name = "lag", Value = value };
        }

        IEnumerable<InputPropertyInfo> IGraphQlInputObject.GetPropertyValues() {
            if (_dependencyType.Name != null) yield return _dependencyType;
            if (_lag.Name != null) yield return _lag;
        }
    }
}
