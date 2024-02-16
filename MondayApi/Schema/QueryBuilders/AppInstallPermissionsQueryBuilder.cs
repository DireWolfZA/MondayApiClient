using System.Collections.Generic;

namespace MondayApi.Schema {
    public class AppInstallPermissionsQueryBuilder : GraphQlQueryBuilder<AppInstallPermissionsQueryBuilder> {
        private static readonly GraphQlFieldMetadata[] AllFieldMetadata = new[] {
            new GraphQlFieldMetadata { Name = "approved_scopes", IsComplex = true },
            new GraphQlFieldMetadata { Name = "required_scopes", IsComplex = true }
        };

        protected override string TypeName => "AppInstallPermissions";
        public override IReadOnlyList<GraphQlFieldMetadata> AllFields => AllFieldMetadata;

        public AppInstallPermissionsQueryBuilder WithApprovedScopes(string alias = null, IncludeDirective include = null, SkipDirective skip = null) =>
            WithScalarField("approved_scopes", alias, new GraphQlDirective[] { include, skip });
        public AppInstallPermissionsQueryBuilder ExceptApprovedScopes() =>
            ExceptField("approved_scopes");
        public AppInstallPermissionsQueryBuilder WithRequiredScopes(string alias = null, IncludeDirective include = null, SkipDirective skip = null) =>
            WithScalarField("required_scopes", alias, new GraphQlDirective[] { include, skip });
        public AppInstallPermissionsQueryBuilder ExceptRequiredScopes() =>
            ExceptField("required_scopes");
    }
}
