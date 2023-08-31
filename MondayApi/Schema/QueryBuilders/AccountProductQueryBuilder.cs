using System.Collections.Generic;

namespace MondayApi.Schema {
    public class AccountProductQueryBuilder : GraphQlQueryBuilder<AccountProductQueryBuilder> {
        private static readonly GraphQlFieldMetadata[] AllFieldMetadata = new[] {
            new GraphQlFieldMetadata { Name = "id" },
            new GraphQlFieldMetadata { Name = "kind" }
        };

        protected override string TypeName { get { return "AccountProduct"; } }

        public override IReadOnlyList<GraphQlFieldMetadata> AllFields { get { return AllFieldMetadata; } }

        public AccountProductQueryBuilder WithId(string alias = null, IncludeDirective include = null, SkipDirective skip = null) {
            return WithScalarField("id", alias, new GraphQlDirective[] { include, skip });
        }

        public AccountProductQueryBuilder ExceptId() {
            return ExceptField("id");
        }

        public AccountProductQueryBuilder WithKind(string alias = null, IncludeDirective include = null, SkipDirective skip = null) {
            return WithScalarField("kind", alias, new GraphQlDirective[] { include, skip });
        }

        public AccountProductQueryBuilder ExceptKind() {
            return ExceptField("kind");
        }
    }
}
