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
            new GraphQlFieldMetadata { Name = "settings" },
            new GraphQlFieldMetadata { Name = "url" },
            new GraphQlFieldMetadata { Name = "workspace", IsComplex = true, QueryBuilderType = typeof(WorkspaceQueryBuilder) },
            new GraphQlFieldMetadata { Name = "workspace_id" }
        };

        protected override string TypeName => "Document";
        public override IReadOnlyList<GraphQlFieldMetadata> AllFields => AllFieldMetadata;

        public DocumentQueryBuilder WithBlocks(DocumentBlockQueryBuilder documentBlockQueryBuilder, QueryBuilderParameter<int?>? limit = null, QueryBuilderParameter<int?>? page = null, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) {
            var args = new List<QueryBuilderArgumentInfo>();
            if (limit != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "limit", ArgumentValue = limit });
            if (page != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "page", ArgumentValue = page });
            return WithObjectField("blocks", alias, documentBlockQueryBuilder, new GraphQlDirective?[] { include, skip }, args);
        }

        public DocumentQueryBuilder ExceptBlocks() =>
            ExceptField("blocks");
        public DocumentQueryBuilder WithCreatedAt(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("created_at", alias, new GraphQlDirective?[] { include, skip });
        public DocumentQueryBuilder ExceptCreatedAt() =>
            ExceptField("created_at");
        public DocumentQueryBuilder WithCreatedBy(UserQueryBuilder userQueryBuilder, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithObjectField("created_by", alias, userQueryBuilder, new GraphQlDirective?[] { include, skip });
        public DocumentQueryBuilder ExceptCreatedBy() =>
            ExceptField("created_by");
        public DocumentQueryBuilder WithDocFolderID(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("doc_folder_id", alias, new GraphQlDirective?[] { include, skip });
        public DocumentQueryBuilder ExceptDocFolderID() =>
            ExceptField("doc_folder_id");
        public DocumentQueryBuilder WithDocKind(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("doc_kind", alias, new GraphQlDirective?[] { include, skip });
        public DocumentQueryBuilder ExceptDocKind() =>
            ExceptField("doc_kind");
        public DocumentQueryBuilder WithID(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("id", alias, new GraphQlDirective?[] { include, skip });
        public DocumentQueryBuilder ExceptID() =>
            ExceptField("id");
        public DocumentQueryBuilder WithName(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("name", alias, new GraphQlDirective?[] { include, skip });
        public DocumentQueryBuilder ExceptName() =>
            ExceptField("name");
        public DocumentQueryBuilder WithObjectID(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("object_id", alias, new GraphQlDirective?[] { include, skip });
        public DocumentQueryBuilder ExceptObjectID() =>
            ExceptField("object_id");
        public DocumentQueryBuilder WithRelativeURL(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("relative_url", alias, new GraphQlDirective?[] { include, skip });
        public DocumentQueryBuilder ExceptRelativeURL() =>
            ExceptField("relative_url");
        public DocumentQueryBuilder WithSettings(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("settings", alias, new GraphQlDirective?[] { include, skip });
        public DocumentQueryBuilder ExceptSettings() =>
            ExceptField("settings");
        public DocumentQueryBuilder WithURL(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("url", alias, new GraphQlDirective?[] { include, skip });
        public DocumentQueryBuilder ExceptURL() =>
            ExceptField("url");
        public DocumentQueryBuilder WithWorkspace(WorkspaceQueryBuilder workspaceQueryBuilder, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithObjectField("workspace", alias, workspaceQueryBuilder, new GraphQlDirective?[] { include, skip });
        public DocumentQueryBuilder ExceptWorkspace() =>
            ExceptField("workspace");
        public DocumentQueryBuilder WithWorkspaceID(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("workspace_id", alias, new GraphQlDirective?[] { include, skip });
        public DocumentQueryBuilder ExceptWorkspaceID() =>
            ExceptField("workspace_id");
    }
}
