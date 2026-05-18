using System.Collections.Generic;

namespace MondayApi.Schema {
    public class DependencyColumnConfigResultQueryBuilder : GraphQlQueryBuilder<DependencyColumnConfigResultQueryBuilder> {
        private static readonly GraphQlFieldMetadata[] AllFieldMetadata = new[] {
            new GraphQlFieldMetadata { Name = "board_id" },
            new GraphQlFieldMetadata { Name = "dependency_columns", IsComplex = true, QueryBuilderType = typeof(DependencyColumnConfigQueryBuilder) }
        };

        protected override string TypeName => "DependencyColumnConfigResult";
        public override IReadOnlyList<GraphQlFieldMetadata> AllFields => AllFieldMetadata;

        public DependencyColumnConfigResultQueryBuilder WithBoardID(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("board_id", alias, new GraphQlDirective?[] { include, skip });
        public DependencyColumnConfigResultQueryBuilder ExceptBoardID() =>
            ExceptField("board_id");
        public DependencyColumnConfigResultQueryBuilder WithDependencyColumns(DependencyColumnConfigQueryBuilder dependencyColumnConfigQueryBuilder, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithObjectField("dependency_columns", alias, dependencyColumnConfigQueryBuilder, new GraphQlDirective?[] { include, skip });
        public DependencyColumnConfigResultQueryBuilder ExceptDependencyColumns() =>
            ExceptField("dependency_columns");
    }
}
