using System.Collections.Generic;
using Newtonsoft.Json;

namespace MondayApi.Schema {
    public class UpdateFormSettingsInput : IGraphQlInputObject {
        private InputPropertyInfo _features;
        private InputPropertyInfo _appearance;
        private InputPropertyInfo _accessibility;

        [JsonConverter(typeof(QueryBuilderParameterConverter<FormFeaturesInput?>))]
        public QueryBuilderParameter<FormFeaturesInput?>? Features {
            get => (QueryBuilderParameter<FormFeaturesInput?>?)_features.Value;
            set => _features = new InputPropertyInfo { Name = "features", Value = value };
        }

        [JsonConverter(typeof(QueryBuilderParameterConverter<FormAppearanceInput?>))]
        public QueryBuilderParameter<FormAppearanceInput?>? Appearance {
            get => (QueryBuilderParameter<FormAppearanceInput?>?)_appearance.Value;
            set => _appearance = new InputPropertyInfo { Name = "appearance", Value = value };
        }

        [JsonConverter(typeof(QueryBuilderParameterConverter<FormAccessibilityInput?>))]
        public QueryBuilderParameter<FormAccessibilityInput?>? Accessibility {
            get => (QueryBuilderParameter<FormAccessibilityInput?>?)_accessibility.Value;
            set => _accessibility = new InputPropertyInfo { Name = "accessibility", Value = value };
        }

        IEnumerable<InputPropertyInfo> IGraphQlInputObject.GetPropertyValues() {
            if (_features.Name != null) yield return _features;
            if (_appearance.Name != null) yield return _appearance;
            if (_accessibility.Name != null) yield return _accessibility;
        }
    }
}
