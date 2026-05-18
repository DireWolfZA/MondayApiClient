using System.Collections.Generic;

namespace MondayApi.Schema {
    public class AssignDepartmentOwnerResultQueryBuilder : GraphQlQueryBuilder<AssignDepartmentOwnerResultQueryBuilder> {
        private static readonly GraphQlFieldMetadata[] AllFieldMetadata = new[] {
            new GraphQlFieldMetadata { Name = "owner", IsComplex = true, QueryBuilderType = typeof(UserQueryBuilder) }
        };

        protected override string TypeName => "AssignDepartmentOwnerResult";
        public override IReadOnlyList<GraphQlFieldMetadata> AllFields => AllFieldMetadata;

        public AssignDepartmentOwnerResultQueryBuilder WithOwner(UserQueryBuilder userQueryBuilder, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithObjectField("owner", alias, userQueryBuilder, new GraphQlDirective?[] { include, skip });
        public AssignDepartmentOwnerResultQueryBuilder ExceptOwner() =>
            ExceptField("owner");
    }
}
