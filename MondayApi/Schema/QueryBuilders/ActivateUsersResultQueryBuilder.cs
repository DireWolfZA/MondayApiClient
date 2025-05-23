using System.Collections.Generic;

namespace MondayApi.Schema {
    public class ActivateUsersResultQueryBuilder : GraphQlQueryBuilder<ActivateUsersResultQueryBuilder> {
        private static readonly GraphQlFieldMetadata[] AllFieldMetadata = new[] {
            new GraphQlFieldMetadata { Name = "activated_users", IsComplex = true, QueryBuilderType = typeof(UserQueryBuilder) },
            new GraphQlFieldMetadata { Name = "errors", IsComplex = true, QueryBuilderType = typeof(ActivateUsersErrorQueryBuilder) }
        };

        protected override string TypeName => "ActivateUsersResult";
        public override IReadOnlyList<GraphQlFieldMetadata> AllFields => AllFieldMetadata;

        public ActivateUsersResultQueryBuilder WithActivatedUsers(UserQueryBuilder userQueryBuilder, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithObjectField("activated_users", alias, userQueryBuilder, new GraphQlDirective?[] { include, skip });
        public ActivateUsersResultQueryBuilder ExceptActivatedUsers() =>
            ExceptField("activated_users");
        public ActivateUsersResultQueryBuilder WithErrors(ActivateUsersErrorQueryBuilder activateUsersErrorQueryBuilder, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithObjectField("errors", alias, activateUsersErrorQueryBuilder, new GraphQlDirective?[] { include, skip });
        public ActivateUsersResultQueryBuilder ExceptErrors() =>
            ExceptField("errors");
    }
}
