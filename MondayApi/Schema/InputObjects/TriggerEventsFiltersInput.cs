using System.Collections.Generic;
using Newtonsoft.Json;

namespace MondayApi.Schema {
    public class TriggerEventsFiltersInput : IGraphQlInputObject {
        private InputPropertyInfo _dateRange;
        private InputPropertyInfo _entityKind;
        private InputPropertyInfo _automationIDs;
        private InputPropertyInfo _workflowEntityIDs;
        private InputPropertyInfo _stateFilter;
        private InputPropertyInfo _itemID;
        private InputPropertyInfo _filterByEntity;
        private InputPropertyInfo _isAutomationsEntity;
        private InputPropertyInfo _appFilter;
        private InputPropertyInfo _hostType;
        private InputPropertyInfo _hostInstanceID;
        private InputPropertyInfo _creatorAppFeatureReferenceID;
        private InputPropertyInfo _billingActionCountField;
        private InputPropertyInfo _isWorkflowFilter;
        private InputPropertyInfo _boardID;
        private InputPropertyInfo _statusFilter;

        [JsonConverter(typeof(QueryBuilderParameterConverter<DateRangeInput?>))]
        public QueryBuilderParameter<DateRangeInput?>? DateRange {
            get => (QueryBuilderParameter<DateRangeInput?>?)_dateRange.Value;
            set => _dateRange = new InputPropertyInfo { Name = "dateRange", Value = value };
        }

        [JsonConverter(typeof(QueryBuilderParameterConverter<string?>))]
        public QueryBuilderParameter<string?>? EntityKind {
            get => (QueryBuilderParameter<string?>?)_entityKind.Value;
            set => _entityKind = new InputPropertyInfo { Name = "entityKind", Value = value };
        }

        [JsonConverter(typeof(QueryBuilderParameterConverter<ICollection<int>?>))]
        public QueryBuilderParameter<ICollection<int>?>? AutomationIDs {
            get => (QueryBuilderParameter<ICollection<int>?>?)_automationIDs.Value;
            set => _automationIDs = new InputPropertyInfo { Name = "automationIds", Value = value };
        }

        [JsonConverter(typeof(QueryBuilderParameterConverter<ICollection<int>?>))]
        public QueryBuilderParameter<ICollection<int>?>? WorkflowEntityIDs {
            get => (QueryBuilderParameter<ICollection<int>?>?)_workflowEntityIDs.Value;
            set => _workflowEntityIDs = new InputPropertyInfo { Name = "workflowEntityIds", Value = value };
        }

        [JsonConverter(typeof(QueryBuilderParameterConverter<ICollection<string>?>))]
        public QueryBuilderParameter<ICollection<string>?>? StateFilter {
            get => (QueryBuilderParameter<ICollection<string>?>?)_stateFilter.Value;
            set => _stateFilter = new InputPropertyInfo { Name = "stateFilter", Value = value };
        }

        [JsonConverter(typeof(QueryBuilderParameterConverter<string?>))]
        public QueryBuilderParameter<string?>? ItemID {
            get => (QueryBuilderParameter<string?>?)_itemID.Value;
            set => _itemID = new InputPropertyInfo { Name = "itemId", Value = value };
        }

        [JsonConverter(typeof(QueryBuilderParameterConverter<bool?>))]
        public QueryBuilderParameter<bool?>? FilterByEntity {
            get => (QueryBuilderParameter<bool?>?)_filterByEntity.Value;
            set => _filterByEntity = new InputPropertyInfo { Name = "filterByEntity", Value = value };
        }

        [JsonConverter(typeof(QueryBuilderParameterConverter<bool?>))]
        public QueryBuilderParameter<bool?>? IsAutomationsEntity {
            get => (QueryBuilderParameter<bool?>?)_isAutomationsEntity.Value;
            set => _isAutomationsEntity = new InputPropertyInfo { Name = "isAutomationsEntity", Value = value };
        }

