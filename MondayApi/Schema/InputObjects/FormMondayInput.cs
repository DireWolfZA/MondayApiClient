using System.Collections.Generic;
using Newtonsoft.Json;

namespace MondayApi.Schema {
    public class FormMondayInput : IGraphQlInputObject {
        private InputPropertyInfo _itemGroupID;
        private InputPropertyInfo _includeNameQuestion;
        private InputPropertyInfo _includeUpdateQuestion;
        private InputPropertyInfo _syncQuestionAndColumnsTitles;

        [JsonConverter(typeof(QueryBuilderParameterConverter<string?>))]
        public QueryBuilderParameter<string?>? ItemGroupID {
            get => (QueryBuilderParameter<string?>?)_itemGroupID.Value;
            set => _itemGroupID = new InputPropertyInfo { Name = "itemGroupId", Value = value };
        }

        [JsonConverter(typeof(QueryBuilderParameterConverter<bool?>))]
        public QueryBuilderParameter<bool?>? IncludeNameQuestion {
            get => (QueryBuilderParameter<bool?>?)_includeNameQuestion.Value;
            set => _includeNameQuestion = new InputPropertyInfo { Name = "includeNameQuestion", Value = value };
        }

        [JsonConverter(typeof(QueryBuilderParameterConverter<bool?>))]
        public QueryBuilderParameter<bool?>? IncludeUpdateQuestion {
            get => (QueryBuilderParameter<bool?>?)_includeUpdateQuestion.Value;
            set => _includeUpdateQuestion = new InputPropertyInfo { Name = "includeUpdateQuestion", Value = value };
        }

        [JsonConverter(typeof(QueryBuilderParameterConverter<bool?>))]
        public QueryBuilderParameter<bool?>? SyncQuestionAndColumnsTitles {
            get => (QueryBuilderParameter<bool?>?)_syncQuestionAndColumnsTitles.Value;
            set => _syncQuestionAndColumnsTitles = new InputPropertyInfo { Name = "syncQuestionAndColumnsTitles", Value = value };
        }

        IEnumerable<InputPropertyInfo> IGraphQlInputObject.GetPropertyValues() {
            if (_itemGroupID.Name != null) yield return _itemGroupID;
            if (_includeNameQuestion.Name != null) yield return _includeNameQuestion;
            if (_includeUpdateQuestion.Name != null) yield return _includeUpdateQuestion;
            if (_syncQuestionAndColumnsTitles.Name != null) yield return _syncQuestionAndColumnsTitles;
        }
    }
}
