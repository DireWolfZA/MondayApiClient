using System.Collections.Generic;
using Newtonsoft.Json;

namespace MondayApi.Schema {
    public class FormAfterSubmissionViewInput : IGraphQlInputObject {
        private InputPropertyInfo _title;
        private InputPropertyInfo _description;
        private InputPropertyInfo _redirectAfterSubmission;
        private InputPropertyInfo _allowResubmit;
        private InputPropertyInfo _showSuccessImage;
        private InputPropertyInfo _allowEditSubmission;
        private InputPropertyInfo _allowViewSubmission;

        [JsonConverter(typeof(QueryBuilderParameterConverter<string?>))]
        public QueryBuilderParameter<string?>? Title {
            get => (QueryBuilderParameter<string?>?)_title.Value;
            set => _title = new InputPropertyInfo { Name = "title", Value = value };
        }

        [JsonConverter(typeof(QueryBuilderParameterConverter<string?>))]
        public QueryBuilderParameter<string?>? Description {
            get => (QueryBuilderParameter<string?>?)_description.Value;
            set => _description = new InputPropertyInfo { Name = "description", Value = value };
        }

        [JsonConverter(typeof(QueryBuilderParameterConverter<FormRedirectAfterSubmissionInput?>))]
        public QueryBuilderParameter<FormRedirectAfterSubmissionInput?>? RedirectAfterSubmission {
            get => (QueryBuilderParameter<FormRedirectAfterSubmissionInput?>?)_redirectAfterSubmission.Value;
            set => _redirectAfterSubmission = new InputPropertyInfo { Name = "redirectAfterSubmission", Value = value };
        }

        [JsonConverter(typeof(QueryBuilderParameterConverter<bool?>))]
        public QueryBuilderParameter<bool?>? AllowResubmit {
            get => (QueryBuilderParameter<bool?>?)_allowResubmit.Value;
            set => _allowResubmit = new InputPropertyInfo { Name = "allowResubmit", Value = value };
        }

        [JsonConverter(typeof(QueryBuilderParameterConverter<bool?>))]
        public QueryBuilderParameter<bool?>? ShowSuccessImage {
            get => (QueryBuilderParameter<bool?>?)_showSuccessImage.Value;
            set => _showSuccessImage = new InputPropertyInfo { Name = "showSuccessImage", Value = value };
        }

        [JsonConverter(typeof(QueryBuilderParameterConverter<bool?>))]
        public QueryBuilderParameter<bool?>? AllowEditSubmission {
            get => (QueryBuilderParameter<bool?>?)_allowEditSubmission.Value;
            set => _allowEditSubmission = new InputPropertyInfo { Name = "allowEditSubmission", Value = value };
        }

        [JsonConverter(typeof(QueryBuilderParameterConverter<bool?>))]
        public QueryBuilderParameter<bool?>? AllowViewSubmission {
            get => (QueryBuilderParameter<bool?>?)_allowViewSubmission.Value;
            set => _allowViewSubmission = new InputPropertyInfo { Name = "allowViewSubmission", Value = value };
        }

        IEnumerable<InputPropertyInfo> IGraphQlInputObject.GetPropertyValues() {
            if (_title.Name != null) yield return _title;
            if (_description.Name != null) yield return _description;
            if (_redirectAfterSubmission.Name != null) yield return _redirectAfterSubmission;
            if (_allowResubmit.Name != null) yield return _allowResubmit;
            if (_showSuccessImage.Name != null) yield return _showSuccessImage;
            if (_allowEditSubmission.Name != null) yield return _allowEditSubmission;
            if (_allowViewSubmission.Name != null) yield return _allowViewSubmission;
        }
    }
}
