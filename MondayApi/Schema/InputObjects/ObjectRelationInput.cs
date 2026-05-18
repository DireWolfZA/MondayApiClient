using System.Collections.Generic;
using Newtonsoft.Json;

namespace MondayApi.Schema {
    public class ObjectRelationInput : IGraphQlInputObject {
        private InputPropertyInfo _kind;
        private InputPropertyInfo _targetID;
        private InputPropertyInfo _targetObjectType;

        [JsonConverter(typeof(QueryBuilderParameterConverter<RelationKind?>))]
        public QueryBuilderParameter<RelationKind?>? Kind {
            get => (QueryBuilderParameter<RelationKind?>?)_kind.Value;
            set => _kind = new InputPropertyInfo { Name = "kind", Value = value };
        }

        [JsonProperty("target_id")]
        [JsonConverter(typeof(QueryBuilderParameterConverter<string?>))]
        public QueryBuilderParameter<string?>? TargetID {
            get => (QueryBuilderParameter<string?>?)_targetID.Value;
            set => _targetID = new InputPropertyInfo { Name = "target_id", Value = value };
        }

        [JsonProperty("target_object_type")]
        [JsonConverter(typeof(QueryBuilderParameterConverter<TargetObject?>))]
        public QueryBuilderParameter<TargetObject?>? TargetObjectType {
            get => (QueryBuilderParameter<TargetObject?>?)_targetObjectType.Value;
            set => _targetObjectType = new InputPropertyInfo { Name = "target_object_type", Value = value };
        }

        IEnumerable<InputPropertyInfo> IGraphQlInputObject.GetPropertyValues() {
            if (_kind.Name != null) yield return _kind;
            if (_targetID.Name != null) yield return _targetID;
            if (_targetObjectType.Name != null) yield return _targetObjectType;
        }
    }
}
