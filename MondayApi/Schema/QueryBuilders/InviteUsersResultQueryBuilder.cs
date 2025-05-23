using System.Collections.Generic;

namespace MondayApi.Schema {
    public class InviteUsersResultQueryBuilder : GraphQlQueryBuilder<InviteUsersResultQueryBuilder> {
        private static readonly GraphQlFieldMetadata[] AllFieldMetadata = new[] {
            new GraphQlFieldMetadata { Name = "invited_users", IsComplex = true, QueryBuilderType = typeof(UserQueryBuilder) },
            new GraphQlFieldMetadata { Name = "errors", IsComplex = true, QueryBuilderType = typeof(InviteUsersErrorQueryBuilder) }
        };

        protected override string TypeName => "InviteUsersResult";
        public override IReadOnlyList<GraphQlFieldMetadata> AllFields => AllFieldMetadata;

        public InviteUsersResultQueryBuilder WithInvitedUsers(UserQueryBuilder userQueryBuilder, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithObjectField("invited_users", alias, userQueryBuilder, new GraphQlDirective?[] { include, skip });
        public InviteUsersResultQueryBuilder ExceptInvitedUsers() =>
            ExceptField("invited_users");
        public InviteUsersResultQueryBuilder WithErrors(InviteUsersErrorQueryBuilder inviteUsersErrorQueryBuilder, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithObjectField("errors", alias, inviteUsersErrorQueryBuilder, new GraphQlDirective?[] { include, skip });
        public InviteUsersResultQueryBuilder ExceptErrors() =>
            ExceptField("errors");
    }
}
