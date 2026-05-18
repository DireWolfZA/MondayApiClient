using System.Collections.Generic;

namespace MondayApi.Schema {
    public class ClearUsersDepartmentResultQueryBuilder : GraphQlQueryBuilder<ClearUsersDepartmentResultQueryBuilder> {
        private static readonly GraphQlFieldMetadata[] AllFieldMetadata = new[] {
            new GraphQlFieldMetadata { Name = "cleared_users", IsComplex = true, QueryBuilderType = typeof(UserQueryBuilder) }
        };

        protected override string TypeName => "ClearUsersDepartmentResult";
        public override IReadOnlyList<GraphQlFieldMetadata> AllFields => AllFieldMetadata;

        public ClearUsersDepartmentResultQueryBuilder WithClearedUsers(UserQueryBuilder userQueryBuilder, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithObjectField("cleared_users", alias, userQueryBuilder, new GraphQlDirective?[] { include, skip });
        public ClearUsersDepartmentResultQueryBuilder ExceptClearedUsers() =>
            ExceptField("cleared_users");
    }
}
