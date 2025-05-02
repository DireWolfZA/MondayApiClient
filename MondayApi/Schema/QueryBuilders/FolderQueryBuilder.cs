using System.Collections.Generic;

namespace MondayApi.Schema {
    public class FolderQueryBuilder : GraphQlQueryBuilder<FolderQueryBuilder> {
        private static readonly GraphQlFieldMetadata[] AllFieldMetadata = new[] {
            new GraphQlFieldMetadata { Name = "children", IsComplex = true, QueryBuilderType = typeof(BoardQueryBuilder) },
            new GraphQlFieldMetadata { Name = "color" },
            new GraphQlFieldMetadata { Name = "created_at" },
            new GraphQlFieldMetadata { Name = "custom_icon" },
            new GraphQlFieldMetadata { Name = "font_weight" },
            new GraphQlFieldMetadata { Name = "id" },
            new GraphQlFieldMetadata { Name = "name" },
            new GraphQlFieldMetadata { Name = "owner_id" },
            new GraphQlFieldMetadata { Name = "parent", IsComplex = true, QueryBuilderType = typeof(FolderQueryBuilder) },
            new GraphQlFieldMetadata { Name = "sub_folders", IsComplex = true, QueryBuilderType = typeof(FolderQueryBuilder) },
            new GraphQlFieldMetadata { Name = "workspace", IsComplex = true, QueryBuilderType = typeof(WorkspaceQueryBuilder) }
        };

        protected override string TypeName => "Folder";
        public override IReadOnlyList<GraphQlFieldMetadata> AllFields => AllFieldMetadata;

        public FolderQueryBuilder WithChildren(BoardQueryBuilder boardQueryBuilder, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithObjectField("children", alias, boardQueryBuilder, new GraphQlDirective?[] { include, skip });
        public FolderQueryBuilder ExceptChildren() =>
            ExceptField("children");
        public FolderQueryBuilder WithColor(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("color", alias, new GraphQlDirective?[] { include, skip });
        public FolderQueryBuilder ExceptColor() =>
            ExceptField("color");
        public FolderQueryBuilder WithCreatedAt(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("created_at", alias, new GraphQlDirective?[] { include, skip });
        public FolderQueryBuilder ExceptCreatedAt() =>
            ExceptField("created_at");
        public FolderQueryBuilder WithCustomIcon(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("custom_icon", alias, new GraphQlDirective?[] { include, skip });
        public FolderQueryBuilder ExceptCustomIcon() =>
            ExceptField("custom_icon");
        public FolderQueryBuilder WithFontWeight(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("font_weight", alias, new GraphQlDirective?[] { include, skip });
        public FolderQueryBuilder ExceptFontWeight() =>
            ExceptField("font_weight");
        public FolderQueryBuilder WithID(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("id", alias, new GraphQlDirective?[] { include, skip });
        public FolderQueryBuilder ExceptID() =>
            ExceptField("id");
        public FolderQueryBuilder WithName(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("name", alias, new GraphQlDirective?[] { include, skip });
        public FolderQueryBuilder ExceptName() =>
            ExceptField("name");
        public FolderQueryBuilder WithOwnerID(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("owner_id", alias, new GraphQlDirective?[] { include, skip });
        public FolderQueryBuilder ExceptOwnerID() =>
            ExceptField("owner_id");
        public FolderQueryBuilder WithParent(FolderQueryBuilder folderQueryBuilder, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithObjectField("parent", alias, folderQueryBuilder, new GraphQlDirective?[] { include, skip });
        public FolderQueryBuilder ExceptParent() =>
            ExceptField("parent");
        public FolderQueryBuilder WithSubFolders(FolderQueryBuilder folderQueryBuilder, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithObjectField("sub_folders", alias, folderQueryBuilder, new GraphQlDirective?[] { include, skip });
        public FolderQueryBuilder ExceptSubFolders() =>
            ExceptField("sub_folders");
        public FolderQueryBuilder WithWorkspace(WorkspaceQueryBuilder workspaceQueryBuilder, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithObjectField("workspace", alias, workspaceQueryBuilder, new GraphQlDirective?[] { include, skip });
        public FolderQueryBuilder ExceptWorkspace() =>
            ExceptField("workspace");
    }
}
