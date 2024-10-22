using System.Collections.Generic;

namespace MondayApi.Schema {
    public class UpdateQueryBuilder : GraphQlQueryBuilder<UpdateQueryBuilder> {
        private static readonly GraphQlFieldMetadata[] AllFieldMetadata = new[] {
            new GraphQlFieldMetadata { Name = "assets", IsComplex = true, QueryBuilderType = typeof(AssetQueryBuilder) },
            new GraphQlFieldMetadata { Name = "body" },
            new GraphQlFieldMetadata { Name = "edited_at", IsComplex = true },
            new GraphQlFieldMetadata { Name = "likes", IsComplex = true, QueryBuilderType = typeof(LikeQueryBuilder) },
            new GraphQlFieldMetadata { Name = "pinned_to_top", IsComplex = true, QueryBuilderType = typeof(UpdatePinQueryBuilder) },
            new GraphQlFieldMetadata { Name = "created_at" },
            new GraphQlFieldMetadata { Name = "creator", IsComplex = true, QueryBuilderType = typeof(UserQueryBuilder) },
            new GraphQlFieldMetadata { Name = "creator_id" },
            new GraphQlFieldMetadata { Name = "id" },
            new GraphQlFieldMetadata { Name = "item_id" },
            new GraphQlFieldMetadata { Name = "item", IsComplex = true, QueryBuilderType = typeof(ItemQueryBuilder) },
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
        public UpdateQueryBuilder WithCreatorID(string alias = null, IncludeDirective include = null, SkipDirective skip = null) =>
            WithScalarField("creator_id", alias, new GraphQlDirective[] { include, skip });
        public UpdateQueryBuilder ExceptCreatorID() =>
            ExceptField("creator_id");
        public UpdateQueryBuilder WithID(string alias = null, IncludeDirective include = null, SkipDirective skip = null) =>
            WithScalarField("id", alias, new GraphQlDirective[] { include, skip });
        public UpdateQueryBuilder ExceptID() =>
            ExceptField("id");
        public UpdateQueryBuilder WithEditedAt(string alias = null, IncludeDirective include = null, SkipDirective skip = null) =>
            WithScalarField("edited_at", alias, new GraphQlDirective[] { include, skip });
        public UpdateQueryBuilder ExceptEditedAt() =>
            ExceptField("edited_at");
        public UpdateQueryBuilder WithLikes(LikeQueryBuilder likeQueryBuilder, string alias = null, IncludeDirective include = null, SkipDirective skip = null) =>
            WithObjectField("likes", alias, likeQueryBuilder, new GraphQlDirective[] { include, skip });
        public UpdateQueryBuilder ExceptLikes() =>
            ExceptField("likes");
        public UpdateQueryBuilder WithPinnedToTop(UpdatePinQueryBuilder updatePinQueryBuilder, string alias = null, IncludeDirective include = null, SkipDirective skip = null) =>
            WithObjectField("pinned_to_top", alias, updatePinQueryBuilder, new GraphQlDirective[] { include, skip });
        public UpdateQueryBuilder ExceptPinnedToTop() =>
            ExceptField("pinned_to_top");
        public UpdateQueryBuilder WithItemID(string alias = null, IncludeDirective include = null, SkipDirective skip = null) =>
            WithScalarField("item_id", alias, new GraphQlDirective[] { include, skip });
        public UpdateQueryBuilder ExceptItemID() =>
            ExceptField("item_id");
        public UpdateQueryBuilder WithItem(ItemQueryBuilder itemQueryBuilder, string alias = null, IncludeDirective include = null, SkipDirective skip = null) =>
            WithObjectField("item", alias, itemQueryBuilder, new GraphQlDirective[] { include, skip });
        public UpdateQueryBuilder ExceptItem() =>
            ExceptField("item");
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