        [JsonConverter(typeof(QueryBuilderParameterConverter<ICollection<string>?>))]
        public QueryBuilderParameter<ICollection<string>?>? AppFilter {
            get => (QueryBuilderParameter<ICollection<string>?>?)_appFilter.Value;
            set => _appFilter = new InputPropertyInfo { Name = "appFilter", Value = value };
        }

        [JsonConverter(typeof(QueryBuilderParameterConverter<string?>))]
        public QueryBuilderParameter<string?>? HostType {
            get => (QueryBuilderParameter<string?>?)_hostType.Value;
            set => _hostType = new InputPropertyInfo { Name = "hostType", Value = value };
        }

        [JsonConverter(typeof(QueryBuilderParameterConverter<string?>))]
        public QueryBuilderParameter<string?>? HostInstanceID {
            get => (QueryBuilderParameter<string?>?)_hostInstanceID.Value;
            set => _hostInstanceID = new InputPropertyInfo { Name = "hostInstanceId", Value = value };
        }

        [JsonConverter(typeof(QueryBuilderParameterConverter<int?>))]
        public QueryBuilderParameter<int?>? CreatorAppFeatureReferenceID {
            get => (QueryBuilderParameter<int?>?)_creatorAppFeatureReferenceID.Value;
            set => _creatorAppFeatureReferenceID = new InputPropertyInfo { Name = "creatorAppFeatureReferenceId", Value = value };
        }

        [JsonConverter(typeof(QueryBuilderParameterConverter<string?>))]
        public QueryBuilderParameter<string?>? BillingActionCountField {
            get => (QueryBuilderParameter<string?>?)_billingActionCountField.Value;
            set => _billingActionCountField = new InputPropertyInfo { Name = "billingActionCountField", Value = value };
        }

        [JsonConverter(typeof(QueryBuilderParameterConverter<bool?>))]
        public QueryBuilderParameter<bool?>? IsWorkflowFilter {
            get => (QueryBuilderParameter<bool?>?)_isWorkflowFilter.Value;
            set => _isWorkflowFilter = new InputPropertyInfo { Name = "isWorkflowFilter", Value = value };
        }

        [JsonConverter(typeof(QueryBuilderParameterConverter<string?>))]
        public QueryBuilderParameter<string?>? BoardID {
            get => (QueryBuilderParameter<string?>?)_boardID.Value;
            set => _boardID = new InputPropertyInfo { Name = "boardId", Value = value };
        }

        [JsonConverter(typeof(QueryBuilderParameterConverter<ICollection<string>?>))]
        public QueryBuilderParameter<ICollection<string>?>? StatusFilter {
            get => (QueryBuilderParameter<ICollection<string>?>?)_statusFilter.Value;
            set => _statusFilter = new InputPropertyInfo { Name = "statusFilter", Value = value };
        }

        IEnumerable<InputPropertyInfo> IGraphQlInputObject.GetPropertyValues() {
            if (_dateRange.Name != null) yield return _dateRange;
            if (_entityKind.Name != null) yield return _entityKind;
            if (_automationIDs.Name != null) yield return _automationIDs;
            if (_workflowEntityIDs.Name != null) yield return _workflowEntityIDs;
            if (_stateFilter.Name != null) yield return _stateFilter;
            if (_itemID.Name != null) yield return _itemID;
            if (_filterByEntity.Name != null) yield return _filterByEntity;
            if (_isAutomationsEntity.Name != null) yield return _isAutomationsEntity;
            if (_appFilter.Name != null) yield return _appFilter;
            if (_hostType.Name != null) yield return _hostType;
            if (_hostInstanceID.Name != null) yield return _hostInstanceID;
            if (_creatorAppFeatureReferenceID.Name != null) yield return _creatorAppFeatureReferenceID;
            if (_billingActionCountField.Name != null) yield return _billingActionCountField;
            if (_isWorkflowFilter.Name != null) yield return _isWorkflowFilter;
            if (_boardID.Name != null) yield return _boardID;
            if (_statusFilter.Name != null) yield return _statusFilter;
        }
    }
}
