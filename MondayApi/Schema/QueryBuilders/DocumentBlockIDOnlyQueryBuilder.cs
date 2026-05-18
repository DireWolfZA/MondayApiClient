using System.Collections.Generic;

namespace MondayApi.Schema {
    public class DocumentBlockIDOnlyQueryBuilder : GraphQlQueryBuilder<DocumentBlockIDOnlyQueryBuilder> {
        private static readonly GraphQlFieldMetadata[] AllFieldMetadata = new[] {
            new GraphQlFieldMetadata { Name = "id" }
        };

        protected override string TypeName => "DocumentBlockIdOnly";
        public override IReadOnlyList<GraphQlFieldMetadata> AllFields => AllFieldMetadata;

        public DocumentBlockIDOnlyQueryBuilder WithID(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("id", alias, new GraphQlDirective?[] { include, skip });
        public DocumentBlockIDOnlyQueryBuilder ExceptID() =>
            ExceptField("id");
    }
}
