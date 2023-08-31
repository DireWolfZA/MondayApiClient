using System.Collections.Generic;

namespace MondayApi.Schema {
    public class FolderQueryBuilder : GraphQlQueryBuilder<FolderQueryBuilder> {
        private static readonly GraphQlFieldMetadata[] AllFieldMetadata = new[] {
            new GraphQlFieldMetadata { Name = "children", IsComplex = true, QueryBuilderType = typeof(BoardQueryBuilder) },
            new GraphQlFieldMetadata { Name = "color" },
            new GraphQlFieldMetadata { Name = "created_at" },
            new GraphQlFieldMetadata { Name = "id" },
            new GraphQlFieldMetadata { Name = "name" },
            new GraphQlFieldMetadata { Name = "owner_id" },
            new GraphQlFieldMetadata { Name = "parent", IsComplex = true, QueryBuilderType = typeof(FolderQueryBuilder) },
            new GraphQlFieldMetadata { Name = "sub_folders", IsComplex = true, QueryBuilderType = typeof(FolderQueryBuilder) },
            new GraphQlFieldMetadata { Name = "workspace", IsComplex = true, QueryBuilderType = typeof(WorkspaceQueryBuilder) }
        };

        protected override string TypeName { get { return "Folder"; } }

        public override IReadOnlyList<GraphQlFieldMetadata> AllFields { get { return AllFieldMetadata; } }

        public FolderQueryBuilder WithChildren(BoardQueryBuilder boardQueryBuilder, string alias = null, IncludeDirective include = null, SkipDirective skip = null) {
            return WithObjectField("children", alias, boardQueryBuilder, new GraphQlDirective[] { include, skip });
        }

        public FolderQueryBuilder ExceptChildren() {
            return ExceptField("children");
        }

        public FolderQueryBuilder WithColor(string alias = null, IncludeDirective include = null, SkipDirective skip = null) {
            return WithScalarField("color", alias, new GraphQlDirective[] { include, skip });
        }

        public FolderQueryBuilder ExceptColor() {
            return ExceptField("color");
        }

        public FolderQueryBuilder WithCreatedAt(string alias = null, IncludeDirective include = null, SkipDirective skip = null) {
            return WithScalarField("created_at", alias, new GraphQlDirective[] { include, skip });
        }

        public FolderQueryBuilder ExceptCreatedAt() {
            return ExceptField("created_at");
        }

        public FolderQueryBuilder WithId(string alias = null, IncludeDirective include = null, SkipDirective skip = null) {
            return WithScalarField("id", alias, new GraphQlDirective[] { include, skip });
        }

        public FolderQueryBuilder ExceptId() {
            return ExceptField("id");
        }

        public FolderQueryBuilder WithName(string alias = null, IncludeDirective include = null, SkipDirective skip = null) {
            return WithScalarField("name", alias, new GraphQlDirective[] { include, skip });
        }

        public FolderQueryBuilder ExceptName() {
            return ExceptField("name");
        }

        public FolderQueryBuilder WithOwnerId(string alias = null, IncludeDirective include = null, SkipDirective skip = null) {
            return WithScalarField("owner_id", alias, new GraphQlDirective[] { include, skip });
        }

        public FolderQueryBuilder ExceptOwnerId() {
            return ExceptField("owner_id");
        }

        public FolderQueryBuilder WithParent(FolderQueryBuilder folderQueryBuilder, string alias = null, IncludeDirective include = null, SkipDirective skip = null) {
            return WithObjectField("parent", alias, folderQueryBuilder, new GraphQlDirective[] { include, skip });
        }

        public FolderQueryBuilder ExceptParent() {
            return ExceptField("parent");
        }

        public FolderQueryBuilder WithSubFolders(FolderQueryBuilder folderQueryBuilder, string alias = null, IncludeDirective include = null, SkipDirective skip = null) {
            return WithObjectField("sub_folders", alias, folderQueryBuilder, new GraphQlDirective[] { include, skip });
        }

        public FolderQueryBuilder ExceptSubFolders() {
            return ExceptField("sub_folders");
        }

        public FolderQueryBuilder WithWorkspace(WorkspaceQueryBuilder workspaceQueryBuilder, string alias = null, IncludeDirective include = null, SkipDirective skip = null) {
            return WithObjectField("workspace", alias, workspaceQueryBuilder, new GraphQlDirective[] { include, skip });
        }

        public FolderQueryBuilder ExceptWorkspace() {
            return ExceptField("workspace");
        }
    }
}
