using System.Collections.Generic;
using Newtonsoft.Json;

namespace MondayApi.Schema {
    public class GroupBySortSettingsInput : IGraphQlInputObject {
        private InputPropertyInfo _direction;
        private InputPropertyInfo _type;

        [JsonConverter(typeof(QueryBuilderParameterConverter<SortDirection?>))]
        public QueryBuilderParameter<SortDirection?>? Direction {
            get => (QueryBuilderParameter<SortDirection?>?)_direction.Value;
            set => _direction = new InputPropertyInfo { Name = "direction", Value = value };
        }

        [JsonConverter(typeof(QueryBuilderParameterConverter<string?>))]
        public QueryBuilderParameter<string?>? Type {
            get => (QueryBuilderParameter<string?>?)_type.Value;
            set => _type = new InputPropertyInfo { Name = "type", Value = value };
        }

        IEnumerable<InputPropertyInfo> IGraphQlInputObject.GetPropertyValues() {
            if (_direction.Name != null) yield return _direction;
            if (_type.Name != null) yield return _type;
        }
    }
}
