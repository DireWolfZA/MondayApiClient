using System.Collections.Generic;

namespace MondayApi.Schema {
    public class FormAfterSubmissionViewQueryBuilder : GraphQlQueryBuilder<FormAfterSubmissionViewQueryBuilder> {
        private static readonly GraphQlFieldMetadata[] AllFieldMetadata = new[] {
            new GraphQlFieldMetadata { Name = "title" },
            new GraphQlFieldMetadata { Name = "description" },
            new GraphQlFieldMetadata { Name = "redirectAfterSubmission", IsComplex = true, QueryBuilderType = typeof(FormRedirectAfterSubmissionQueryBuilder) },
            new GraphQlFieldMetadata { Name = "allowResubmit" },
            new GraphQlFieldMetadata { Name = "showSuccessImage" },
            new GraphQlFieldMetadata { Name = "allowEditSubmission" },
            new GraphQlFieldMetadata { Name = "allowViewSubmission" }
        };

        protected override string TypeName => "FormAfterSubmissionView";
        public override IReadOnlyList<GraphQlFieldMetadata> AllFields => AllFieldMetadata;

        public FormAfterSubmissionViewQueryBuilder WithTitle(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("title", alias, new GraphQlDirective?[] { include, skip });
        public FormAfterSubmissionViewQueryBuilder ExceptTitle() =>
            ExceptField("title");
        public FormAfterSubmissionViewQueryBuilder WithDescription(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("description", alias, new GraphQlDirective?[] { include, skip });
        public FormAfterSubmissionViewQueryBuilder ExceptDescription() =>
            ExceptField("description");
        public FormAfterSubmissionViewQueryBuilder WithRedirectAfterSubmission(FormRedirectAfterSubmissionQueryBuilder formRedirectAfterSubmissionQueryBuilder, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithObjectField("redirectAfterSubmission", alias, formRedirectAfterSubmissionQueryBuilder, new GraphQlDirective?[] { include, skip });
        public FormAfterSubmissionViewQueryBuilder ExceptRedirectAfterSubmission() =>
            ExceptField("redirectAfterSubmission");
        public FormAfterSubmissionViewQueryBuilder WithAllowResubmit(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("allowResubmit", alias, new GraphQlDirective?[] { include, skip });
        public FormAfterSubmissionViewQueryBuilder ExceptAllowResubmit() =>
            ExceptField("allowResubmit");
        public FormAfterSubmissionViewQueryBuilder WithShowSuccessImage(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("showSuccessImage", alias, new GraphQlDirective?[] { include, skip });
        public FormAfterSubmissionViewQueryBuilder ExceptShowSuccessImage() =>
            ExceptField("showSuccessImage");
        public FormAfterSubmissionViewQueryBuilder WithAllowEditSubmission(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("allowEditSubmission", alias, new GraphQlDirective?[] { include, skip });
        public FormAfterSubmissionViewQueryBuilder ExceptAllowEditSubmission() =>
            ExceptField("allowEditSubmission");
        public FormAfterSubmissionViewQueryBuilder WithAllowViewSubmission(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("allowViewSubmission", alias, new GraphQlDirective?[] { include, skip });
        public FormAfterSubmissionViewQueryBuilder ExceptAllowViewSubmission() =>
            ExceptField("allowViewSubmission");
    }
}
