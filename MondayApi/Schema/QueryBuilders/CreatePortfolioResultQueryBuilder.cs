using System.Collections.Generic;

namespace MondayApi.Schema {
    public class CreatePortfolioResultQueryBuilder : GraphQlQueryBuilder<CreatePortfolioResultQueryBuilder> {
        private static readonly GraphQlFieldMetadata[] AllFieldMetadata = new[] {
            new GraphQlFieldMetadata { Name = "solution_live_version_id" },
            new GraphQlFieldMetadata { Name = "success" },
            new GraphQlFieldMetadata { Name = "message" }
        };

        protected override string TypeName => "CreatePortfolioResult";
        public override IReadOnlyList<GraphQlFieldMetadata> AllFields => AllFieldMetadata;

        public CreatePortfolioResultQueryBuilder WithSolutionLiveVersionID(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("solution_live_version_id", alias, new GraphQlDirective?[] { include, skip });
        public CreatePortfolioResultQueryBuilder ExceptSolutionLiveVersionID() =>
            ExceptField("solution_live_version_id");
        public CreatePortfolioResultQueryBuilder WithSuccess(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("success", alias, new GraphQlDirective?[] { include, skip });
        public CreatePortfolioResultQueryBuilder ExceptSuccess() =>
            ExceptField("success");
        public CreatePortfolioResultQueryBuilder WithMessage(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("message", alias, new GraphQlDirective?[] { include, skip });
        public CreatePortfolioResultQueryBuilder ExceptMessage() =>
            ExceptField("message");
    }
}
