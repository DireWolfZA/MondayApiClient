using System.Collections.Generic;
using Newtonsoft.Json;

namespace MondayApi.Schema {
    public class FormAppearanceInput : IGraphQlInputObject {
        private InputPropertyInfo _hideBranding;
        private InputPropertyInfo _showProgressBar;
        private InputPropertyInfo _primaryColor;
        private InputPropertyInfo _layout;
        private InputPropertyInfo _background;
        private InputPropertyInfo _text;
        private InputPropertyInfo _logo;
        private InputPropertyInfo _submitButton;

        [JsonConverter(typeof(QueryBuilderParameterConverter<bool?>))]
        public QueryBuilderParameter<bool?>? HideBranding {
            get => (QueryBuilderParameter<bool?>?)_hideBranding.Value;
            set => _hideBranding = new InputPropertyInfo { Name = "hideBranding", Value = value };
        }

        [JsonConverter(typeof(QueryBuilderParameterConverter<bool?>))]
        public QueryBuilderParameter<bool?>? ShowProgressBar {
            get => (QueryBuilderParameter<bool?>?)_showProgressBar.Value;
            set => _showProgressBar = new InputPropertyInfo { Name = "showProgressBar", Value = value };
        }

        [JsonConverter(typeof(QueryBuilderParameterConverter<string?>))]
        public QueryBuilderParameter<string?>? PrimaryColor {
            get => (QueryBuilderParameter<string?>?)_primaryColor.Value;
            set => _primaryColor = new InputPropertyInfo { Name = "primaryColor", Value = value };
        }

        [JsonConverter(typeof(QueryBuilderParameterConverter<FormLayoutInput?>))]
        public QueryBuilderParameter<FormLayoutInput?>? Layout {
            get => (QueryBuilderParameter<FormLayoutInput?>?)_layout.Value;
            set => _layout = new InputPropertyInfo { Name = "layout", Value = value };
        }

        [JsonConverter(typeof(QueryBuilderParameterConverter<FormBackgroundInput?>))]
        public QueryBuilderParameter<FormBackgroundInput?>? Background {
            get => (QueryBuilderParameter<FormBackgroundInput?>?)_background.Value;
            set => _background = new InputPropertyInfo { Name = "background", Value = value };
        }

        [JsonConverter(typeof(QueryBuilderParameterConverter<FormTextInput?>))]
        public QueryBuilderParameter<FormTextInput?>? Text {
            get => (QueryBuilderParameter<FormTextInput?>?)_text.Value;
            set => _text = new InputPropertyInfo { Name = "text", Value = value };
        }

        [JsonConverter(typeof(QueryBuilderParameterConverter<FormLogoInput?>))]
        public QueryBuilderParameter<FormLogoInput?>? Logo {
            get => (QueryBuilderParameter<FormLogoInput?>?)_logo.Value;
            set => _logo = new InputPropertyInfo { Name = "logo", Value = value };
        }

        [JsonConverter(typeof(QueryBuilderParameterConverter<FormSubmitButtonInput?>))]
        public QueryBuilderParameter<FormSubmitButtonInput?>? SubmitButton {
            get => (QueryBuilderParameter<FormSubmitButtonInput?>?)_submitButton.Value;
            set => _submitButton = new InputPropertyInfo { Name = "submitButton", Value = value };
        }

        IEnumerable<InputPropertyInfo> IGraphQlInputObject.GetPropertyValues() {
            if (_hideBranding.Name != null) yield return _hideBranding;
            if (_showProgressBar.Name != null) yield return _showProgressBar;
            if (_primaryColor.Name != null) yield return _primaryColor;
            if (_layout.Name != null) yield return _layout;
            if (_background.Name != null) yield return _background;
            if (_text.Name != null) yield return _text;
            if (_logo.Name != null) yield return _logo;
            if (_submitButton.Name != null) yield return _submitButton;
        }
    }
}
