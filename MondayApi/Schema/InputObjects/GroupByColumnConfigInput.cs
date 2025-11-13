using System.Collections.Generic;
using Newtonsoft.Json;

namespace MondayApi.Schema {
    public class GroupByColumnConfigInput : IGraphQlInputObject {
        private InputPropertyInfo _sortSettings;

        [JsonConverter(typeof(QueryBuilderParameterConverter<GroupBySortSettingsInput?>))]
        public QueryBuilderParameter<GroupBySortSettingsInput?>? SortSettings {
            get => (QueryBuilderParameter<GroupBySortSettingsInput?>?)_sortSettings.Value;
            set => _sortSettings = new InputPropertyInfo { Name = "sortSettings", Value = value };
        }

        IEnumerable<InputPropertyInfo> IGraphQlInputObject.GetPropertyValues() {
            if (_sortSettings.Name != null) yield return _sortSettings;
        }
    }
}
