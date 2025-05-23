using System.Collections.Generic;
using Newtonsoft.Json;

namespace MondayApi.Schema {
    public class UserUpdateInput : IGraphQlInputObject {
        private InputPropertyInfo _userID;
        private InputPropertyInfo _userAttributeUpdates;

        [JsonProperty("user_id")]
        [JsonConverter(typeof(QueryBuilderParameterConverter<string?>))]
        public QueryBuilderParameter<string?>? UserID {
            get => (QueryBuilderParameter<string?>?)_userID.Value;
            set => _userID = new InputPropertyInfo { Name = "user_id", Value = value };
        }

        [JsonProperty("user_attribute_updates")]
        [JsonConverter(typeof(QueryBuilderParameterConverter<UserAttributesInput?>))]
        public QueryBuilderParameter<UserAttributesInput?>? UserAttributeUpdates {
            get => (QueryBuilderParameter<UserAttributesInput?>?)_userAttributeUpdates.Value;
            set => _userAttributeUpdates = new InputPropertyInfo { Name = "user_attribute_updates", Value = value };
        }

        IEnumerable<InputPropertyInfo> IGraphQlInputObject.GetPropertyValues() {
            if (_userID.Name != null) yield return _userID;
            if (_userAttributeUpdates.Name != null) yield return _userAttributeUpdates;
        }
    }
}
