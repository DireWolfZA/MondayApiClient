using System.Collections.Generic;
using Newtonsoft.Json;

namespace MondayApi.Schema {
    public class WorkspacesQueryInput : IGraphQlInputObject {
        private InputPropertyInfo _accountProductKind;

        [JsonProperty("account_product_kind")]
        [JsonConverter(typeof(QueryBuilderParameterConverter<WorkspacesQueryAccountProductKind?>))]
        public QueryBuilderParameter<WorkspacesQueryAccountProductKind?>? AccountProductKind {
            get => (QueryBuilderParameter<WorkspacesQueryAccountProductKind?>?)_accountProductKind.Value;
            set => _accountProductKind = new InputPropertyInfo { Name = "account_product_kind", Value = value };
        }

        IEnumerable<InputPropertyInfo> IGraphQlInputObject.GetPropertyValues() {
            if (_accountProductKind.Name != null) yield return _accountProductKind;
        }
    }
}
