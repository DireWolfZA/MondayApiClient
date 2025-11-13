using System.Collections.Generic;
using Newtonsoft.Json;

namespace MondayApi.Schema {
    public class FormPreSubmissionViewInput : IGraphQlInputObject {
        private InputPropertyInfo _enabled;
        private InputPropertyInfo _title;
        private InputPropertyInfo _description;
        private InputPropertyInfo _startButton;

        [JsonConverter(typeof(QueryBuilderParameterConverter<bool?>))]
        public QueryBuilderParameter<bool?>? Enabled {
            get => (QueryBuilderParameter<bool?>?)_enabled.Value;
            set => _enabled = new InputPropertyInfo { Name = "enabled", Value = value };
        }

        [JsonConverter(typeof(QueryBuilderParameterConverter<string?>))]
        public QueryBuilderParameter<string?>? Title {
            get => (QueryBuilderParameter<string?>?)_title.Value;
            set => _title = new InputPropertyInfo { Name = "title", Value = value };
        }

        [JsonConverter(typeof(QueryBuilderParameterConverter<string?>))]
        public QueryBuilderParameter<string?>? Description {
            get => (QueryBuilderParameter<string?>?)_description.Value;
            set => _description = new InputPropertyInfo { Name = "description", Value = value };
        }

        [JsonConverter(typeof(QueryBuilderParameterConverter<FormStartButtonInput?>))]
        public QueryBuilderParameter<FormStartButtonInput?>? StartButton {
            get => (QueryBuilderParameter<FormStartButtonInput?>?)_startButton.Value;
            set => _startButton = new InputPropertyInfo { Name = "startButton", Value = value };
        }

        IEnumerable<InputPropertyInfo> IGraphQlInputObject.GetPropertyValues() {
            if (_enabled.Name != null) yield return _enabled;
            if (_title.Name != null) yield return _title;
            if (_description.Name != null) yield return _description;
            if (_startButton.Name != null) yield return _startButton;
        }
    }
}
