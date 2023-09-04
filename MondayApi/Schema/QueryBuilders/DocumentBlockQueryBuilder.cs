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

        protected override string TypeName => "DocumentBlock";
        public override IReadOnlyList<GraphQlFieldMetadata> AllFields => AllFieldMetadata;

        public DocumentBlockQueryBuilder WithContent(string alias = null, IncludeDirective include = null, SkipDirective skip = null) =>
            WithScalarField("content", alias, new GraphQlDirective[] { include, skip });
        public DocumentBlockQueryBuilder ExceptContent() =>
            ExceptField("content");
        public DocumentBlockQueryBuilder WithCreatedAt(string alias = null, IncludeDirective include = null, SkipDirective skip = null) =>
            WithScalarField("created_at", alias, new GraphQlDirective[] { include, skip });
        public DocumentBlockQueryBuilder ExceptCreatedAt() =>
            ExceptField("created_at");
        public DocumentBlockQueryBuilder WithCreatedBy(UserQueryBuilder userQueryBuilder, string alias = null, IncludeDirective include = null, SkipDirective skip = null) =>
            WithObjectField("created_by", alias, userQueryBuilder, new GraphQlDirective[] { include, skip });
        public DocumentBlockQueryBuilder ExceptCreatedBy() =>
            ExceptField("created_by");
        public DocumentBlockQueryBuilder WithDocId(string alias = null, IncludeDirective include = null, SkipDirective skip = null) =>
            WithScalarField("doc_id", alias, new GraphQlDirective[] { include, skip });
        public DocumentBlockQueryBuilder ExceptDocId() =>
            ExceptField("doc_id");
        public DocumentBlockQueryBuilder WithId(string alias = null, IncludeDirective include = null, SkipDirective skip = null) =>
            WithScalarField("id", alias, new GraphQlDirective[] { include, skip });
        public DocumentBlockQueryBuilder ExceptId() =>
            ExceptField("id");
        public DocumentBlockQueryBuilder WithParentBlockId(string alias = null, IncludeDirective include = null, SkipDirective skip = null) =>
            WithScalarField("parent_block_id", alias, new GraphQlDirective[] { include, skip });
        public DocumentBlockQueryBuilder ExceptParentBlockId() =>
            ExceptField("parent_block_id");
        public DocumentBlockQueryBuilder WithPosition(string alias = null, IncludeDirective include = null, SkipDirective skip = null) =>
            WithScalarField("position", alias, new GraphQlDirective[] { include, skip });
        public DocumentBlockQueryBuilder ExceptPosition() =>
            ExceptField("position");
        public DocumentBlockQueryBuilder WithType(string alias = null, IncludeDirective include = null, SkipDirective skip = null) =>
            WithScalarField("type", alias, new GraphQlDirective[] { include, skip });
        public DocumentBlockQueryBuilder ExceptType() =>
            ExceptField("type");
        public DocumentBlockQueryBuilder WithUpdatedAt(string alias = null, IncludeDirective include = null, SkipDirective skip = null) =>
            WithScalarField("updated_at", alias, new GraphQlDirective[] { include, skip });
        public DocumentBlockQueryBuilder ExceptUpdatedAt() =>
            ExceptField("updated_at");
    }
}
