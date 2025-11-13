using System.Collections.Generic;
using Newtonsoft.Json;

namespace MondayApi.Schema {
    public class UpdateDependencyColumnInput : IGraphQlInputObject {
        private InputPropertyInfo _linkedPulseID;
        private InputPropertyInfo _metadata;

        [JsonConverter(typeof(QueryBuilderParameterConverter<string?>))]
        public QueryBuilderParameter<string?>? LinkedPulseID {
            get => (QueryBuilderParameter<string?>?)_linkedPulseID.Value;
            set => _linkedPulseID = new InputPropertyInfo { Name = "linkedPulseId", Value = value };
        }

        [JsonConverter(typeof(QueryBuilderParameterConverter<MetadataInput?>))]
        public QueryBuilderParameter<MetadataInput?>? Metadata {
            get => (QueryBuilderParameter<MetadataInput?>?)_metadata.Value;
            set => _metadata = new InputPropertyInfo { Name = "metadata", Value = value };
        }

        IEnumerable<InputPropertyInfo> IGraphQlInputObject.GetPropertyValues() {
            if (_linkedPulseID.Name != null) yield return _linkedPulseID;
            if (_metadata.Name != null) yield return _metadata;
        }
    }
}
