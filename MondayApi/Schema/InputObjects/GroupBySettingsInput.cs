using System.Collections.Generic;
using Newtonsoft.Json;

namespace MondayApi.Schema {
    public class GroupBySettingsInput : IGraphQlInputObject {
        private InputPropertyInfo _conditions;
        private InputPropertyInfo _hideEmptyGroups;

        [JsonConverter(typeof(QueryBuilderParameterConverter<ICollection<GroupByConditionInput>?>))]
        public QueryBuilderParameter<ICollection<GroupByConditionInput>?>? Conditions {
            get => (QueryBuilderParameter<ICollection<GroupByConditionInput>?>?)_conditions.Value;
            set => _conditions = new InputPropertyInfo { Name = "conditions", Value = value };
        }

        [JsonConverter(typeof(QueryBuilderParameterConverter<bool?>))]
        public QueryBuilderParameter<bool?>? HideEmptyGroups {
            get => (QueryBuilderParameter<bool?>?)_hideEmptyGroups.Value;
            set => _hideEmptyGroups = new InputPropertyInfo { Name = "hideEmptyGroups", Value = value };
        }

        IEnumerable<InputPropertyInfo> IGraphQlInputObject.GetPropertyValues() {
            if (_conditions.Name != null) yield return _conditions;
            if (_hideEmptyGroups.Name != null) yield return _hideEmptyGroups;
        }
    }
}
