using System.Collections.Generic;
using Newtonsoft.Json;

namespace MondayApi.Schema {
    public class CreateTeamOptionsInput : IGraphQlInputObject {
        private InputPropertyInfo _allowEmptyTeam;

        [JsonProperty("allow_empty_team")]
        [JsonConverter(typeof(QueryBuilderParameterConverter<bool?>))]
        public QueryBuilderParameter<bool?>? AllowEmptyTeam {
            get => (QueryBuilderParameter<bool?>?)_allowEmptyTeam.Value;
            set => _allowEmptyTeam = new InputPropertyInfo { Name = "allow_empty_team", Value = value };
        }

        IEnumerable<InputPropertyInfo> IGraphQlInputObject.GetPropertyValues() {
            if (_allowEmptyTeam.Name != null) yield return _allowEmptyTeam;
        }
    }
}
