using System.Collections.Generic;

namespace MondayApi.Schema {
    public class DocumentBlockIdOnlyQueryBuilder : GraphQlQueryBuilder<DocumentBlockIdOnlyQueryBuilder> {
        private static readonly GraphQlFieldMetadata[] AllFieldMetadata = new[] {
            new GraphQlFieldMetadata { Name = "id" }
        };

        protected override string TypeName { get { return "DocumentBlockIdOnly"; } }

        public override IReadOnlyList<GraphQlFieldMetadata> AllFields { get { return AllFieldMetadata; } }

        public DocumentBlockIdOnlyQueryBuilder WithId(string alias = null, IncludeDirective include = null, SkipDirective skip = null) {
            return WithScalarField("id", alias, new GraphQlDirective[] { include, skip });
        }

        public DocumentBlockIdOnlyQueryBuilder ExceptId() {
            return ExceptField("id");
        }
    }
}
