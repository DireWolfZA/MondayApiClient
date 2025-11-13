using System.Collections.Generic;
using Newtonsoft.Json;

namespace MondayApi.Schema {
    public class ObjectDynamicPositionInput : IGraphQlInputObject {
        private InputPropertyInfo _prevObject;
        private InputPropertyInfo _nextObject;

        [JsonConverter(typeof(QueryBuilderParameterConverter<HierarchyObjectIDInputType?>))]
        public QueryBuilderParameter<HierarchyObjectIDInputType?>? PrevObject {
            get => (QueryBuilderParameter<HierarchyObjectIDInputType?>?)_prevObject.Value;
            set => _prevObject = new InputPropertyInfo { Name = "prevObject", Value = value };
        }

        [JsonConverter(typeof(QueryBuilderParameterConverter<HierarchyObjectIDInputType?>))]
        public QueryBuilderParameter<HierarchyObjectIDInputType?>? NextObject {
            get => (QueryBuilderParameter<HierarchyObjectIDInputType?>?)_nextObject.Value;
            set => _nextObject = new InputPropertyInfo { Name = "nextObject", Value = value };
        }

        IEnumerable<InputPropertyInfo> IGraphQlInputObject.GetPropertyValues() {
            if (_prevObject.Name != null) yield return _prevObject;
            if (_nextObject.Name != null) yield return _nextObject;
        }
    }
}
