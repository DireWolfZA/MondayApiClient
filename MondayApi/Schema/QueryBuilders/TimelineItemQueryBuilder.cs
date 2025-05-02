using System.Collections.Generic;

namespace MondayApi.Schema {
    public class TimelineItemQueryBuilder : GraphQlQueryBuilder<TimelineItemQueryBuilder> {
        private static readonly GraphQlFieldMetadata[] AllFieldMetadata = new[] {
            new GraphQlFieldMetadata { Name = "id" },
            new GraphQlFieldMetadata { Name = "type" },
            new GraphQlFieldMetadata { Name = "item", IsComplex = true, QueryBuilderType = typeof(ItemQueryBuilder) },
            new GraphQlFieldMetadata { Name = "board", IsComplex = true, QueryBuilderType = typeof(BoardQueryBuilder) },
            new GraphQlFieldMetadata { Name = "user", IsComplex = true, QueryBuilderType = typeof(UserQueryBuilder) },
            new GraphQlFieldMetadata { Name = "title" },
            new GraphQlFieldMetadata { Name = "custom_activity_id" }
        };

        protected override string TypeName => "TimelineItem";
        public override IReadOnlyList<GraphQlFieldMetadata> AllFields => AllFieldMetadata;

        public TimelineItemQueryBuilder WithID(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("id", alias, new GraphQlDirective?[] { include, skip });
        public TimelineItemQueryBuilder ExceptID() =>
            ExceptField("id");
        public TimelineItemQueryBuilder WithType(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("type", alias, new GraphQlDirective?[] { include, skip });
        public TimelineItemQueryBuilder ExceptType() =>
            ExceptField("type");
        public TimelineItemQueryBuilder WithItem(ItemQueryBuilder itemQueryBuilder, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithObjectField("item", alias, itemQueryBuilder, new GraphQlDirective?[] { include, skip });
        public TimelineItemQueryBuilder ExceptItem() =>
            ExceptField("item");
        public TimelineItemQueryBuilder WithBoard(BoardQueryBuilder boardQueryBuilder, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithObjectField("board", alias, boardQueryBuilder, new GraphQlDirective?[] { include, skip });
        public TimelineItemQueryBuilder ExceptBoard() =>
            ExceptField("board");
        public TimelineItemQueryBuilder WithUser(UserQueryBuilder userQueryBuilder, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithObjectField("user", alias, userQueryBuilder, new GraphQlDirective?[] { include, skip });
        public TimelineItemQueryBuilder ExceptUser() =>
            ExceptField("user");
        public TimelineItemQueryBuilder WithTitle(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("title", alias, new GraphQlDirective?[] { include, skip });
        public TimelineItemQueryBuilder ExceptTitle() =>
            ExceptField("title");
        public TimelineItemQueryBuilder WithCustomActivityID(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("custom_activity_id", alias, new GraphQlDirective?[] { include, skip });
        public TimelineItemQueryBuilder ExceptCustomActivityID() =>
            ExceptField("custom_activity_id");
    }
}
