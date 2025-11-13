using System.Collections.Generic;
using Newtonsoft.Json;

namespace MondayApi.Schema {
    public class FormFeaturesInput : IGraphQlInputObject {
        private InputPropertyInfo _reCaptchaChallenge;
        private InputPropertyInfo _draftSubmission;
        private InputPropertyInfo _requireLogin;
        private InputPropertyInfo _responseLimit;
        private InputPropertyInfo _closeDate;
        private InputPropertyInfo _preSubmissionView;
        private InputPropertyInfo _afterSubmissionView;
        private InputPropertyInfo _monday;
        private InputPropertyInfo _password;

        [JsonConverter(typeof(QueryBuilderParameterConverter<bool?>))]
        public QueryBuilderParameter<bool?>? ReCaptchaChallenge {
            get => (QueryBuilderParameter<bool?>?)_reCaptchaChallenge.Value;
            set => _reCaptchaChallenge = new InputPropertyInfo { Name = "reCaptchaChallenge", Value = value };
        }

        [JsonConverter(typeof(QueryBuilderParameterConverter<FormDraftSubmissionInput?>))]
        public QueryBuilderParameter<FormDraftSubmissionInput?>? DraftSubmission {
            get => (QueryBuilderParameter<FormDraftSubmissionInput?>?)_draftSubmission.Value;
            set => _draftSubmission = new InputPropertyInfo { Name = "draftSubmission", Value = value };
        }

        [JsonConverter(typeof(QueryBuilderParameterConverter<FormRequireLoginInput?>))]
        public QueryBuilderParameter<FormRequireLoginInput?>? RequireLogin {
            get => (QueryBuilderParameter<FormRequireLoginInput?>?)_requireLogin.Value;
            set => _requireLogin = new InputPropertyInfo { Name = "requireLogin", Value = value };
        }

        [JsonConverter(typeof(QueryBuilderParameterConverter<FormResponseLimitInput?>))]
        public QueryBuilderParameter<FormResponseLimitInput?>? ResponseLimit {
            get => (QueryBuilderParameter<FormResponseLimitInput?>?)_responseLimit.Value;
            set => _responseLimit = new InputPropertyInfo { Name = "responseLimit", Value = value };
        }

        [JsonConverter(typeof(QueryBuilderParameterConverter<FormCloseDateInput?>))]
        public QueryBuilderParameter<FormCloseDateInput?>? CloseDate {
            get => (QueryBuilderParameter<FormCloseDateInput?>?)_closeDate.Value;
            set => _closeDate = new InputPropertyInfo { Name = "closeDate", Value = value };
        }

        [JsonConverter(typeof(QueryBuilderParameterConverter<FormPreSubmissionViewInput?>))]
        public QueryBuilderParameter<FormPreSubmissionViewInput?>? PreSubmissionView {
            get => (QueryBuilderParameter<FormPreSubmissionViewInput?>?)_preSubmissionView.Value;
            set => _preSubmissionView = new InputPropertyInfo { Name = "preSubmissionView", Value = value };
        }

        [JsonConverter(typeof(QueryBuilderParameterConverter<FormAfterSubmissionViewInput?>))]
        public QueryBuilderParameter<FormAfterSubmissionViewInput?>? AfterSubmissionView {
            get => (QueryBuilderParameter<FormAfterSubmissionViewInput?>?)_afterSubmissionView.Value;
            set => _afterSubmissionView = new InputPropertyInfo { Name = "afterSubmissionView", Value = value };
        }

        [JsonConverter(typeof(QueryBuilderParameterConverter<FormMondayInput?>))]
        public QueryBuilderParameter<FormMondayInput?>? Monday {
            get => (QueryBuilderParameter<FormMondayInput?>?)_monday.Value;
            set => _monday = new InputPropertyInfo { Name = "monday", Value = value };
        }

        [JsonConverter(typeof(QueryBuilderParameterConverter<FormPasswordInput?>))]
        public QueryBuilderParameter<FormPasswordInput?>? Password {
            get => (QueryBuilderParameter<FormPasswordInput?>?)_password.Value;
            set => _password = new InputPropertyInfo { Name = "password", Value = value };
        }

        IEnumerable<InputPropertyInfo> IGraphQlInputObject.GetPropertyValues() {
            if (_reCaptchaChallenge.Name != null) yield return _reCaptchaChallenge;
            if (_draftSubmission.Name != null) yield return _draftSubmission;
            if (_requireLogin.Name != null) yield return _requireLogin;
            if (_responseLimit.Name != null) yield return _responseLimit;
            if (_closeDate.Name != null) yield return _closeDate;
            if (_preSubmissionView.Name != null) yield return _preSubmissionView;
            if (_afterSubmissionView.Name != null) yield return _afterSubmissionView;
            if (_monday.Name != null) yield return _monday;
            if (_password.Name != null) yield return _password;
        }
    }
}
