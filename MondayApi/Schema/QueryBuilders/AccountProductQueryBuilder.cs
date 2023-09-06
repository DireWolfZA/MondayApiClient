using System.Collections.Generic;

namespace MondayApi.Schema {
    public class AccountProductQueryBuilder : GraphQlQueryBuilder<AccountProductQueryBuilder> {
        private static readonly GraphQlFieldMetadata[] AllFieldMetadata = new[] {
            new GraphQlFieldMetadata { Name = "id" },
            new GraphQlFieldMetadata { Name = "kind" }
        };

        protected override string TypeName => "AccountProduct";
        public override IReadOnlyList<GraphQlFieldMetadata> AllFields => AllFieldMetadata;

        public AccountProductQueryBuilder WithID(string alias = null, IncludeDirective include = null, SkipDirective skip = null) =>
            WithScalarField("id", alias, new GraphQlDirective[] { include, skip });
        public AccountProductQueryBuilder ExceptID() =>
            ExceptField("id");
        public AccountProductQueryBuilder WithKind(string alias = null, IncludeDirective include = null, SkipDirective skip = null) =>
            WithScalarField("kind", alias, new GraphQlDirective[] { include, skip });
        public AccountProductQueryBuilder ExceptKind() =>
            ExceptField("kind");
    }
}
