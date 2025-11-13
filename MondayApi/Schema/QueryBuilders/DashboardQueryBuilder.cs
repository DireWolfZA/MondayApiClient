using System.Collections.Generic;

namespace MondayApi.Schema {
    public class DashboardQueryBuilder : GraphQlQueryBuilder<DashboardQueryBuilder> {
        private static readonly GraphQlFieldMetadata[] AllFieldMetadata = new[] {
            new GraphQlFieldMetadata { Name = "id" },
            new GraphQlFieldMetadata { Name = "name" },
            new GraphQlFieldMetadata { Name = "workspace_id" },
            new GraphQlFieldMetadata { Name = "kind" },
            new GraphQlFieldMetadata { Name = "board_folder_id" }
        };

        protected override string TypeName => "Dashboard";
        public override IReadOnlyList<GraphQlFieldMetadata> AllFields => AllFieldMetadata;

        public DashboardQueryBuilder WithID(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("id", alias, new GraphQlDirective?[] { include, skip });
        public DashboardQueryBuilder ExceptID() =>
            ExceptField("id");
        public DashboardQueryBuilder WithName(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("name", alias, new GraphQlDirective?[] { include, skip });
        public DashboardQueryBuilder ExceptName() =>
            ExceptField("name");
        public DashboardQueryBuilder WithWorkspaceID(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("workspace_id", alias, new GraphQlDirective?[] { include, skip });
        public DashboardQueryBuilder ExceptWorkspaceID() =>
            ExceptField("workspace_id");
        public DashboardQueryBuilder WithKind(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("kind", alias, new GraphQlDirective?[] { include, skip });
        public DashboardQueryBuilder ExceptKind() =>
            ExceptField("kind");
        public DashboardQueryBuilder WithBoardFolderID(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("board_folder_id", alias, new GraphQlDirective?[] { include, skip });
        public DashboardQueryBuilder ExceptBoardFolderID() =>
            ExceptField("board_folder_id");
    }
}
