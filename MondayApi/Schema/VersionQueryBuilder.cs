using System.Collections.Generic;

namespace MondayApi.Schema {
    public class VersionQueryBuilder : GraphQlQueryBuilder<VersionQueryBuilder> {
        private static readonly GraphQlFieldMetadata[] AllFieldMetadata =
            new[]
            {
                new GraphQlFieldMetadata { Name = "kind" },
                new GraphQlFieldMetadata { Name = "value" }
            };

        protected override string TypeName { get { return "Version"; } }

        public override IReadOnlyList<GraphQlFieldMetadata> AllFields { get { return AllFieldMetadata; } }

        public VersionQueryBuilder WithKind(string alias = null, IncludeDirective include = null, SkipDirective skip = null) {
            return WithScalarField("kind", alias, new GraphQlDirective[] { include, skip });
        }

        public VersionQueryBuilder ExceptKind() {
            return ExceptField("kind");
        }

        public VersionQueryBuilder WithValue(string alias = null, IncludeDirective include = null, SkipDirective skip = null) {
            return WithScalarField("value", alias, new GraphQlDirective[] { include, skip });
        }

        public VersionQueryBuilder ExceptValue() {
            return ExceptField("value");
        }
    }
}
