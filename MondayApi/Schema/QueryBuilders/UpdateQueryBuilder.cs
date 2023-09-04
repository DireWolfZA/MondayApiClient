using System.Collections.Generic;

namespace MondayApi.Schema {
    public class UpdateQueryBuilder : GraphQlQueryBuilder<UpdateQueryBuilder> {
        private static readonly GraphQlFieldMetadata[] AllFieldMetadata = new[] {
            new GraphQlFieldMetadata { Name = "assets", IsComplex = true, QueryBuilderType = typeof(AssetQueryBuilder) },
            new GraphQlFieldMetadata { Name = "body" },
            new GraphQlFieldMetadata { Name = "created_at" },
            new GraphQlFieldMetadata { Name = "creator", IsComplex = true, QueryBuilderType = typeof(UserQueryBuilder) },
            new GraphQlFieldMetadata { Name = "creator_id" },
            new GraphQlFieldMetadata { Name = "id" },
            new GraphQlFieldMetadata { Name = "item_id" },
            new GraphQlFieldMetadata { Name = "replies", IsComplex = true, QueryBuilderType = typeof(ReplyQueryBuilder) },
            new GraphQlFieldMetadata { Name = "text_body" },
            new GraphQlFieldMetadata { Name = "updated_at" }
        };

        protected override string TypeName => "Update";
        public override IReadOnlyList<GraphQlFieldMetadata> AllFields => AllFieldMetadata;

        public UpdateQueryBuilder WithAssets(AssetQueryBuilder assetQueryBuilder, string alias = null, IncludeDirective include = null, SkipDirective skip = null) =>
            WithObjectField("assets", alias, assetQueryBuilder, new GraphQlDirective[] { include, skip });
        public UpdateQueryBuilder ExceptAssets() =>
            ExceptField("assets");
        public UpdateQueryBuilder WithBody(string alias = null, IncludeDirective include = null, SkipDirective skip = null) =>
            WithScalarField("body", alias, new GraphQlDirective[] { include, skip });
        public UpdateQueryBuilder ExceptBody() =>
            ExceptField("body");
        public UpdateQueryBuilder WithCreatedAt(string alias = null, IncludeDirective include = null, SkipDirective skip = null) =>
            WithScalarField("created_at", alias, new GraphQlDirective[] { include, skip });
        public UpdateQueryBuilder ExceptCreatedAt() =>
            ExceptField("created_at");
        public UpdateQueryBuilder WithCreator(UserQueryBuilder userQueryBuilder, string alias = null, IncludeDirective include = null, SkipDirective skip = null) =>
            WithObjectField("creator", alias, userQueryBuilder, new GraphQlDirective[] { include, skip });
        public UpdateQueryBuilder ExceptCreator() =>
            ExceptField("creator");
        public UpdateQueryBuilder WithCreatorId(string alias = null, IncludeDirective include = null, SkipDirective skip = null) =>
            WithScalarField("creator_id", alias, new GraphQlDirective[] { include, skip });
        public UpdateQueryBuilder ExceptCreatorId() =>
            ExceptField("creator_id");
        public UpdateQueryBuilder WithId(string alias = null, IncludeDirective include = null, SkipDirective skip = null) =>
            WithScalarField("id", alias, new GraphQlDirective[] { include, skip });
        public UpdateQueryBuilder ExceptId() =>
            ExceptField("id");
        public UpdateQueryBuilder WithItemId(string alias = null, IncludeDirective include = null, SkipDirective skip = null) =>
            WithScalarField("item_id", alias, new GraphQlDirective[] { include, skip });
        public UpdateQueryBuilder ExceptItemId() =>
            ExceptField("item_id");
        public UpdateQueryBuilder WithReplies(ReplyQueryBuilder replyQueryBuilder, string alias = null, IncludeDirective include = null, SkipDirective skip = null) =>
            WithObjectField("replies", alias, replyQueryBuilder, new GraphQlDirective[] { include, skip });
        public UpdateQueryBuilder ExceptReplies() =>
            ExceptField("replies");
        public UpdateQueryBuilder WithTextBody(string alias = null, IncludeDirective include = null, SkipDirective skip = null) =>
            WithScalarField("text_body", alias, new GraphQlDirective[] { include, skip });
        public UpdateQueryBuilder ExceptTextBody() =>
            ExceptField("text_body");
        public UpdateQueryBuilder WithUpdatedAt(string alias = null, IncludeDirective include = null, SkipDirective skip = null) =>
            WithScalarField("updated_at", alias, new GraphQlDirective[] { include, skip });
        public UpdateQueryBuilder ExceptUpdatedAt() =>
            ExceptField("updated_at");
    }
}
