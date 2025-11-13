using System.Collections.Generic;
using Newtonsoft.Json;

namespace MondayApi.Schema {
    public class FormRedirectAfterSubmissionInput : IGraphQlInputObject {
        private InputPropertyInfo _enabled;
        private InputPropertyInfo _redirectURL;

        [JsonConverter(typeof(QueryBuilderParameterConverter<bool?>))]
        public QueryBuilderParameter<bool?>? Enabled {
            get => (QueryBuilderParameter<bool?>?)_enabled.Value;
            set => _enabled = new InputPropertyInfo { Name = "enabled", Value = value };
        }

        [JsonConverter(typeof(QueryBuilderParameterConverter<string?>))]
        public QueryBuilderParameter<string?>? RedirectURL {
            get => (QueryBuilderParameter<string?>?)_redirectURL.Value;
            set => _redirectURL = new InputPropertyInfo { Name = "redirectUrl", Value = value };
        }

        IEnumerable<InputPropertyInfo> IGraphQlInputObject.GetPropertyValues() {
            if (_enabled.Name != null) yield return _enabled;
            if (_redirectURL.Name != null) yield return _redirectURL;
        }
    }
}
