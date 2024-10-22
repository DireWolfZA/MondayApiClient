using System.Collections.Generic;

namespace MondayApi.Schema {
    public class LikeQueryBuilder : GraphQlQueryBuilder<LikeQueryBuilder> {
        private static readonly GraphQlFieldMetadata[] AllFieldMetadata = new[] {
            new GraphQlFieldMetadata { Name = "id" },
            new GraphQlFieldMetadata { Name = "creator_id" },
            new GraphQlFieldMetadata { Name = "creator", IsComplex = true, QueryBuilderType = typeof(UserQueryBuilder) },
            new GraphQlFieldMetadata { Name = "reaction_type" },
            new GraphQlFieldMetadata { Name = "created_at" },
            new GraphQlFieldMetadata { Name = "updated_at" }
        };

        protected override string TypeName => "Like";
        public override IReadOnlyList<GraphQlFieldMetadata> AllFields => AllFieldMetadata;

        public LikeQueryBuilder WithID(string alias = null, IncludeDirective include = null, SkipDirective skip = null) =>
            WithScalarField("id", alias, new GraphQlDirective[] { include, skip });
        public LikeQueryBuilder ExceptID() =>
            ExceptField("id");
        public LikeQueryBuilder WithCreatorID(string alias = null, IncludeDirective include = null, SkipDirective skip = null) =>
            WithScalarField("creator_id", alias, new GraphQlDirective[] { include, skip });
        public LikeQueryBuilder ExceptCreatorID() =>
            ExceptField("creator_id");
        public LikeQueryBuilder WithCreator(UserQueryBuilder userQueryBuilder, string alias = null, IncludeDirective include = null, SkipDirective skip = null) =>
            WithObjectField("creator", alias, userQueryBuilder, new GraphQlDirective[] { include, skip });
        public LikeQueryBuilder ExceptCreator() =>
            ExceptField("creator");
        public LikeQueryBuilder WithReactionType(string alias = null, IncludeDirective include = null, SkipDirective skip = null) =>
            WithScalarField("reaction_type", alias, new GraphQlDirective[] { include, skip });
        public LikeQueryBuilder ExceptReactionType() =>
            ExceptField("reaction_type");
        public LikeQueryBuilder WithCreatedAt(string alias = null, IncludeDirective include = null, SkipDirective skip = null) =>
            WithScalarField("created_at", alias, new GraphQlDirective[] { include, skip });
        public LikeQueryBuilder ExceptCreatedAt() =>
            ExceptField("created_at");
        public LikeQueryBuilder WithUpdatedAt(string alias = null, IncludeDirective include = null, SkipDirective skip = null) =>
            WithScalarField("updated_at", alias, new GraphQlDirective[] { include, skip });
        public LikeQueryBuilder ExceptUpdatedAt() =>
            ExceptField("updated_at");
    }
}
