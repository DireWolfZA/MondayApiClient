using System.Collections.Generic;

namespace MondayApi.Schema {
    public class DocumentBlockQueryBuilder : GraphQlQueryBuilder<DocumentBlockQueryBuilder> {
        private static readonly GraphQlFieldMetadata[] AllFieldMetadata = new[] {
            new GraphQlFieldMetadata { Name = "content", IsComplex = true },
            new GraphQlFieldMetadata { Name = "created_at" },
            new GraphQlFieldMetadata { Name = "created_by", IsComplex = true, QueryBuilderType = typeof(UserQueryBuilder) },
            new GraphQlFieldMetadata { Name = "doc_id" },
            new GraphQlFieldMetadata { Name = "id" },
            new GraphQlFieldMetadata { Name = "parent_block_id" },
            new GraphQlFieldMetadata { Name = "position" },
            new GraphQlFieldMetadata { Name = "type" },
            new GraphQlFieldMetadata { Name = "updated_at" }
        };

        protected override string TypeName { get { return "DocumentBlock"; } }

        public override IReadOnlyList<GraphQlFieldMetadata> AllFields { get { return AllFieldMetadata; } }

        public DocumentBlockQueryBuilder WithContent(string alias = null, IncludeDirective include = null, SkipDirective skip = null) {
            return WithScalarField("content", alias, new GraphQlDirective[] { include, skip });
        }

        public DocumentBlockQueryBuilder ExceptContent() {
            return ExceptField("content");
        }

        public DocumentBlockQueryBuilder WithCreatedAt(string alias = null, IncludeDirective include = null, SkipDirective skip = null) {
            return WithScalarField("created_at", alias, new GraphQlDirective[] { include, skip });
        }

        public DocumentBlockQueryBuilder ExceptCreatedAt() {
            return ExceptField("created_at");
        }

        public DocumentBlockQueryBuilder WithCreatedBy(UserQueryBuilder userQueryBuilder, string alias = null, IncludeDirective include = null, SkipDirective skip = null) {
            return WithObjectField("created_by", alias, userQueryBuilder, new GraphQlDirective[] { include, skip });
        }

        public DocumentBlockQueryBuilder ExceptCreatedBy() {
            return ExceptField("created_by");
        }

        public DocumentBlockQueryBuilder WithDocId(string alias = null, IncludeDirective include = null, SkipDirective skip = null) {
            return WithScalarField("doc_id", alias, new GraphQlDirective[] { include, skip });
        }

        public DocumentBlockQueryBuilder ExceptDocId() {
            return ExceptField("doc_id");
        }

        public DocumentBlockQueryBuilder WithId(string alias = null, IncludeDirective include = null, SkipDirective skip = null) {
            return WithScalarField("id", alias, new GraphQlDirective[] { include, skip });
        }

        public DocumentBlockQueryBuilder ExceptId() {
            return ExceptField("id");
        }

        public DocumentBlockQueryBuilder WithParentBlockId(string alias = null, IncludeDirective include = null, SkipDirective skip = null) {
            return WithScalarField("parent_block_id", alias, new GraphQlDirective[] { include, skip });
        }

        public DocumentBlockQueryBuilder ExceptParentBlockId() {
            return ExceptField("parent_block_id");
        }

        public DocumentBlockQueryBuilder WithPosition(string alias = null, IncludeDirective include = null, SkipDirective skip = null) {
            return WithScalarField("position", alias, new GraphQlDirective[] { include, skip });
        }

        public DocumentBlockQueryBuilder ExceptPosition() {
            return ExceptField("position");
        }

        public DocumentBlockQueryBuilder WithType(string alias = null, IncludeDirective include = null, SkipDirective skip = null) {
            return WithScalarField("type", alias, new GraphQlDirective[] { include, skip });
        }

        public DocumentBlockQueryBuilder ExceptType() {
            return ExceptField("type");
        }

        public DocumentBlockQueryBuilder WithUpdatedAt(string alias = null, IncludeDirective include = null, SkipDirective skip = null) {
            return WithScalarField("updated_at", alias, new GraphQlDirective[] { include, skip });
        }

        public DocumentBlockQueryBuilder ExceptUpdatedAt() {
            return ExceptField("updated_at");
        }
    }
}
