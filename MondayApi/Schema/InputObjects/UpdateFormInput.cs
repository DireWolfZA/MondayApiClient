using System.Collections.Generic;
using Newtonsoft.Json;

namespace MondayApi.Schema {
    public class UpdateFormInput : IGraphQlInputObject {
        private InputPropertyInfo _title;
        private InputPropertyInfo _description;
        private InputPropertyInfo _questions;

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

        [JsonConverter(typeof(QueryBuilderParameterConverter<ICollection<QuestionOrderInput>?>))]
        public QueryBuilderParameter<ICollection<QuestionOrderInput>?>? Questions {
            get => (QueryBuilderParameter<ICollection<QuestionOrderInput>?>?)_questions.Value;
            set => _questions = new InputPropertyInfo { Name = "questions", Value = value };
        }

        IEnumerable<InputPropertyInfo> IGraphQlInputObject.GetPropertyValues() {
            if (_title.Name != null) yield return _title;
            if (_description.Name != null) yield return _description;
            if (_questions.Name != null) yield return _questions;
        }
    }
}
