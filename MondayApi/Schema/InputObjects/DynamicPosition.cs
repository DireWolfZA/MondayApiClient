using System.Collections.Generic;
using Newtonsoft.Json;

namespace MondayApi.Schema {
    public class DynamicPosition : IGraphQlInputObject {
        private InputPropertyInfo _isAfter;
        private InputPropertyInfo _objectId;
        private InputPropertyInfo _objectType;

        [JsonProperty("is_after")]
        [JsonConverter(typeof(QueryBuilderParameterConverter<bool?>))]
        public QueryBuilderParameter<bool?>? IsAfter {
            get => (QueryBuilderParameter<bool?>?)_isAfter.Value;
            set => _isAfter = new InputPropertyInfo { Name = "is_after", Value = value };
        }

        [JsonProperty("object_id")]
        [JsonConverter(typeof(QueryBuilderParameterConverter<string?>))]
        public QueryBuilderParameter<string?>? ObjectID {
            get => (QueryBuilderParameter<string?>?)_objectId.Value;
            set => _objectId = new InputPropertyInfo { Name = "object_id", Value = value };
        }

        [JsonProperty("object_type")]
        [JsonConverter(typeof(QueryBuilderParameterConverter<ObjectType?>))]
        public QueryBuilderParameter<ObjectType?>? ObjectType {
            get => (QueryBuilderParameter<ObjectType?>?)_objectType.Value;
            set => _objectType = new InputPropertyInfo { Name = "object_type", Value = value };
        }

        IEnumerable<InputPropertyInfo> IGraphQlInputObject.GetPropertyValues() {
            if (_isAfter.Name != null) yield return _isAfter;
            if (_objectId.Name != null) yield return _objectId;
            if (_objectType.Name != null) yield return _objectType;
        }
    }
}
