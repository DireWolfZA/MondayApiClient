using System.Collections.Generic;

namespace MondayApi.Schema {
    public class DeactivateUsersResultQueryBuilder : GraphQlQueryBuilder<DeactivateUsersResultQueryBuilder> {
        private static readonly GraphQlFieldMetadata[] AllFieldMetadata = new[] {
            new GraphQlFieldMetadata { Name = "deactivated_users", IsComplex = true, QueryBuilderType = typeof(UserQueryBuilder) },
            new GraphQlFieldMetadata { Name = "errors", IsComplex = true, QueryBuilderType = typeof(DeactivateUsersErrorQueryBuilder) }
        };

        protected override string TypeName => "DeactivateUsersResult";
        public override IReadOnlyList<GraphQlFieldMetadata> AllFields => AllFieldMetadata;

        public DeactivateUsersResultQueryBuilder WithDeactivatedUsers(UserQueryBuilder userQueryBuilder, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithObjectField("deactivated_users", alias, userQueryBuilder, new GraphQlDirective?[] { include, skip });
        public DeactivateUsersResultQueryBuilder ExceptDeactivatedUsers() =>
            ExceptField("deactivated_users");
        public DeactivateUsersResultQueryBuilder WithErrors(DeactivateUsersErrorQueryBuilder deactivateUsersErrorQueryBuilder, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithObjectField("errors", alias, deactivateUsersErrorQueryBuilder, new GraphQlDirective?[] { include, skip });
        public DeactivateUsersResultQueryBuilder ExceptErrors() =>
            ExceptField("errors");
    }
}
