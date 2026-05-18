using System.Collections.Generic;
using Newtonsoft.Json;

namespace MondayApi.Schema {
    public class AccountTriggersByEntityIdFiltersInput : IGraphQlInputObject {
        private InputPropertyInfo _boardID;
        private InputPropertyInfo _automationIDs;
        private InputPropertyInfo _userIDs;

        [JsonProperty("board_id")]
        [JsonConverter(typeof(QueryBuilderParameterConverter<int?>))]
        public QueryBuilderParameter<int?>? BoardID {
            get => (QueryBuilderParameter<int?>?)_boardID.Value;
            set => _boardID = new InputPropertyInfo { Name = "board_id", Value = value };
        }

        [JsonProperty("automation_ids")]
        [JsonConverter(typeof(QueryBuilderParameterConverter<ICollection<int>?>))]
        public QueryBuilderParameter<ICollection<int>?>? AutomationIDs {
            get => (QueryBuilderParameter<ICollection<int>?>?)_automationIDs.Value;
            set => _automationIDs = new InputPropertyInfo { Name = "automation_ids", Value = value };
        }

        [JsonProperty("user_ids")]
        [JsonConverter(typeof(QueryBuilderParameterConverter<ICollection<int>?>))]
        public QueryBuilderParameter<ICollection<int>?>? UserIDs {
            get => (QueryBuilderParameter<ICollection<int>?>?)_userIDs.Value;
            set => _userIDs = new InputPropertyInfo { Name = "user_ids", Value = value };
        }

        IEnumerable<InputPropertyInfo> IGraphQlInputObject.GetPropertyValues() {
            if (_boardID.Name != null) yield return _boardID;
            if (_automationIDs.Name != null) yield return _automationIDs;
            if (_userIDs.Name != null) yield return _userIDs;
        }
    }
}
