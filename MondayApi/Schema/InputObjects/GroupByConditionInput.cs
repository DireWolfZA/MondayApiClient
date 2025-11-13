using System.Collections.Generic;
using Newtonsoft.Json;

namespace MondayApi.Schema {
    public class GroupByConditionInput : IGraphQlInputObject {
        private InputPropertyInfo _columnID;
        private InputPropertyInfo _config;

        [JsonConverter(typeof(QueryBuilderParameterConverter<string?>))]
        public QueryBuilderParameter<string?>? ColumnID {
            get => (QueryBuilderParameter<string?>?)_columnID.Value;
            set => _columnID = new InputPropertyInfo { Name = "columnId", Value = value };
        }

        [JsonConverter(typeof(QueryBuilderParameterConverter<GroupByColumnConfigInput?>))]
        public QueryBuilderParameter<GroupByColumnConfigInput?>? Config {
            get => (QueryBuilderParameter<GroupByColumnConfigInput?>?)_config.Value;
            set => _config = new InputPropertyInfo { Name = "config", Value = value };
        }

        IEnumerable<InputPropertyInfo> IGraphQlInputObject.GetPropertyValues() {
            if (_columnID.Name != null) yield return _columnID;
            if (_config.Name != null) yield return _config;
        }
    }
}
