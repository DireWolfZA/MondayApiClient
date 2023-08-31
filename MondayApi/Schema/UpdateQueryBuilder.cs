using System.Collections.Generic;

namespace MondayApi.Schema {
    public class UpdateQueryBuilder : GraphQlQueryBuilder<UpdateQueryBuilder> {
        private static readonly GraphQlFieldMetadata[] AllFieldMetadata =
            new[]
            {
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

        protected override string TypeName { get { return "Update"; } }

        public override IReadOnlyList<GraphQlFieldMetadata> AllFields { get { return AllFieldMetadata; } }

        public UpdateQueryBuilder WithAssets(AssetQueryBuilder assetQueryBuilder, string alias = null, IncludeDirective include = null, SkipDirective skip = null) {
            return WithObjectField("assets", alias, assetQueryBuilder, new GraphQlDirective[] { include, skip });
        }

        public UpdateQueryBuilder ExceptAssets() {
            return ExceptField("assets");
        }

        public UpdateQueryBuilder WithBody(string alias = null, IncludeDirective include = null, SkipDirective skip = null) {
            return WithScalarField("body", alias, new GraphQlDirective[] { include, skip });
        }

        public UpdateQueryBuilder ExceptBody() {
            return ExceptField("body");
        }

        public UpdateQueryBuilder WithCreatedAt(string alias = null, IncludeDirective include = null, SkipDirective skip = null) {
            return WithScalarField("created_at", alias, new GraphQlDirective[] { include, skip });
        }

        public UpdateQueryBuilder ExceptCreatedAt() {
            return ExceptField("created_at");
        }

        public UpdateQueryBuilder WithCreator(UserQueryBuilder userQueryBuilder, string alias = null, IncludeDirective include = null, SkipDirective skip = null) {
            return WithObjectField("creator", alias, userQueryBuilder, new GraphQlDirective[] { include, skip });
        }

        public UpdateQueryBuilder ExceptCreator() {
            return ExceptField("creator");
        }

        public UpdateQueryBuilder WithCreatorId(string alias = null, IncludeDirective include = null, SkipDirective skip = null) {
            return WithScalarField("creator_id", alias, new GraphQlDirective[] { include, skip });
        }

        public UpdateQueryBuilder ExceptCreatorId() {
            return ExceptField("creator_id");
        }

        public UpdateQueryBuilder WithId(string alias = null, IncludeDirective include = null, SkipDirective skip = null) {
            return WithScalarField("id", alias, new GraphQlDirective[] { include, skip });
        }

        public UpdateQueryBuilder ExceptId() {
            return ExceptField("id");
        }

        public UpdateQueryBuilder WithItemId(string alias = null, IncludeDirective include = null, SkipDirective skip = null) {
            return WithScalarField("item_id", alias, new GraphQlDirective[] { include, skip });
        }

        public UpdateQueryBuilder ExceptItemId() {
            return ExceptField("item_id");
        }

        public UpdateQueryBuilder WithReplies(ReplyQueryBuilder replyQueryBuilder, string alias = null, IncludeDirective include = null, SkipDirective skip = null) {
            return WithObjectField("replies", alias, replyQueryBuilder, new GraphQlDirective[] { include, skip });
        }

        public UpdateQueryBuilder ExceptReplies() {
            return ExceptField("replies");
        }

        public UpdateQueryBuilder WithTextBody(string alias = null, IncludeDirective include = null, SkipDirective skip = null) {
            return WithScalarField("text_body", alias, new GraphQlDirective[] { include, skip });
        }

        public UpdateQueryBuilder ExceptTextBody() {
            return ExceptField("text_body");
        }

        public UpdateQueryBuilder WithUpdatedAt(string alias = null, IncludeDirective include = null, SkipDirective skip = null) {
            return WithScalarField("updated_at", alias, new GraphQlDirective[] { include, skip });
        }

        public UpdateQueryBuilder ExceptUpdatedAt() {
            return ExceptField("updated_at");
        }
    }
}
