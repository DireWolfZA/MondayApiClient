using System.Collections.Generic;

namespace MondayApi.Schema {
    public class DocumentQueryBuilder : GraphQlQueryBuilder<DocumentQueryBuilder> {
        private static readonly GraphQlFieldMetadata[] AllFieldMetadata = new[] {
            new GraphQlFieldMetadata { Name = "blocks", IsComplex = true, QueryBuilderType = typeof(DocumentBlockQueryBuilder) },
            new GraphQlFieldMetadata { Name = "created_at" },
            new GraphQlFieldMetadata { Name = "created_by", IsComplex = true, QueryBuilderType = typeof(UserQueryBuilder) },
            new GraphQlFieldMetadata { Name = "doc_folder_id" },
            new GraphQlFieldMetadata { Name = "doc_kind" },
            new GraphQlFieldMetadata { Name = "id" },
            new GraphQlFieldMetadata { Name = "name" },
            new GraphQlFieldMetadata { Name = "object_id" },
            new GraphQlFieldMetadata { Name = "relative_url" },
            new GraphQlFieldMetadata { Name = "settings", IsComplex = true },
            new GraphQlFieldMetadata { Name = "url" },
            new GraphQlFieldMetadata { Name = "workspace", IsComplex = true, QueryBuilderType = typeof(WorkspaceQueryBuilder) },
            new GraphQlFieldMetadata { Name = "workspace_id" }
        };

        protected override string TypeName { get { return "Document"; } }

        public override IReadOnlyList<GraphQlFieldMetadata> AllFields { get { return AllFieldMetadata; } }

        public DocumentQueryBuilder WithBlocks(DocumentBlockQueryBuilder documentBlockQueryBuilder, QueryBuilderParameter<int?> limit = null, QueryBuilderParameter<int?> page = null, string alias = null, IncludeDirective include = null, SkipDirective skip = null) {
            var args = new List<QueryBuilderArgumentInfo>();
            if (limit != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "limit", ArgumentValue = limit });

            if (page != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "page", ArgumentValue = page });

            return WithObjectField("blocks", alias, documentBlockQueryBuilder, new GraphQlDirective[] { include, skip }, args);
        }

        public DocumentQueryBuilder ExceptBlocks() {
            return ExceptField("blocks");
        }

        public DocumentQueryBuilder WithCreatedAt(string alias = null, IncludeDirective include = null, SkipDirective skip = null) {
            return WithScalarField("created_at", alias, new GraphQlDirective[] { include, skip });
        }

        public DocumentQueryBuilder ExceptCreatedAt() {
            return ExceptField("created_at");
        }

        public DocumentQueryBuilder WithCreatedBy(UserQueryBuilder userQueryBuilder, string alias = null, IncludeDirective include = null, SkipDirective skip = null) {
            return WithObjectField("created_by", alias, userQueryBuilder, new GraphQlDirective[] { include, skip });
        }

        public DocumentQueryBuilder ExceptCreatedBy() {
            return ExceptField("created_by");
        }

        public DocumentQueryBuilder WithDocFolderId(string alias = null, IncludeDirective include = null, SkipDirective skip = null) {
            return WithScalarField("doc_folder_id", alias, new GraphQlDirective[] { include, skip });
        }

        public DocumentQueryBuilder ExceptDocFolderId() {
            return ExceptField("doc_folder_id");
        }

        public DocumentQueryBuilder WithDocKind(string alias = null, IncludeDirective include = null, SkipDirective skip = null) {
            return WithScalarField("doc_kind", alias, new GraphQlDirective[] { include, skip });
        }

        public DocumentQueryBuilder ExceptDocKind() {
            return ExceptField("doc_kind");
        }

        public DocumentQueryBuilder WithId(string alias = null, IncludeDirective include = null, SkipDirective skip = null) {
            return WithScalarField("id", alias, new GraphQlDirective[] { include, skip });
        }

        public DocumentQueryBuilder ExceptId() {
            return ExceptField("id");
        }

        public DocumentQueryBuilder WithName(string alias = null, IncludeDirective include = null, SkipDirective skip = null) {
            return WithScalarField("name", alias, new GraphQlDirective[] { include, skip });
        }

        public DocumentQueryBuilder ExceptName() {
            return ExceptField("name");
        }

        public DocumentQueryBuilder WithObjectId(string alias = null, IncludeDirective include = null, SkipDirective skip = null) {
            return WithScalarField("object_id", alias, new GraphQlDirective[] { include, skip });
        }

        public DocumentQueryBuilder ExceptObjectId() {
            return ExceptField("object_id");
        }

        public DocumentQueryBuilder WithRelativeUrl(string alias = null, IncludeDirective include = null, SkipDirective skip = null) {
            return WithScalarField("relative_url", alias, new GraphQlDirective[] { include, skip });
        }

        public DocumentQueryBuilder ExceptRelativeUrl() {
            return ExceptField("relative_url");
        }

        public DocumentQueryBuilder WithSettings(string alias = null, IncludeDirective include = null, SkipDirective skip = null) {
            return WithScalarField("settings", alias, new GraphQlDirective[] { include, skip });
        }

        public DocumentQueryBuilder ExceptSettings() {
            return ExceptField("settings");
        }

        public DocumentQueryBuilder WithUrl(string alias = null, IncludeDirective include = null, SkipDirective skip = null) {
            return WithScalarField("url", alias, new GraphQlDirective[] { include, skip });
        }

        public DocumentQueryBuilder ExceptUrl() {
            return ExceptField("url");
        }

        public DocumentQueryBuilder WithWorkspace(WorkspaceQueryBuilder workspaceQueryBuilder, string alias = null, IncludeDirective include = null, SkipDirective skip = null) {
            return WithObjectField("workspace", alias, workspaceQueryBuilder, new GraphQlDirective[] { include, skip });
        }

        public DocumentQueryBuilder ExceptWorkspace() {
            return ExceptField("workspace");
        }

        public DocumentQueryBuilder WithWorkspaceId(string alias = null, IncludeDirective include = null, SkipDirective skip = null) {
            return WithScalarField("workspace_id", alias, new GraphQlDirective[] { include, skip });
        }

        public DocumentQueryBuilder ExceptWorkspaceId() {
            return ExceptField("workspace_id");
        }
    }
}
