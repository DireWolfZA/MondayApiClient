using System.Collections.Generic;

namespace MondayApi.Schema {
    public class SetBoardPermissionResponseQueryBuilder : GraphQlQueryBuilder<SetBoardPermissionResponseQueryBuilder> {
        private static readonly GraphQlFieldMetadata[] AllFieldMetadata = new[] {
            new GraphQlFieldMetadata { Name = "edit_permissions" },
            new GraphQlFieldMetadata { Name = "failed_actions", IsComplex = true }
        };

        protected override string TypeName => "SetBoardPermissionResponse";
        public override IReadOnlyList<GraphQlFieldMetadata> AllFields => AllFieldMetadata;

        public SetBoardPermissionResponseQueryBuilder WithEditPermissions(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("edit_permissions", alias, new GraphQlDirective?[] { include, skip });
        public SetBoardPermissionResponseQueryBuilder ExceptEditPermissions() =>
            ExceptField("edit_permissions");
        public SetBoardPermissionResponseQueryBuilder WithFailedActions(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("failed_actions", alias, new GraphQlDirective?[] { include, skip });
        public SetBoardPermissionResponseQueryBuilder ExceptFailedActions() =>
            ExceptField("failed_actions");
    }
}
