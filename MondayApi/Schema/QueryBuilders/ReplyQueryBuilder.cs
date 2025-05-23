using System.Collections.Generic;

namespace MondayApi.Schema {
    public class ReplyQueryBuilder : GraphQlQueryBuilder<ReplyQueryBuilder> {
        private static readonly GraphQlFieldMetadata[] AllFieldMetadata = new[] {
            new GraphQlFieldMetadata { Name = "id" },
            new GraphQlFieldMetadata { Name = "body" },
            new GraphQlFieldMetadata { Name = "kind" },
            new GraphQlFieldMetadata { Name = "creator_id" },
            new GraphQlFieldMetadata { Name = "edited_at" },
            new GraphQlFieldMetadata { Name = "creator", IsComplex = true, QueryBuilderType = typeof(UserQueryBuilder) },
            new GraphQlFieldMetadata { Name = "likes", IsComplex = true, QueryBuilderType = typeof(LikeQueryBuilder) },
            new GraphQlFieldMetadata { Name = "pinned_to_top", IsComplex = true, QueryBuilderType = typeof(UpdatePinQueryBuilder) },
            new GraphQlFieldMetadata { Name = "viewers", IsComplex = true, QueryBuilderType = typeof(WatcherQueryBuilder) },
            new GraphQlFieldMetadata { Name = "created_at" },
            new GraphQlFieldMetadata { Name = "updated_at" },
            new GraphQlFieldMetadata { Name = "text_body" }
        };

        protected override string TypeName => "Reply";
        public override IReadOnlyList<GraphQlFieldMetadata> AllFields => AllFieldMetadata;

        public ReplyQueryBuilder WithViewers(WatcherQueryBuilder watcherQueryBuilder, QueryBuilderParameter<int?>? limit = null, QueryBuilderParameter<int?>? page = null, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) {
            var args = new List<QueryBuilderArgumentInfo>();
            if (limit != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "limit", ArgumentValue = limit });
            if (page != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "page", ArgumentValue = page });
            return WithObjectField("viewers", alias, watcherQueryBuilder, new GraphQlDirective?[] { include, skip }, args);
        }

        public ReplyQueryBuilder WithID(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("id", alias, new GraphQlDirective?[] { include, skip });
        public ReplyQueryBuilder ExceptID() =>
            ExceptField("id");
        public ReplyQueryBuilder WithBody(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("body", alias, new GraphQlDirective?[] { include, skip });
        public ReplyQueryBuilder ExceptBody() =>
            ExceptField("body");
        public ReplyQueryBuilder WithKind(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("kind", alias, new GraphQlDirective?[] { include, skip });
        public ReplyQueryBuilder ExceptKind() =>
            ExceptField("kind");
        public ReplyQueryBuilder WithCreatorID(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("creator_id", alias, new GraphQlDirective?[] { include, skip });
        public ReplyQueryBuilder ExceptCreatorID() =>
            ExceptField("creator_id");
        public ReplyQueryBuilder WithEditedAt(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("edited_at", alias, new GraphQlDirective?[] { include, skip });
        public ReplyQueryBuilder ExceptEditedAt() =>
            ExceptField("edited_at");
        public ReplyQueryBuilder WithCreator(UserQueryBuilder userQueryBuilder, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithObjectField("creator", alias, userQueryBuilder, new GraphQlDirective?[] { include, skip });
        public ReplyQueryBuilder ExceptCreator() =>
            ExceptField("creator");
        public ReplyQueryBuilder WithLikes(LikeQueryBuilder likeQueryBuilder, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithObjectField("likes", alias, likeQueryBuilder, new GraphQlDirective?[] { include, skip });
        public ReplyQueryBuilder ExceptLikes() =>
            ExceptField("likes");
        public ReplyQueryBuilder WithPinnedToTop(UpdatePinQueryBuilder updatePinQueryBuilder, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithObjectField("pinned_to_top", alias, updatePinQueryBuilder, new GraphQlDirective?[] { include, skip });
        public ReplyQueryBuilder ExceptPinnedToTop() =>
            ExceptField("pinned_to_top");
        public ReplyQueryBuilder ExceptViewers() =>
            ExceptField("viewers");
        public ReplyQueryBuilder WithCreatedAt(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("created_at", alias, new GraphQlDirective?[] { include, skip });
        public ReplyQueryBuilder ExceptCreatedAt() =>
            ExceptField("created_at");
        public ReplyQueryBuilder WithUpdatedAt(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("updated_at", alias, new GraphQlDirective?[] { include, skip });
        public ReplyQueryBuilder ExceptUpdatedAt() =>
            ExceptField("updated_at");
        public ReplyQueryBuilder WithTextBody(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("text_body", alias, new GraphQlDirective?[] { include, skip });
        public ReplyQueryBuilder ExceptTextBody() =>
            ExceptField("text_body");
    }
}
