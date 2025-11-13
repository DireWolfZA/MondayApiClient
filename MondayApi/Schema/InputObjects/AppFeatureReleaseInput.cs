using System.Collections.Generic;
using Newtonsoft.Json;

namespace MondayApi.Schema {
    public class AppFeatureReleaseInput : IGraphQlInputObject {
        private InputPropertyInfo _kind;
        private InputPropertyInfo _data;

        [JsonConverter(typeof(QueryBuilderParameterConverter<AppFeatureReleaseKind?>))]
        public QueryBuilderParameter<AppFeatureReleaseKind?>? Kind {
            get => (QueryBuilderParameter<AppFeatureReleaseKind?>?)_kind.Value;
            set => _kind = new InputPropertyInfo { Name = "kind", Value = value };
        }

        [JsonConverter(typeof(QueryBuilderParameterConverter<AppFeatureReleaseDataInput?>))]
        public QueryBuilderParameter<AppFeatureReleaseDataInput?>? Data {
            get => (QueryBuilderParameter<AppFeatureReleaseDataInput?>?)_data.Value;
            set => _data = new InputPropertyInfo { Name = "data", Value = value };
        }

        IEnumerable<InputPropertyInfo> IGraphQlInputObject.GetPropertyValues() {
            if (_kind.Name != null) yield return _kind;
            if (_data.Name != null) yield return _data;
        }
    }
}
