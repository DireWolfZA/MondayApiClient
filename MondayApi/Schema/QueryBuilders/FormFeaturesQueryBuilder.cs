using System.Collections.Generic;

namespace MondayApi.Schema {
    public class FormFeaturesQueryBuilder : GraphQlQueryBuilder<FormFeaturesQueryBuilder> {
        private static readonly GraphQlFieldMetadata[] AllFieldMetadata = new[] {
            new GraphQlFieldMetadata { Name = "isInternal" },
            new GraphQlFieldMetadata { Name = "reCaptchaChallenge" },
            new GraphQlFieldMetadata { Name = "shortenedLink", IsComplex = true, QueryBuilderType = typeof(FormShortenedLinkQueryBuilder) },
            new GraphQlFieldMetadata { Name = "password", IsComplex = true, QueryBuilderType = typeof(FormPasswordQueryBuilder) },
            new GraphQlFieldMetadata { Name = "draftSubmission", IsComplex = true, QueryBuilderType = typeof(FormDraftSubmissionQueryBuilder) },
            new GraphQlFieldMetadata { Name = "requireLogin", IsComplex = true, QueryBuilderType = typeof(FormRequireLoginQueryBuilder) },
            new GraphQlFieldMetadata { Name = "responseLimit", IsComplex = true, QueryBuilderType = typeof(FormResponseLimitQueryBuilder) },
            new GraphQlFieldMetadata { Name = "closeDate", IsComplex = true, QueryBuilderType = typeof(FormCloseDateQueryBuilder) },
            new GraphQlFieldMetadata { Name = "preSubmissionView", IsComplex = true, QueryBuilderType = typeof(FormPreSubmissionViewQueryBuilder) },
            new GraphQlFieldMetadata { Name = "afterSubmissionView", IsComplex = true, QueryBuilderType = typeof(FormAfterSubmissionViewQueryBuilder) },
            new GraphQlFieldMetadata { Name = "monday", IsComplex = true, QueryBuilderType = typeof(FormMondayQueryBuilder) }
        };

        protected override string TypeName => "FormFeatures";
        public override IReadOnlyList<GraphQlFieldMetadata> AllFields => AllFieldMetadata;

        public FormFeaturesQueryBuilder WithIsInternal(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("isInternal", alias, new GraphQlDirective?[] { include, skip });
        public FormFeaturesQueryBuilder ExceptIsInternal() =>
            ExceptField("isInternal");
        public FormFeaturesQueryBuilder WithReCaptchaChallenge(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("reCaptchaChallenge", alias, new GraphQlDirective?[] { include, skip });
        public FormFeaturesQueryBuilder ExceptReCaptchaChallenge() =>
            ExceptField("reCaptchaChallenge");
        public FormFeaturesQueryBuilder WithShortenedLink(FormShortenedLinkQueryBuilder formShortenedLinkQueryBuilder, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithObjectField("shortenedLink", alias, formShortenedLinkQueryBuilder, new GraphQlDirective?[] { include, skip });
        public FormFeaturesQueryBuilder ExceptShortenedLink() =>
            ExceptField("shortenedLink");
        public FormFeaturesQueryBuilder WithPassword(FormPasswordQueryBuilder formPasswordQueryBuilder, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithObjectField("password", alias, formPasswordQueryBuilder, new GraphQlDirective?[] { include, skip });
        public FormFeaturesQueryBuilder ExceptPassword() =>
            ExceptField("password");
        public FormFeaturesQueryBuilder WithDraftSubmission(FormDraftSubmissionQueryBuilder formDraftSubmissionQueryBuilder, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithObjectField("draftSubmission", alias, formDraftSubmissionQueryBuilder, new GraphQlDirective?[] { include, skip });
        public FormFeaturesQueryBuilder ExceptDraftSubmission() =>
            ExceptField("draftSubmission");
        public FormFeaturesQueryBuilder WithRequireLogin(FormRequireLoginQueryBuilder formRequireLoginQueryBuilder, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithObjectField("requireLogin", alias, formRequireLoginQueryBuilder, new GraphQlDirective?[] { include, skip });
        public FormFeaturesQueryBuilder ExceptRequireLogin() =>
            ExceptField("requireLogin");
        public FormFeaturesQueryBuilder WithResponseLimit(FormResponseLimitQueryBuilder formResponseLimitQueryBuilder, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithObjectField("responseLimit", alias, formResponseLimitQueryBuilder, new GraphQlDirective?[] { include, skip });
        public FormFeaturesQueryBuilder ExceptResponseLimit() =>
            ExceptField("responseLimit");
        public FormFeaturesQueryBuilder WithCloseDate(FormCloseDateQueryBuilder formCloseDateQueryBuilder, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithObjectField("closeDate", alias, formCloseDateQueryBuilder, new GraphQlDirective?[] { include, skip });
        public FormFeaturesQueryBuilder ExceptCloseDate() =>
            ExceptField("closeDate");
        public FormFeaturesQueryBuilder WithPreSubmissionView(FormPreSubmissionViewQueryBuilder formPreSubmissionViewQueryBuilder, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithObjectField("preSubmissionView", alias, formPreSubmissionViewQueryBuilder, new GraphQlDirective?[] { include, skip });
        public FormFeaturesQueryBuilder ExceptPreSubmissionView() =>
            ExceptField("preSubmissionView");
        public FormFeaturesQueryBuilder WithAfterSubmissionView(FormAfterSubmissionViewQueryBuilder formAfterSubmissionViewQueryBuilder, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithObjectField("afterSubmissionView", alias, formAfterSubmissionViewQueryBuilder, new GraphQlDirective?[] { include, skip });
        public FormFeaturesQueryBuilder ExceptAfterSubmissionView() =>
            ExceptField("afterSubmissionView");
        public FormFeaturesQueryBuilder WithMonday(FormMondayQueryBuilder formMondayQueryBuilder, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithObjectField("monday", alias, formMondayQueryBuilder, new GraphQlDirective?[] { include, skip });
        public FormFeaturesQueryBuilder ExceptMonday() =>
            ExceptField("monday");
    }
}
