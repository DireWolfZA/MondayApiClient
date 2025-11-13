using System.Collections.Generic;

namespace MondayApi.Schema {
    public class NotificationV2QueryBuilder : GraphQlQueryBuilder<NotificationV2QueryBuilder> {
        private static readonly GraphQlFieldMetadata[] AllFieldMetadata = new[] {
            new GraphQlFieldMetadata { Name = "id" },
            new GraphQlFieldMetadata { Name = "created_at" },
            new GraphQlFieldMetadata { Name = "title" },
            new GraphQlFieldMetadata { Name = "text" },
            new GraphQlFieldMetadata { Name = "creators", IsComplex = true, QueryBuilderType = typeof(UserQueryBuilder) },
            new GraphQlFieldMetadata { Name = "read" },
            new GraphQlFieldMetadata { Name = "update", IsComplex = true, QueryBuilderType = typeof(UpdateQueryBuilder) },
            new GraphQlFieldMetadata { Name = "item", IsComplex = true, QueryBuilderType = typeof(ItemQueryBuilder) },
            new GraphQlFieldMetadata { Name = "board", IsComplex = true, QueryBuilderType = typeof(BoardQueryBuilder) }
        };

        protected override string TypeName => "NotificationV2";
        public override IReadOnlyList<GraphQlFieldMetadata> AllFields => AllFieldMetadata;

        public NotificationV2QueryBuilder WithId(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("id", alias, new GraphQlDirective?[] { include, skip });
        public NotificationV2QueryBuilder ExceptId() =>
            ExceptField("id");
        public NotificationV2QueryBuilder WithCreatedAt(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("created_at", alias, new GraphQlDirective?[] { include, skip });
        public NotificationV2QueryBuilder ExceptCreatedAt() =>
            ExceptField("created_at");
        public NotificationV2QueryBuilder WithTitle(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("title", alias, new GraphQlDirective?[] { include, skip });
        public NotificationV2QueryBuilder ExceptTitle() =>
            ExceptField("title");
        public NotificationV2QueryBuilder WithText(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("text", alias, new GraphQlDirective?[] { include, skip });
        public NotificationV2QueryBuilder ExceptText() =>
            ExceptField("text");
        public NotificationV2QueryBuilder WithCreators(UserQueryBuilder userQueryBuilder, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithObjectField("creators", alias, userQueryBuilder, new GraphQlDirective?[] { include, skip });
        public NotificationV2QueryBuilder ExceptCreators() =>
            ExceptField("creators");
        public NotificationV2QueryBuilder WithRead(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("read", alias, new GraphQlDirective?[] { include, skip });
        public NotificationV2QueryBuilder ExceptRead() =>
            ExceptField("read");
        public NotificationV2QueryBuilder WithUpdate(UpdateQueryBuilder updateQueryBuilder, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithObjectField("update", alias, updateQueryBuilder, new GraphQlDirective?[] { include, skip });
        public NotificationV2QueryBuilder ExceptUpdate() =>
            ExceptField("update");
        public NotificationV2QueryBuilder WithItem(ItemQueryBuilder itemQueryBuilder, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithObjectField("item", alias, itemQueryBuilder, new GraphQlDirective?[] { include, skip });
        public NotificationV2QueryBuilder ExceptItem() =>
            ExceptField("item");
        public NotificationV2QueryBuilder WithBoard(BoardQueryBuilder boardQueryBuilder, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithObjectField("board", alias, boardQueryBuilder, new GraphQlDirective?[] { include, skip });
        public NotificationV2QueryBuilder ExceptBoard() =>
            ExceptField("board");
    }
}
