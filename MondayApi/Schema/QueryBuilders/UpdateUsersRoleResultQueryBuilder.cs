using System.Collections.Generic;

namespace MondayApi.Schema {
    public class UpdateUsersRoleResultQueryBuilder : GraphQlQueryBuilder<UpdateUsersRoleResultQueryBuilder> {
        private static readonly GraphQlFieldMetadata[] AllFieldMetadata = new[] {
            new GraphQlFieldMetadata { Name = "updated_users", IsComplex = true, QueryBuilderType = typeof(UserQueryBuilder) },
            new GraphQlFieldMetadata { Name = "errors", IsComplex = true, QueryBuilderType = typeof(UpdateUsersRoleErrorQueryBuilder) }
        };

        protected override string TypeName => "UpdateUsersRoleResult";
        public override IReadOnlyList<GraphQlFieldMetadata> AllFields => AllFieldMetadata;

        public UpdateUsersRoleResultQueryBuilder WithUpdatedUsers(UserQueryBuilder userQueryBuilder, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithObjectField("updated_users", alias, userQueryBuilder, new GraphQlDirective?[] { include, skip });
        public UpdateUsersRoleResultQueryBuilder ExceptUpdatedUsers() =>
            ExceptField("updated_users");
        public UpdateUsersRoleResultQueryBuilder WithErrors(UpdateUsersRoleErrorQueryBuilder updateUsersRoleErrorQueryBuilder, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithObjectField("errors", alias, updateUsersRoleErrorQueryBuilder, new GraphQlDirective?[] { include, skip });
        public UpdateUsersRoleResultQueryBuilder ExceptErrors() =>
            ExceptField("errors");
    }
}
