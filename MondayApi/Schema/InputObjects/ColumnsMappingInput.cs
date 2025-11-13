using System.Collections.Generic;
using Newtonsoft.Json;

namespace MondayApi.Schema {
    public class ColumnsMappingInput : IGraphQlInputObject {
        private InputPropertyInfo _projectStatus;
        private InputPropertyInfo _projectTimeline;
        private InputPropertyInfo _projectOwner;

        [JsonProperty("project_status")]
        [JsonConverter(typeof(QueryBuilderParameterConverter<string?>))]
        public QueryBuilderParameter<string?>? ProjectStatus {
            get => (QueryBuilderParameter<string?>?)_projectStatus.Value;
            set => _projectStatus = new InputPropertyInfo { Name = "project_status", Value = value };
        }

        [JsonProperty("project_timeline")]
        [JsonConverter(typeof(QueryBuilderParameterConverter<string?>))]
        public QueryBuilderParameter<string?>? ProjectTimeline {
            get => (QueryBuilderParameter<string?>?)_projectTimeline.Value;
            set => _projectTimeline = new InputPropertyInfo { Name = "project_timeline", Value = value };
        }

        [JsonProperty("project_owner")]
        [JsonConverter(typeof(QueryBuilderParameterConverter<string?>))]
        public QueryBuilderParameter<string?>? ProjectOwner {
            get => (QueryBuilderParameter<string?>?)_projectOwner.Value;
            set => _projectOwner = new InputPropertyInfo { Name = "project_owner", Value = value };
        }

        IEnumerable<InputPropertyInfo> IGraphQlInputObject.GetPropertyValues() {
            if (_projectStatus.Name != null) yield return _projectStatus;
            if (_projectTimeline.Name != null) yield return _projectTimeline;
            if (_projectOwner.Name != null) yield return _projectOwner;
        }
    }
}
