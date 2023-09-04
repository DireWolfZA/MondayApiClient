using System.Collections.Generic;

namespace MondayApi.Schema {
    public class ComplexityQueryBuilder : GraphQlQueryBuilder<ComplexityQueryBuilder> {
        private static readonly GraphQlFieldMetadata[] AllFieldMetadata = new[] {
            new GraphQlFieldMetadata { Name = "after" },
            new GraphQlFieldMetadata { Name = "before" },
            new GraphQlFieldMetadata { Name = "query" },
            new GraphQlFieldMetadata { Name = "reset_in_x_seconds" }
        };

        protected override string TypeName => "Complexity";
        public override IReadOnlyList<GraphQlFieldMetadata> AllFields => AllFieldMetadata;

        public ComplexityQueryBuilder WithAfter(string alias = null, IncludeDirective include = null, SkipDirective skip = null) =>
            WithScalarField("after", alias, new GraphQlDirective[] { include, skip });
        public ComplexityQueryBuilder ExceptAfter() =>
            ExceptField("after");
        public ComplexityQueryBuilder WithBefore(string alias = null, IncludeDirective include = null, SkipDirective skip = null) =>
            WithScalarField("before", alias, new GraphQlDirective[] { include, skip });
        public ComplexityQueryBuilder ExceptBefore() =>
            ExceptField("before");
        public ComplexityQueryBuilder WithQuery(string alias = null, IncludeDirective include = null, SkipDirective skip = null) =>
            WithScalarField("query", alias, new GraphQlDirective[] { include, skip });
        public ComplexityQueryBuilder ExceptQuery() =>
            ExceptField("query");
        public ComplexityQueryBuilder WithResetInXSeconds(string alias = null, IncludeDirective include = null, SkipDirective skip = null) =>
            WithScalarField("reset_in_x_seconds", alias, new GraphQlDirective[] { include, skip });
        public ComplexityQueryBuilder ExceptResetInXSeconds() =>
            ExceptField("reset_in_x_seconds");
    }
}
