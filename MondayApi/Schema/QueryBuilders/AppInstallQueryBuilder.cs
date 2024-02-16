using System.Collections.Generic;

namespace MondayApi.Schema {
    public class AppInstallQueryBuilder : GraphQlQueryBuilder<AppInstallQueryBuilder> {
        private static readonly GraphQlFieldMetadata[] AllFieldMetadata = new[] {
            new GraphQlFieldMetadata { Name = "app_id" },
            new GraphQlFieldMetadata { Name = "app_install_account", IsComplex = true, QueryBuilderType = typeof(AppInstallAccountQueryBuilder) },
            new GraphQlFieldMetadata { Name = "app_install_user", IsComplex = true, QueryBuilderType = typeof(AppInstallUserQueryBuilder) },
            new GraphQlFieldMetadata { Name = "app_version", IsComplex = true, QueryBuilderType = typeof(AppVersionQueryBuilder) },
            new GraphQlFieldMetadata { Name = "permissions", IsComplex = true, QueryBuilderType = typeof(AppInstallPermissionsQueryBuilder) },
            new GraphQlFieldMetadata { Name = "timestamp" }
        };

        protected override string TypeName => "AppInstall";
        public override IReadOnlyList<GraphQlFieldMetadata> AllFields => AllFieldMetadata;

        public AppInstallQueryBuilder WithAppID(string alias = null, IncludeDirective include = null, SkipDirective skip = null) =>
            WithScalarField("app_id", alias, new GraphQlDirective[] { include, skip });
        public AppInstallQueryBuilder ExceptAppID() =>
            ExceptField("app_id");
        public AppInstallQueryBuilder WithAppInstallAccount(AppInstallAccountQueryBuilder appInstallAccountQueryBuilder, string alias = null, IncludeDirective include = null, SkipDirective skip = null) =>
            WithObjectField("app_install_account", alias, appInstallAccountQueryBuilder, new GraphQlDirective[] { include, skip });
        public AppInstallQueryBuilder ExceptAppInstallAccount() =>
            ExceptField("app_install_account");
        public AppInstallQueryBuilder WithAppInstallUser(AppInstallUserQueryBuilder appInstallUserQueryBuilder, string alias = null, IncludeDirective include = null, SkipDirective skip = null) =>
            WithObjectField("app_install_user", alias, appInstallUserQueryBuilder, new GraphQlDirective[] { include, skip });
        public AppInstallQueryBuilder ExceptAppInstallUser() =>
            ExceptField("app_install_user");
        public AppInstallQueryBuilder WithAppVersion(AppVersionQueryBuilder appVersionQueryBuilder, string alias = null, IncludeDirective include = null, SkipDirective skip = null) =>
            WithObjectField("app_version", alias, appVersionQueryBuilder, new GraphQlDirective[] { include, skip });
        public AppInstallQueryBuilder ExceptAppVersion() =>
            ExceptField("app_version");
        public AppInstallQueryBuilder WithPermissions(AppInstallPermissionsQueryBuilder appInstallPermissionsQueryBuilder, string alias = null, IncludeDirective include = null, SkipDirective skip = null) =>
            WithObjectField("permissions", alias, appInstallPermissionsQueryBuilder, new GraphQlDirective[] { include, skip });
        public AppInstallQueryBuilder ExceptPermissions() =>
            ExceptField("permissions");
        public AppInstallQueryBuilder WithTimestamp(string alias = null, IncludeDirective include = null, SkipDirective skip = null) =>
            WithScalarField("timestamp", alias, new GraphQlDirective[] { include, skip });
        public AppInstallQueryBuilder ExceptTimestamp() =>
            ExceptField("timestamp");
    }
}
