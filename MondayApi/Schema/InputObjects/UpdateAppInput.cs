using System.Collections.Generic;
using Newtonsoft.Json;

namespace MondayApi.Schema {
    public class UpdateAppInput : IGraphQlInputObject {
        private InputPropertyInfo _name;
        private InputPropertyInfo _kind;
        private InputPropertyInfo _description;
        private InputPropertyInfo _slug;
        private InputPropertyInfo _permissions;
        private InputPropertyInfo _webhookURL;
        private InputPropertyInfo _collaborators;

        [JsonConverter(typeof(QueryBuilderParameterConverter<string?>))]
        public QueryBuilderParameter<string?>? Name {
            get => (QueryBuilderParameter<string?>?)_name.Value;
            set => _name = new InputPropertyInfo { Name = "name", Value = value };
        }

        [JsonConverter(typeof(QueryBuilderParameterConverter<AppKind?>))]
        public QueryBuilderParameter<AppKind?>? Kind {
            get => (QueryBuilderParameter<AppKind?>?)_kind.Value;
            set => _kind = new InputPropertyInfo { Name = "kind", Value = value };
        }

        [JsonConverter(typeof(QueryBuilderParameterConverter<string?>))]
        public QueryBuilderParameter<string?>? Description {
            get => (QueryBuilderParameter<string?>?)_description.Value;
            set => _description = new InputPropertyInfo { Name = "description", Value = value };
        }

        [JsonConverter(typeof(QueryBuilderParameterConverter<string?>))]
        public QueryBuilderParameter<string?>? Slug {
            get => (QueryBuilderParameter<string?>?)_slug.Value;
            set => _slug = new InputPropertyInfo { Name = "slug", Value = value };
        }

        [JsonConverter(typeof(QueryBuilderParameterConverter<ICollection<string>?>))]
        public QueryBuilderParameter<ICollection<string>?>? Permissions {
            get => (QueryBuilderParameter<ICollection<string>?>?)_permissions.Value;
            set => _permissions = new InputPropertyInfo { Name = "permissions", Value = value };
        }

        [JsonProperty("webhook_url")]
        [JsonConverter(typeof(QueryBuilderParameterConverter<string?>))]
        public QueryBuilderParameter<string?>? WebhookURL {
            get => (QueryBuilderParameter<string?>?)_webhookURL.Value;
            set => _webhookURL = new InputPropertyInfo { Name = "webhook_url", Value = value };
        }

        [JsonConverter(typeof(QueryBuilderParameterConverter<ICollection<string>?>))]
        public QueryBuilderParameter<ICollection<string>?>? Collaborators {
            get => (QueryBuilderParameter<ICollection<string>?>?)_collaborators.Value;
            set => _collaborators = new InputPropertyInfo { Name = "collaborators", Value = value };
        }

        IEnumerable<InputPropertyInfo> IGraphQlInputObject.GetPropertyValues() {
            if (_name.Name != null) yield return _name;
            if (_kind.Name != null) yield return _kind;
            if (_description.Name != null) yield return _description;
            if (_slug.Name != null) yield return _slug;
            if (_permissions.Name != null) yield return _permissions;
            if (_webhookURL.Name != null) yield return _webhookURL;
            if (_collaborators.Name != null) yield return _collaborators;
        }
    }
}
