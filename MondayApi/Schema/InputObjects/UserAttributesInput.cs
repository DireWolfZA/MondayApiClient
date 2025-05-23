using System.Collections.Generic;
using Newtonsoft.Json;

namespace MondayApi.Schema {
    public class UserAttributesInput : IGraphQlInputObject {
        private InputPropertyInfo _birthday;
        private InputPropertyInfo _email;
        private InputPropertyInfo _joinDate;
        private InputPropertyInfo _name;
        private InputPropertyInfo _location;
        private InputPropertyInfo _mobilePhone;
        private InputPropertyInfo _phone;
        private InputPropertyInfo _title;
        private InputPropertyInfo _department;

        [JsonConverter(typeof(QueryBuilderParameterConverter<string?>))]
        public QueryBuilderParameter<string?>? Birthday {
            get => (QueryBuilderParameter<string?>?)_birthday.Value;
            set => _birthday = new InputPropertyInfo { Name = "birthday", Value = value };
        }

        [JsonConverter(typeof(QueryBuilderParameterConverter<string?>))]
        public QueryBuilderParameter<string?>? Email {
            get => (QueryBuilderParameter<string?>?)_email.Value;
            set => _email = new InputPropertyInfo { Name = "email", Value = value };
        }

        [JsonProperty("join_date")]
        [JsonConverter(typeof(QueryBuilderParameterConverter<string?>))]
        public QueryBuilderParameter<string?>? JoinDate {
            get => (QueryBuilderParameter<string?>?)_joinDate.Value;
            set => _joinDate = new InputPropertyInfo { Name = "join_date", Value = value };
        }

        [JsonConverter(typeof(QueryBuilderParameterConverter<string?>))]
        public QueryBuilderParameter<string?>? Name {
            get => (QueryBuilderParameter<string?>?)_name.Value;
            set => _name = new InputPropertyInfo { Name = "name", Value = value };
        }

        [JsonConverter(typeof(QueryBuilderParameterConverter<string?>))]
        public QueryBuilderParameter<string?>? Location {
            get => (QueryBuilderParameter<string?>?)_location.Value;
            set => _location = new InputPropertyInfo { Name = "location", Value = value };
        }

        [JsonProperty("mobile_phone")]
        [JsonConverter(typeof(QueryBuilderParameterConverter<string?>))]
        public QueryBuilderParameter<string?>? MobilePhone {
            get => (QueryBuilderParameter<string?>?)_mobilePhone.Value;
            set => _mobilePhone = new InputPropertyInfo { Name = "mobile_phone", Value = value };
        }

        [JsonConverter(typeof(QueryBuilderParameterConverter<string?>))]
        public QueryBuilderParameter<string?>? Phone {
            get => (QueryBuilderParameter<string?>?)_phone.Value;
            set => _phone = new InputPropertyInfo { Name = "phone", Value = value };
        }

        [JsonConverter(typeof(QueryBuilderParameterConverter<string?>))]
        public QueryBuilderParameter<string?>? Title {
            get => (QueryBuilderParameter<string?>?)_title.Value;
            set => _title = new InputPropertyInfo { Name = "title", Value = value };
        }

        [JsonConverter(typeof(QueryBuilderParameterConverter<string?>))]
        public QueryBuilderParameter<string?>? Department {
            get => (QueryBuilderParameter<string?>?)_department.Value;
            set => _department = new InputPropertyInfo { Name = "department", Value = value };
        }

        IEnumerable<InputPropertyInfo> IGraphQlInputObject.GetPropertyValues() {
            if (_birthday.Name != null) yield return _birthday;
            if (_email.Name != null) yield return _email;
            if (_joinDate.Name != null) yield return _joinDate;
            if (_name.Name != null) yield return _name;
            if (_location.Name != null) yield return _location;
            if (_mobilePhone.Name != null) yield return _mobilePhone;
            if (_phone.Name != null) yield return _phone;
            if (_title.Name != null) yield return _title;
            if (_department.Name != null) yield return _department;
        }
    }
}
