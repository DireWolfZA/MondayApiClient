using System.Collections.Generic;
using Newtonsoft.Json;

namespace MondayApi.Schema {
    public class SetFormPasswordInput : IGraphQlInputObject {
        private InputPropertyInfo _password;

        [JsonConverter(typeof(QueryBuilderParameterConverter<string?>))]
        public QueryBuilderParameter<string?>? Password {
            get => (QueryBuilderParameter<string?>?)_password.Value;
            set => _password = new InputPropertyInfo { Name = "password", Value = value };
        }

        IEnumerable<InputPropertyInfo> IGraphQlInputObject.GetPropertyValues() {
            if (_password.Name != null) yield return _password;
        }
    }
}
