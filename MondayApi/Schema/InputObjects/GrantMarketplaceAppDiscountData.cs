using System.Collections.Generic;
using Newtonsoft.Json;

namespace MondayApi.Schema {
    public class GrantMarketplaceAppDiscountData : IGraphQlInputObject {
        private InputPropertyInfo _daysValid;
        private InputPropertyInfo _discount;
        private InputPropertyInfo _isRecurring;
        private InputPropertyInfo _period;
        private InputPropertyInfo _appPlanIDs;

        [JsonProperty("days_valid")]
        [JsonConverter(typeof(QueryBuilderParameterConverter<int?>))]
        public QueryBuilderParameter<int?> DaysValid {
            get => (QueryBuilderParameter<int?>)_daysValid.Value;
            set => _daysValid = new InputPropertyInfo { Name = "days_valid", Value = value };
        }

        [JsonConverter(typeof(QueryBuilderParameterConverter<int?>))]
        public QueryBuilderParameter<int?> Discount {
            get => (QueryBuilderParameter<int?>)_discount.Value;
            set => _discount = new InputPropertyInfo { Name = "discount", Value = value };
        }

        [JsonProperty("is_recurring")]
        [JsonConverter(typeof(QueryBuilderParameterConverter<bool?>))]
        public QueryBuilderParameter<bool?> IsRecurring {
            get => (QueryBuilderParameter<bool?>)_isRecurring.Value;
            set => _isRecurring = new InputPropertyInfo { Name = "is_recurring", Value = value };
        }

        [JsonConverter(typeof(QueryBuilderParameterConverter<DiscountPeriod?>))]
        public QueryBuilderParameter<DiscountPeriod?> Period {
            get => (QueryBuilderParameter<DiscountPeriod?>)_period.Value;
            set => _period = new InputPropertyInfo { Name = "period", Value = value };
        }

        [JsonProperty("app_plan_ids")]
        [JsonConverter(typeof(QueryBuilderParameterConverter<ICollection<string>>))]
        public QueryBuilderParameter<ICollection<string>> AppPlanIDs {
            get => (QueryBuilderParameter<ICollection<string>>)_appPlanIDs.Value;
            set => _appPlanIDs = new InputPropertyInfo { Name = "app_plan_ids", Value = value };
        }

        IEnumerable<InputPropertyInfo> IGraphQlInputObject.GetPropertyValues() {
            if (_daysValid.Name != null) yield return _daysValid;
            if (_discount.Name != null) yield return _discount;
            if (_isRecurring.Name != null) yield return _isRecurring;
            if (_period.Name != null) yield return _period;
            if (_appPlanIDs.Name != null) yield return _appPlanIDs;
        }
    }
}
