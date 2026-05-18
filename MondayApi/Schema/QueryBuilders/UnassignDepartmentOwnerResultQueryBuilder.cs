using System.Collections.Generic;

namespace MondayApi.Schema {
    public class UnassignDepartmentOwnerResultQueryBuilder : GraphQlQueryBuilder<UnassignDepartmentOwnerResultQueryBuilder> {
        private static readonly GraphQlFieldMetadata[] AllFieldMetadata = new[] {
            new GraphQlFieldMetadata { Name = "unassigned_users", IsComplex = true, QueryBuilderType = typeof(UserQueryBuilder) }
        };

        protected override string TypeName => "UnassignDepartmentOwnerResult";
        public override IReadOnlyList<GraphQlFieldMetadata> AllFields => AllFieldMetadata;

        public UnassignDepartmentOwnerResultQueryBuilder WithUnassignedUsers(UserQueryBuilder userQueryBuilder, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithObjectField("unassigned_users", alias, userQueryBuilder, new GraphQlDirective?[] { include, skip });
        public UnassignDepartmentOwnerResultQueryBuilder ExceptUnassignedUsers() =>
            ExceptField("unassigned_users");
    }
}
