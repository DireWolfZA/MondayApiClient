using System.Collections.Generic;

namespace MondayApi.Schema {
    public class UpdateOverviewHierarchyQueryBuilder : GraphQlQueryBuilder<UpdateOverviewHierarchyQueryBuilder> {
        private static readonly GraphQlFieldMetadata[] AllFieldMetadata = new[] {
            new GraphQlFieldMetadata { Name = "message" },
            new GraphQlFieldMetadata { Name = "overview", IsComplex = true, QueryBuilderType = typeof(OverviewQueryBuilder) },
            new GraphQlFieldMetadata { Name = "success" }
        };

        protected override string TypeName => "UpdateOverviewHierarchy";
        public override IReadOnlyList<GraphQlFieldMetadata> AllFields => AllFieldMetadata;

        public UpdateOverviewHierarchyQueryBuilder WithMessage(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("message", alias, new GraphQlDirective?[] { include, skip });
        public UpdateOverviewHierarchyQueryBuilder ExceptMessage() =>
            ExceptField("message");
        public UpdateOverviewHierarchyQueryBuilder WithOverview(OverviewQueryBuilder overviewQueryBuilder, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithObjectField("overview", alias, overviewQueryBuilder, new GraphQlDirective?[] { include, skip });
        public UpdateOverviewHierarchyQueryBuilder ExceptOverview() =>
            ExceptField("overview");
        public UpdateOverviewHierarchyQueryBuilder WithSuccess(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("success", alias, new GraphQlDirective?[] { include, skip });
        public UpdateOverviewHierarchyQueryBuilder ExceptSuccess() =>
            ExceptField("success");
    }
}
