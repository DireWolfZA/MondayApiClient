using System.Collections.Generic;

namespace MondayApi.Schema {
    public class ChangeTeamMembershipsResultQueryBuilder : GraphQlQueryBuilder<ChangeTeamMembershipsResultQueryBuilder> {
        private static readonly GraphQlFieldMetadata[] AllFieldMetadata = new[] {
            new GraphQlFieldMetadata { Name = "failed_users", IsComplex = true, QueryBuilderType = typeof(UserQueryBuilder) },
            new GraphQlFieldMetadata { Name = "successful_users", IsComplex = true, QueryBuilderType = typeof(UserQueryBuilder) }
        };

        protected override string TypeName => "ChangeTeamMembershipsResult";
        public override IReadOnlyList<GraphQlFieldMetadata> AllFields => AllFieldMetadata;

        public ChangeTeamMembershipsResultQueryBuilder WithFailedUsers(UserQueryBuilder userQueryBuilder, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithObjectField("failed_users", alias, userQueryBuilder, new GraphQlDirective?[] { include, skip });
        public ChangeTeamMembershipsResultQueryBuilder ExceptFailedUsers() =>
            ExceptField("failed_users");
        public ChangeTeamMembershipsResultQueryBuilder WithSuccessfulUsers(UserQueryBuilder userQueryBuilder, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithObjectField("successful_users", alias, userQueryBuilder, new GraphQlDirective?[] { include, skip });
        public ChangeTeamMembershipsResultQueryBuilder ExceptSuccessfulUsers() =>
            ExceptField("successful_users");
    }
}
