using System.Collections.Generic;
using Newtonsoft.Json;

namespace MondayApi.Schema {
    public class UpdateAppFeatureInput : IGraphQlInputObject {
        private InputPropertyInfo _data;
        private InputPropertyInfo _deployment;

        [JsonConverter(typeof(QueryBuilderParameterConverter<object?>))]
        public QueryBuilderParameter<object?>? Data {
            get => (QueryBuilderParameter<object?>?)_data.Value;
            set => _data = new InputPropertyInfo { Name = "data", Value = value };
        }

        [JsonConverter(typeof(QueryBuilderParameterConverter<AppFeatureReleaseInput?>))]
        public QueryBuilderParameter<AppFeatureReleaseInput?>? Deployment {
            get => (QueryBuilderParameter<AppFeatureReleaseInput?>?)_deployment.Value;
            set => _deployment = new InputPropertyInfo { Name = "deployment", Value = value };
        }

        IEnumerable<InputPropertyInfo> IGraphQlInputObject.GetPropertyValues() {
            if (_data.Name != null) yield return _data;
            if (_deployment.Name != null) yield return _deployment;
        }
    }
}
