using System.Collections.Generic;

namespace MondayApi.Schema {
    public class FormRedirectAfterSubmissionQueryBuilder : GraphQlQueryBuilder<FormRedirectAfterSubmissionQueryBuilder> {
        private static readonly GraphQlFieldMetadata[] AllFieldMetadata = new[] {
            new GraphQlFieldMetadata { Name = "enabled" },
            new GraphQlFieldMetadata { Name = "redirectUrl" }
        };

        protected override string TypeName => "FormRedirectAfterSubmission";
        public override IReadOnlyList<GraphQlFieldMetadata> AllFields => AllFieldMetadata;

        public FormRedirectAfterSubmissionQueryBuilder WithEnabled(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("enabled", alias, new GraphQlDirective?[] { include, skip });
        public FormRedirectAfterSubmissionQueryBuilder ExceptEnabled() =>
            ExceptField("enabled");
        public FormRedirectAfterSubmissionQueryBuilder WithRedirectURL(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("redirectUrl", alias, new GraphQlDirective?[] { include, skip });
        public FormRedirectAfterSubmissionQueryBuilder ExceptRedirectURL() =>
            ExceptField("redirectUrl");
    }
}
