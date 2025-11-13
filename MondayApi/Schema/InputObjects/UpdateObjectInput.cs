using System.Collections.Generic;
using Newtonsoft.Json;

namespace MondayApi.Schema {
    public class UpdateObjectInput : IGraphQlInputObject {
        private InputPropertyInfo _name;
        private InputPropertyInfo _description;
        private InputPropertyInfo _privacyKind;

        [JsonConverter(typeof(QueryBuilderParameterConverter<string?>))]
        public QueryBuilderParameter<string?>? Name {
            get => (QueryBuilderParameter<string?>?)_name.Value;
            set => _name = new InputPropertyInfo { Name = "name", Value = value };
        }

        [JsonConverter(typeof(QueryBuilderParameterConverter<string?>))]
        public QueryBuilderParameter<string?>? Description {
            get => (QueryBuilderParameter<string?>?)_description.Value;
            set => _description = new InputPropertyInfo { Name = "description", Value = value };
        }

        [JsonProperty("privacy_kind")]
        [JsonConverter(typeof(QueryBuilderParameterConverter<PrivacyKind?>))]
        public QueryBuilderParameter<PrivacyKind?>? PrivacyKind {
            get => (QueryBuilderParameter<PrivacyKind?>?)_privacyKind.Value;
            set => _privacyKind = new InputPropertyInfo { Name = "privacy_kind", Value = value };
        }

        IEnumerable<InputPropertyInfo> IGraphQlInputObject.GetPropertyValues() {
            if (_name.Name != null) yield return _name;
            if (_description.Name != null) yield return _description;
            if (_privacyKind.Name != null) yield return _privacyKind;
        }
    }
}
