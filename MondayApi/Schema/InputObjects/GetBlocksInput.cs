using System.Collections.Generic;
using Newtonsoft.Json;

namespace MondayApi.Schema {
    public class GetBlocksInput : IGraphQlInputObject {
        private InputPropertyInfo _appFeatureReferenceIDs;
        private InputPropertyInfo _contexts;

        [JsonConverter(typeof(QueryBuilderParameterConverter<ICollection<int>?>))]
        public QueryBuilderParameter<ICollection<int>?>? AppFeatureReferenceIds {
            get => (QueryBuilderParameter<ICollection<int>?>?)_appFeatureReferenceIDs.Value;
            set => _appFeatureReferenceIDs = new InputPropertyInfo { Name = "appFeatureReferenceIds", Value = value };
        }

        [JsonConverter(typeof(QueryBuilderParameterConverter<ICollection<string>?>))]
        public QueryBuilderParameter<ICollection<string>?>? Contexts {
            get => (QueryBuilderParameter<ICollection<string>?>?)_contexts.Value;
            set => _contexts = new InputPropertyInfo { Name = "contexts", Value = value };
        }

        IEnumerable<InputPropertyInfo> IGraphQlInputObject.GetPropertyValues() {
            if (_appFeatureReferenceIDs.Name != null) yield return _appFeatureReferenceIDs;
            if (_contexts.Name != null) yield return _contexts;
        }
    }
}
