using System.Collections.Generic;

namespace MondayApi.Schema {
    public class AssignDepartmentMembersResultQueryBuilder : GraphQlQueryBuilder<AssignDepartmentMembersResultQueryBuilder> {
        private static readonly GraphQlFieldMetadata[] AllFieldMetadata = new[] {
            new GraphQlFieldMetadata { Name = "successful_users", IsComplex = true, QueryBuilderType = typeof(UserQueryBuilder) },
            new GraphQlFieldMetadata { Name = "failed_users", IsComplex = true, QueryBuilderType = typeof(UserQueryBuilder) }
        };

        protected override string TypeName => "AssignDepartmentMembersResult";
        public override IReadOnlyList<GraphQlFieldMetadata> AllFields => AllFieldMetadata;

        public AssignDepartmentMembersResultQueryBuilder WithSuccessfulUsers(UserQueryBuilder userQueryBuilder, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithObjectField("successful_users", alias, userQueryBuilder, new GraphQlDirective?[] { include, skip });
        public AssignDepartmentMembersResultQueryBuilder ExceptSuccessfulUsers() =>
            ExceptField("successful_users");
        public AssignDepartmentMembersResultQueryBuilder WithFailedUsers(UserQueryBuilder userQueryBuilder, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithObjectField("failed_users", alias, userQueryBuilder, new GraphQlDirective?[] { include, skip });
        public AssignDepartmentMembersResultQueryBuilder ExceptFailedUsers() =>
            ExceptField("failed_users");
    }
}
