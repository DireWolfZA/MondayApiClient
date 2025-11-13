using System.Collections.Generic;
using Newtonsoft.Json;

namespace MondayApi.Schema {
    public class DependencyValueInput : IGraphQlInputObject {
        private InputPropertyInfo _addedPulse;
        private InputPropertyInfo _removedPulse;

        [JsonProperty("added_pulse")]
        [JsonConverter(typeof(QueryBuilderParameterConverter<ICollection<UpdateDependencyColumnInput>?>))]
        public QueryBuilderParameter<ICollection<UpdateDependencyColumnInput>?>? AddedPulse {
            get => (QueryBuilderParameter<ICollection<UpdateDependencyColumnInput>?>?)_addedPulse.Value;
            set => _addedPulse = new InputPropertyInfo { Name = "added_pulse", Value = value };
        }

        [JsonProperty("removed_pulse")]
        [JsonConverter(typeof(QueryBuilderParameterConverter<ICollection<UpdateDependencyColumnInput>?>))]
        public QueryBuilderParameter<ICollection<UpdateDependencyColumnInput>?>? RemovedPulse {
            get => (QueryBuilderParameter<ICollection<UpdateDependencyColumnInput>?>?)_removedPulse.Value;
            set => _removedPulse = new InputPropertyInfo { Name = "removed_pulse", Value = value };
        }

        IEnumerable<InputPropertyInfo> IGraphQlInputObject.GetPropertyValues() {
            if (_addedPulse.Name != null) yield return _addedPulse;
            if (_removedPulse.Name != null) yield return _removedPulse;
        }
    }
}
