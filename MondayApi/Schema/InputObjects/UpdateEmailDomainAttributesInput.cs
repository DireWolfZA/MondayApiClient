using System.Collections.Generic;
using Newtonsoft.Json;

namespace MondayApi.Schema {
    public class UpdateEmailDomainAttributesInput : IGraphQlInputObject {
        private InputPropertyInfo _userIDs;
        private InputPropertyInfo _newDomain;

        [JsonProperty("user_ids")]
        [JsonConverter(typeof(QueryBuilderParameterConverter<ICollection<string>?>))]
        public QueryBuilderParameter<ICollection<string>?>? UserIDs {
            get => (QueryBuilderParameter<ICollection<string>?>?)_userIDs.Value;
            set => _userIDs = new InputPropertyInfo { Name = "user_ids", Value = value };
        }

        [JsonProperty("new_domain")]
        [JsonConverter(typeof(QueryBuilderParameterConverter<string?>))]
        public QueryBuilderParameter<string?>? NewDomain {
            get => (QueryBuilderParameter<string?>?)_newDomain.Value;
            set => _newDomain = new InputPropertyInfo { Name = "new_domain", Value = value };
        }

        IEnumerable<InputPropertyInfo> IGraphQlInputObject.GetPropertyValues() {
            if (_userIDs.Name != null) yield return _userIDs;
            if (_newDomain.Name != null) yield return _newDomain;
        }
    }
}
