using System.Collections.Generic;

namespace MondayApi.Schema {
    public class ReplyQueryBuilder : GraphQlQueryBuilder<ReplyQueryBuilder> {
        private static readonly GraphQlFieldMetadata[] AllFieldMetadata = new[] {
            new GraphQlFieldMetadata { Name = "body" },
            new GraphQlFieldMetadata { Name = "created_at" },
            new GraphQlFieldMetadata { Name = "creator", IsComplex = true, QueryBuilderType = typeof(UserQueryBuilder) },
            new GraphQlFieldMetadata { Name = "creator_id" },
            new GraphQlFieldMetadata { Name = "id" },
            new GraphQlFieldMetadata { Name = "text_body" },
            new GraphQlFieldMetadata { Name = "updated_at" }
        };

        protected override string TypeName => "Reply";
        public override IReadOnlyList<GraphQlFieldMetadata> AllFields => AllFieldMetadata;

        public ReplyQueryBuilder WithBody(string alias = null, IncludeDirective include = null, SkipDirective skip = null) =>
            WithScalarField("body", alias, new GraphQlDirective[] { include, skip });
        public ReplyQueryBuilder ExceptBody() =>
            ExceptField("body");
        public ReplyQueryBuilder WithCreatedAt(string alias = null, IncludeDirective include = null, SkipDirective skip = null) =>
            WithScalarField("created_at", alias, new GraphQlDirective[] { include, skip });
        public ReplyQueryBuilder ExceptCreatedAt() =>
            ExceptField("created_at");
        public ReplyQueryBuilder WithCreator(UserQueryBuilder userQueryBuilder, string alias = null, IncludeDirective include = null, SkipDirective skip = null) =>
            WithObjectField("creator", alias, userQueryBuilder, new GraphQlDirective[] { include, skip });
        public ReplyQueryBuilder ExceptCreator() =>
            ExceptField("creator");
        public ReplyQueryBuilder WithCreatorId(string alias = null, IncludeDirective include = null, SkipDirective skip = null) =>
            WithScalarField("creator_id", alias, new GraphQlDirective[] { include, skip });
        public ReplyQueryBuilder ExceptCreatorId() =>
            ExceptField("creator_id");
        public ReplyQueryBuilder WithId(string alias = null, IncludeDirective include = null, SkipDirective skip = null) =>
            WithScalarField("id", alias, new GraphQlDirective[] { include, skip });
        public ReplyQueryBuilder ExceptId() =>
            ExceptField("id");
        public ReplyQueryBuilder WithTextBody(string alias = null, IncludeDirective include = null, SkipDirective skip = null) =>
            WithScalarField("text_body", alias, new GraphQlDirective[] { include, skip });
        public ReplyQueryBuilder ExceptTextBody() =>
            ExceptField("text_body");
        public ReplyQueryBuilder WithUpdatedAt(string alias = null, IncludeDirective include = null, SkipDirective skip = null) =>
            WithScalarField("updated_at", alias, new GraphQlDirective[] { include, skip });
        public ReplyQueryBuilder ExceptUpdatedAt() =>
            ExceptField("updated_at");
    }
}
