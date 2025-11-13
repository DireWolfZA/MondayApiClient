using System.Collections.Generic;
using Newtonsoft.Json;

namespace MondayApi.Schema {
    public class CreateFavoriteInput : IGraphQlInputObject {
        private InputPropertyInfo _object;
        private InputPropertyInfo _name;
        private InputPropertyInfo _newPosition;

        [JsonConverter(typeof(QueryBuilderParameterConverter<HierarchyObjectIDInputType?>))]
        public QueryBuilderParameter<HierarchyObjectIDInputType?>? Object {
            get => (QueryBuilderParameter<HierarchyObjectIDInputType?>?)_object.Value;
            set => _object = new InputPropertyInfo { Name = "object", Value = value };
        }

        [JsonConverter(typeof(QueryBuilderParameterConverter<string?>))]
        public QueryBuilderParameter<string?>? Name {
            get => (QueryBuilderParameter<string?>?)_name.Value;
            set => _name = new InputPropertyInfo { Name = "name", Value = value };
        }

        [JsonConverter(typeof(QueryBuilderParameterConverter<ObjectDynamicPositionInput?>))]
        public QueryBuilderParameter<ObjectDynamicPositionInput?>? NewPosition {
            get => (QueryBuilderParameter<ObjectDynamicPositionInput?>?)_newPosition.Value;
            set => _newPosition = new InputPropertyInfo { Name = "newPosition", Value = value };
        }

        IEnumerable<InputPropertyInfo> IGraphQlInputObject.GetPropertyValues() {
            if (_object.Name != null) yield return _object;
            if (_name.Name != null) yield return _name;
            if (_newPosition.Name != null) yield return _newPosition;
        }
    }
}
