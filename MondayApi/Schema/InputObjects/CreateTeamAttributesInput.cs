using System.Collections.Generic;
using Newtonsoft.Json;

namespace MondayApi.Schema {
    public class CreateTeamAttributesInput : IGraphQlInputObject {
        private InputPropertyInfo _name;
        private InputPropertyInfo _isGuestTeam;
        private InputPropertyInfo _parentTeamID;
        private InputPropertyInfo _subscriberIDs;

        [JsonConverter(typeof(QueryBuilderParameterConverter<string?>))]
        public QueryBuilderParameter<string?>? Name {
            get => (QueryBuilderParameter<string?>?)_name.Value;
            set => _name = new InputPropertyInfo { Name = "name", Value = value };
        }

        [JsonProperty("is_guest_team")]
        [JsonConverter(typeof(QueryBuilderParameterConverter<bool?>))]
        public QueryBuilderParameter<bool?>? IsGuestTeam {
            get => (QueryBuilderParameter<bool?>?)_isGuestTeam.Value;
            set => _isGuestTeam = new InputPropertyInfo { Name = "is_guest_team", Value = value };
        }

        [JsonProperty("parent_team_id")]
        [JsonConverter(typeof(QueryBuilderParameterConverter<string?>))]
        public QueryBuilderParameter<string?>? ParentTeamID {
            get => (QueryBuilderParameter<string?>?)_parentTeamID.Value;
            set => _parentTeamID = new InputPropertyInfo { Name = "parent_team_id", Value = value };
        }

        [JsonProperty("subscriber_ids")]
        [JsonConverter(typeof(QueryBuilderParameterConverter<ICollection<string>?>))]
        public QueryBuilderParameter<ICollection<string>?>? SubscriberIDs {
            get => (QueryBuilderParameter<ICollection<string>?>?)_subscriberIDs.Value;
            set => _subscriberIDs = new InputPropertyInfo { Name = "subscriber_ids", Value = value };
        }

        IEnumerable<InputPropertyInfo> IGraphQlInputObject.GetPropertyValues() {
            if (_name.Name != null) yield return _name;
            if (_isGuestTeam.Name != null) yield return _isGuestTeam;
            if (_parentTeamID.Name != null) yield return _parentTeamID;
            if (_subscriberIDs.Name != null) yield return _subscriberIDs;
        }
    }
}
