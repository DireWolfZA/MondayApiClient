using System.Collections.Generic;

namespace MondayApi.Schema {
    public class ComplexityQueryBuilder : GraphQlQueryBuilder<ComplexityQueryBuilder> {
        private static readonly GraphQlFieldMetadata[] AllFieldMetadata = new[] {
            new GraphQlFieldMetadata { Name = "after" },
            new GraphQlFieldMetadata { Name = "before" },
            new GraphQlFieldMetadata { Name = "query" },
            new GraphQlFieldMetadata { Name = "reset_in_x_seconds" }
        };

        protected override string TypeName { get { return "Complexity"; } }

        public override IReadOnlyList<GraphQlFieldMetadata> AllFields { get { return AllFieldMetadata; } }

        public ComplexityQueryBuilder WithAfter(string alias = null, IncludeDirective include = null, SkipDirective skip = null) {
            return WithScalarField("after", alias, new GraphQlDirective[] { include, skip });
        }

        public ComplexityQueryBuilder ExceptAfter() {
            return ExceptField("after");
        }

        public ComplexityQueryBuilder WithBefore(string alias = null, IncludeDirective include = null, SkipDirective skip = null) {
            return WithScalarField("before", alias, new GraphQlDirective[] { include, skip });
        }

        public ComplexityQueryBuilder ExceptBefore() {
            return ExceptField("before");
        }

        public ComplexityQueryBuilder WithQuery(string alias = null, IncludeDirective include = null, SkipDirective skip = null) {
            return WithScalarField("query", alias, new GraphQlDirective[] { include, skip });
        }

        public ComplexityQueryBuilder ExceptQuery() {
            return ExceptField("query");
        }

        public ComplexityQueryBuilder WithResetInXSeconds(string alias = null, IncludeDirective include = null, SkipDirective skip = null) {
            return WithScalarField("reset_in_x_seconds", alias, new GraphQlDirective[] { include, skip });
        }

        public ComplexityQueryBuilder ExceptResetInXSeconds() {
            return ExceptField("reset_in_x_seconds");
        }
    }
}
