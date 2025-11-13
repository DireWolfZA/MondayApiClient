using System.Collections.Generic;

namespace MondayApi.Schema {
    public class DocBlocksFromMarkdownResultQueryBuilder : GraphQlQueryBuilder<DocBlocksFromMarkdownResultQueryBuilder> {
        private static readonly GraphQlFieldMetadata[] AllFieldMetadata = new[] {
            new GraphQlFieldMetadata { Name = "success" },
            new GraphQlFieldMetadata { Name = "block_ids", IsComplex = true },
            new GraphQlFieldMetadata { Name = "error" }
        };

        protected override string TypeName => "DocBlocksFromMarkdownResult";
        public override IReadOnlyList<GraphQlFieldMetadata> AllFields => AllFieldMetadata;

        public DocBlocksFromMarkdownResultQueryBuilder WithSuccess(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("success", alias, new GraphQlDirective?[] { include, skip });
        public DocBlocksFromMarkdownResultQueryBuilder ExceptSuccess() =>
            ExceptField("success");
        public DocBlocksFromMarkdownResultQueryBuilder WithBlockIDs(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("block_ids", alias, new GraphQlDirective?[] { include, skip });
        public DocBlocksFromMarkdownResultQueryBuilder ExceptBlockIds() =>
            ExceptField("block_ids");
        public DocBlocksFromMarkdownResultQueryBuilder WithError(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("error", alias, new GraphQlDirective?[] { include, skip });
        public DocBlocksFromMarkdownResultQueryBuilder ExceptError() =>
            ExceptField("error");
    }
}
