using System.Collections.Generic;

namespace MondayApi.Schema {
    public class BatchExtendTrialPeriodQueryBuilder : GraphQlQueryBuilder<BatchExtendTrialPeriodQueryBuilder> {
        private static readonly GraphQlFieldMetadata[] AllFieldMetadata = new[] {
            new GraphQlFieldMetadata { Name = "details", IsComplex = true, QueryBuilderType = typeof(ExtendTrialPeriodQueryBuilder) },
            new GraphQlFieldMetadata { Name = "reason" },
            new GraphQlFieldMetadata { Name = "success" }
        };

        protected override string TypeName => "BatchExtendTrialPeriod";
        public override IReadOnlyList<GraphQlFieldMetadata> AllFields => AllFieldMetadata;

        public BatchExtendTrialPeriodQueryBuilder WithDetails(ExtendTrialPeriodQueryBuilder extendTrialPeriodQueryBuilder, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithObjectField("details", alias, extendTrialPeriodQueryBuilder, new GraphQlDirective?[] { include, skip });
        public BatchExtendTrialPeriodQueryBuilder ExceptDetails() =>
            ExceptField("details");
        public BatchExtendTrialPeriodQueryBuilder WithReason(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("reason", alias, new GraphQlDirective?[] { include, skip });
        public BatchExtendTrialPeriodQueryBuilder ExceptReason() =>
            ExceptField("reason");
        public BatchExtendTrialPeriodQueryBuilder WithSuccess(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("success", alias, new GraphQlDirective?[] { include, skip });
        public BatchExtendTrialPeriodQueryBuilder ExceptSuccess() =>
            ExceptField("success");
    }
}
