using System.Collections.Generic;
using Newtonsoft.Json;

namespace MondayApi.Schema {
    public class ItemNicknameInput : IGraphQlInputObject {
        private InputPropertyInfo _plural;
        private InputPropertyInfo _presetType;
        private InputPropertyInfo _singular;

        [JsonConverter(typeof(QueryBuilderParameterConverter<string?>))]
        public QueryBuilderParameter<string?>? Plural {
            get => (QueryBuilderParameter<string?>?)_plural.Value;
            set => _plural = new InputPropertyInfo { Name = "plural", Value = value };
        }

        [JsonProperty("preset_type")]
        [JsonConverter(typeof(QueryBuilderParameterConverter<string?>))]
        public QueryBuilderParameter<string?>? PresetType {
            get => (QueryBuilderParameter<string?>?)_presetType.Value;
            set => _presetType = new InputPropertyInfo { Name = "preset_type", Value = value };
        }

        [JsonConverter(typeof(QueryBuilderParameterConverter<string?>))]
        public QueryBuilderParameter<string?>? Singular {
            get => (QueryBuilderParameter<string?>?)_singular.Value;
            set => _singular = new InputPropertyInfo { Name = "singular", Value = value };
        }

        IEnumerable<InputPropertyInfo> IGraphQlInputObject.GetPropertyValues() {
            if (_plural.Name != null) yield return _plural;
            if (_presetType.Name != null) yield return _presetType;
            if (_singular.Name != null) yield return _singular;
        }
    }
}
