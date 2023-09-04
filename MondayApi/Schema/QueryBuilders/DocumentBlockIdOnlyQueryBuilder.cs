using System.Collections.Generic;

namespace MondayApi.Schema {
    public class DocumentBlockIdOnlyQueryBuilder : GraphQlQueryBuilder<DocumentBlockIdOnlyQueryBuilder> {
        private static readonly GraphQlFieldMetadata[] AllFieldMetadata = new[] {
            new GraphQlFieldMetadata { Name = "id" }
        };

        protected override string TypeName => "DocumentBlockIdOnly";
        public override IReadOnlyList<GraphQlFieldMetadata> AllFields => AllFieldMetadata;

        public DocumentBlockIdOnlyQueryBuilder WithId(string alias = null, IncludeDirective include = null, SkipDirective skip = null) =>
            WithScalarField("id", alias, new GraphQlDirective[] { include, skip });
        public DocumentBlockIdOnlyQueryBuilder ExceptId() =>
            ExceptField("id");
    }
}
