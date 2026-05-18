using System.Collections.Generic;

namespace MondayApi.Schema {
    public class ArticleQueryBuilder : GraphQlQueryBuilder<ArticleQueryBuilder> {
        private static readonly GraphQlFieldMetadata[] AllFieldMetadata = new[] {
            new GraphQlFieldMetadata { Name = "metadata", IsComplex = true, QueryBuilderType = typeof(ArticleMetadataQueryBuilder) },
            new GraphQlFieldMetadata { Name = "blocks", IsComplex = true, QueryBuilderType = typeof(ArticleBlockQueryBuilder) }
        };

        protected override string TypeName => "Article";
        public override IReadOnlyList<GraphQlFieldMetadata> AllFields => AllFieldMetadata;

        public ArticleQueryBuilder WithMetadata(ArticleMetadataQueryBuilder articleMetadataQueryBuilder, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithObjectField("metadata", alias, articleMetadataQueryBuilder, new GraphQlDirective?[] { include, skip });
        public ArticleQueryBuilder ExceptMetadata() =>
            ExceptField("metadata");
        public ArticleQueryBuilder WithBlocks(ArticleBlockQueryBuilder articleBlockQueryBuilder, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithObjectField("blocks", alias, articleBlockQueryBuilder, new GraphQlDirective?[] { include, skip });
        public ArticleQueryBuilder ExceptBlocks() =>
            ExceptField("blocks");
    }
}
