using System.Collections.Generic;

namespace MondayApi.Schema {
    public class ExtendTrialPeriodQueryBuilder : GraphQlQueryBuilder<ExtendTrialPeriodQueryBuilder> {
        private static readonly GraphQlFieldMetadata[] AllFieldMetadata = new[] {
            new GraphQlFieldMetadata { Name = "account_slug" },
            new GraphQlFieldMetadata { Name = "reason" },
            new GraphQlFieldMetadata { Name = "success" }
        };

        protected override string TypeName => "ExtendTrialPeriod";
        public override IReadOnlyList<GraphQlFieldMetadata> AllFields => AllFieldMetadata;

        public ExtendTrialPeriodQueryBuilder WithAccountSlug(string alias = null, IncludeDirective include = null, SkipDirective skip = null) =>
            WithScalarField("account_slug", alias, new GraphQlDirective[] { include, skip });
        public ExtendTrialPeriodQueryBuilder ExceptAccountSlug() =>
            ExceptField("account_slug");
        public ExtendTrialPeriodQueryBuilder WithReason(string alias = null, IncludeDirective include = null, SkipDirective skip = null) =>
            WithScalarField("reason", alias, new GraphQlDirective[] { include, skip });
        public ExtendTrialPeriodQueryBuilder ExceptReason() =>
            ExceptField("reason");
        public ExtendTrialPeriodQueryBuilder WithSuccess(string alias = null, IncludeDirective include = null, SkipDirective skip = null) =>
            WithScalarField("success", alias, new GraphQlDirective[] { include, skip });
        public ExtendTrialPeriodQueryBuilder ExceptSuccess() =>
            ExceptField("success");
    }
}
