using System.Collections.Generic;
using Newtonsoft.Json;

namespace MondayApi.Schema {
    public class CreateQuestionInput : IGraphQlInputObject {
        private InputPropertyInfo _type;
        private InputPropertyInfo _description;
        private InputPropertyInfo _visible;
        private InputPropertyInfo _required;
        private InputPropertyInfo _settings;
        private InputPropertyInfo _title;
        private InputPropertyInfo _options;

        [JsonConverter(typeof(QueryBuilderParameterConverter<FormQuestionType?>))]
        public QueryBuilderParameter<FormQuestionType?>? Type {
            get => (QueryBuilderParameter<FormQuestionType?>?)_type.Value;
            set => _type = new InputPropertyInfo { Name = "type", Value = value };
        }

        [JsonConverter(typeof(QueryBuilderParameterConverter<string?>))]
        public QueryBuilderParameter<string?>? Description {
            get => (QueryBuilderParameter<string?>?)_description.Value;
            set => _description = new InputPropertyInfo { Name = "description", Value = value };
        }

        [JsonConverter(typeof(QueryBuilderParameterConverter<bool?>))]
        public QueryBuilderParameter<bool?>? Visible {
            get => (QueryBuilderParameter<bool?>?)_visible.Value;
            set => _visible = new InputPropertyInfo { Name = "visible", Value = value };
        }

        [JsonConverter(typeof(QueryBuilderParameterConverter<bool?>))]
        public QueryBuilderParameter<bool?>? Required {
            get => (QueryBuilderParameter<bool?>?)_required.Value;
            set => _required = new InputPropertyInfo { Name = "required", Value = value };
        }

        [JsonConverter(typeof(QueryBuilderParameterConverter<FormQuestionSettingsInput?>))]
        public QueryBuilderParameter<FormQuestionSettingsInput?>? Settings {
            get => (QueryBuilderParameter<FormQuestionSettingsInput?>?)_settings.Value;
            set => _settings = new InputPropertyInfo { Name = "settings", Value = value };
        }

        [JsonConverter(typeof(QueryBuilderParameterConverter<string?>))]
        public QueryBuilderParameter<string?>? Title {
            get => (QueryBuilderParameter<string?>?)_title.Value;
            set => _title = new InputPropertyInfo { Name = "title", Value = value };
        }

        [JsonConverter(typeof(QueryBuilderParameterConverter<ICollection<QuestionOptionInput>?>))]
        public QueryBuilderParameter<ICollection<QuestionOptionInput>?>? Options {
            get => (QueryBuilderParameter<ICollection<QuestionOptionInput>?>?)_options.Value;
            set => _options = new InputPropertyInfo { Name = "options", Value = value };
        }

        IEnumerable<InputPropertyInfo> IGraphQlInputObject.GetPropertyValues() {
            if (_type.Name != null) yield return _type;
            if (_description.Name != null) yield return _description;
            if (_visible.Name != null) yield return _visible;
            if (_required.Name != null) yield return _required;
            if (_settings.Name != null) yield return _settings;
            if (_title.Name != null) yield return _title;
            if (_options.Name != null) yield return _options;
        }
    }
}
