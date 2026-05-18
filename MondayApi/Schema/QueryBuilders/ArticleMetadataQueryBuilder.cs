using System.Collections.Generic;

namespace MondayApi.Schema {
    public class ArticleMetadataQueryBuilder : GraphQlQueryBuilder<ArticleMetadataQueryBuilder> {
        private static readonly GraphQlFieldMetadata[] AllFieldMetadata = new[] {
            new GraphQlFieldMetadata { Name = "object_id" },
            new GraphQlFieldMetadata { Name = "draft_article_id" },
            new GraphQlFieldMetadata { Name = "published_article_id" },
            new GraphQlFieldMetadata { Name = "name" },
            new GraphQlFieldMetadata { Name = "privacy_kind" },
            new GraphQlFieldMetadata { Name = "workspace_id" },
            new GraphQlFieldMetadata { Name = "folder_id" },
            new GraphQlFieldMetadata { Name = "updated_at" },
            new GraphQlFieldMetadata { Name = "state" },
            new GraphQlFieldMetadata { Name = "creator" },
            new GraphQlFieldMetadata { Name = "owners", IsComplex = true, QueryBuilderType = typeof(UserQueryBuilder) },
            new GraphQlFieldMetadata { Name = "subscribers", IsComplex = true, QueryBuilderType = typeof(UserQueryBuilder) }
        };

        protected override string TypeName => "ArticleMetadata";
        public override IReadOnlyList<GraphQlFieldMetadata> AllFields => AllFieldMetadata;

        public ArticleMetadataQueryBuilder WithObjectID(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("object_id", alias, new GraphQlDirective?[] { include, skip });
        public ArticleMetadataQueryBuilder ExceptObjectID() =>
            ExceptField("object_id");
        public ArticleMetadataQueryBuilder WithDraftArticleID(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("draft_article_id", alias, new GraphQlDirective?[] { include, skip });
        public ArticleMetadataQueryBuilder ExceptDraftArticleID() =>
            ExceptField("draft_article_id");
        public ArticleMetadataQueryBuilder WithPublishedArticleID(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("published_article_id", alias, new GraphQlDirective?[] { include, skip });
        public ArticleMetadataQueryBuilder ExceptPublishedArticleID() =>
            ExceptField("published_article_id");
        public ArticleMetadataQueryBuilder WithName(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("name", alias, new GraphQlDirective?[] { include, skip });
        public ArticleMetadataQueryBuilder ExceptName() =>
            ExceptField("name");
        public ArticleMetadataQueryBuilder WithPrivacyKind(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("privacy_kind", alias, new GraphQlDirective?[] { include, skip });
        public ArticleMetadataQueryBuilder ExceptPrivacyKind() =>
            ExceptField("privacy_kind");
        public ArticleMetadataQueryBuilder WithWorkspaceID(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("workspace_id", alias, new GraphQlDirective?[] { include, skip });
        public ArticleMetadataQueryBuilder ExceptWorkspaceID() =>
            ExceptField("workspace_id");
        public ArticleMetadataQueryBuilder WithFolderID(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("folder_id", alias, new GraphQlDirective?[] { include, skip });
        public ArticleMetadataQueryBuilder ExceptFolderID() =>
            ExceptField("folder_id");
        public ArticleMetadataQueryBuilder WithUpdatedAt(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("updated_at", alias, new GraphQlDirective?[] { include, skip });
        public ArticleMetadataQueryBuilder ExceptUpdatedAt() =>
            ExceptField("updated_at");
        public ArticleMetadataQueryBuilder WithState(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("state", alias, new GraphQlDirective?[] { include, skip });
        public ArticleMetadataQueryBuilder ExceptState() =>
            ExceptField("state");
        public ArticleMetadataQueryBuilder WithCreator(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("creator", alias, new GraphQlDirective?[] { include, skip });
        public ArticleMetadataQueryBuilder ExceptCreator() =>
            ExceptField("creator");
        public ArticleMetadataQueryBuilder WithOwners(UserQueryBuilder userQueryBuilder, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithObjectField("owners", alias, userQueryBuilder, new GraphQlDirective?[] { include, skip });
        public ArticleMetadataQueryBuilder ExceptOwners() =>
            ExceptField("owners");
        public ArticleMetadataQueryBuilder WithSubscribers(UserQueryBuilder userQueryBuilder, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithObjectField("subscribers", alias, userQueryBuilder, new GraphQlDirective?[] { include, skip });
        public ArticleMetadataQueryBuilder ExceptSubscribers() =>
            ExceptField("subscribers");
    }
}
