using System.Collections.Generic;
using Newtonsoft.Json;

namespace MondayApi.Schema {
    public class AppFeatureReleaseDataInput : IGraphQlInputObject {
        private InputPropertyInfo _url;

        [JsonConverter(typeof(QueryBuilderParameterConverter<string?>))]
        public QueryBuilderParameter<string?>? URL {
            get => (QueryBuilderParameter<string?>?)_url.Value;
            set => _url = new InputPropertyInfo { Name = "url", Value = value };
        }

        IEnumerable<InputPropertyInfo> IGraphQlInputObject.GetPropertyValues() {
            if (_url.Name != null) yield return _url;
        }
    }
}
