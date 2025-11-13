using System.Collections.Generic;

namespace MondayApi.Schema {
    public class ArticleBlockQueryBuilder : GraphQlQueryBuilder<ArticleBlockQueryBuilder> {
        private static readonly GraphQlFieldMetadata[] AllFieldMetadata = new[] {
            new GraphQlFieldMetadata { Name = "id" },
            new GraphQlFieldMetadata { Name = "content" },
            new GraphQlFieldMetadata { Name = "created_at" },
            new GraphQlFieldMetadata { Name = "created_by", IsComplex = true, QueryBuilderType = typeof(UserQueryBuilder) },
            new GraphQlFieldMetadata { Name = "published_article_id" },
            new GraphQlFieldMetadata { Name = "parent_block_id" },
            new GraphQlFieldMetadata { Name = "position" },
            new GraphQlFieldMetadata { Name = "type" },
            new GraphQlFieldMetadata { Name = "updated_at" }
        };

        protected override string TypeName => "ArticleBlock";
        public override IReadOnlyList<GraphQlFieldMetadata> AllFields => AllFieldMetadata;

        public ArticleBlockQueryBuilder WithID(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("id", alias, new GraphQlDirective?[] { include, skip });
        public ArticleBlockQueryBuilder ExceptID() =>
            ExceptField("id");
        public ArticleBlockQueryBuilder WithContent(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("content", alias, new GraphQlDirective?[] { include, skip });
        public ArticleBlockQueryBuilder ExceptContent() =>
            ExceptField("content");
        public ArticleBlockQueryBuilder WithCreatedAt(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("created_at", alias, new GraphQlDirective?[] { include, skip });
        public ArticleBlockQueryBuilder ExceptCreatedAt() =>
            ExceptField("created_at");
        public ArticleBlockQueryBuilder WithCreatedBy(UserQueryBuilder userQueryBuilder, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithObjectField("created_by", alias, userQueryBuilder, new GraphQlDirective?[] { include, skip });
        public ArticleBlockQueryBuilder ExceptCreatedBy() =>
            ExceptField("created_by");
        public ArticleBlockQueryBuilder WithPublishedArticleID(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("published_article_id", alias, new GraphQlDirective?[] { include, skip });
        public ArticleBlockQueryBuilder ExceptPublishedArticleID() =>
            ExceptField("published_article_id");
        public ArticleBlockQueryBuilder WithParentBlockID(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("parent_block_id", alias, new GraphQlDirective?[] { include, skip });
        public ArticleBlockQueryBuilder ExceptParentBlockID() =>
            ExceptField("parent_block_id");
        public ArticleBlockQueryBuilder WithPosition(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("position", alias, new GraphQlDirective?[] { include, skip });
        public ArticleBlockQueryBuilder ExceptPosition() =>
            ExceptField("position");
        public ArticleBlockQueryBuilder WithType(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("type", alias, new GraphQlDirective?[] { include, skip });
        public ArticleBlockQueryBuilder ExceptType() =>
            ExceptField("type");
        public ArticleBlockQueryBuilder WithUpdatedAt(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("updated_at", alias, new GraphQlDirective?[] { include, skip });
        public ArticleBlockQueryBuilder ExceptUpdatedAt() =>
            ExceptField("updated_at");
    }
}
