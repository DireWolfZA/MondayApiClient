using System.Collections.Generic;

namespace MondayApi.Schema {
    public class AccountRoleQueryBuilder : GraphQlQueryBuilder<AccountRoleQueryBuilder> {
        private static readonly GraphQlFieldMetadata[] AllFieldMetadata = new[] {
            new GraphQlFieldMetadata { Name = "id" },
            new GraphQlFieldMetadata { Name = "name" },
            new GraphQlFieldMetadata { Name = "roleType" }
        };

        protected override string TypeName => "AccountRole";
        public override IReadOnlyList<GraphQlFieldMetadata> AllFields => AllFieldMetadata;

        public AccountRoleQueryBuilder WithID(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("id", alias, new GraphQlDirective?[] { include, skip });
        public AccountRoleQueryBuilder ExceptID() =>
            ExceptField("id");
        public AccountRoleQueryBuilder WithName(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("name", alias, new GraphQlDirective?[] { include, skip });
        public AccountRoleQueryBuilder ExceptName() =>
            ExceptField("name");
        public AccountRoleQueryBuilder WithRoleType(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("roleType", alias, new GraphQlDirective?[] { include, skip });
        public AccountRoleQueryBuilder ExceptRoleType() =>
            ExceptField("roleType");
    }
}
