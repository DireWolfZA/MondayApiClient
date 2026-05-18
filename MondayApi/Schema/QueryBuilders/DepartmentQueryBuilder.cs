using System.Collections.Generic;

namespace MondayApi.Schema {
    public class DepartmentQueryBuilder : GraphQlQueryBuilder<DepartmentQueryBuilder> {
        private static readonly GraphQlFieldMetadata[] AllFieldMetadata = new[] {
            new GraphQlFieldMetadata { Name = "id" },
            new GraphQlFieldMetadata { Name = "name" },
            new GraphQlFieldMetadata { Name = "reserved_seats" },
            new GraphQlFieldMetadata { Name = "assigned_seats" },
            new GraphQlFieldMetadata { Name = "members", IsComplex = true, QueryBuilderType = typeof(UserQueryBuilder) },
            new GraphQlFieldMetadata { Name = "owners", IsComplex = true, QueryBuilderType = typeof(UserQueryBuilder) }
        };

        protected override string TypeName => "Department";
        public override IReadOnlyList<GraphQlFieldMetadata> AllFields => AllFieldMetadata;

        public DepartmentQueryBuilder WithID(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("id", alias, new GraphQlDirective?[] { include, skip });
        public DepartmentQueryBuilder ExceptID() =>
            ExceptField("id");
        public DepartmentQueryBuilder WithName(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("name", alias, new GraphQlDirective?[] { include, skip });
        public DepartmentQueryBuilder ExceptName() =>
            ExceptField("name");
        public DepartmentQueryBuilder WithReservedSeats(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("reserved_seats", alias, new GraphQlDirective?[] { include, skip });
        public DepartmentQueryBuilder ExceptReservedSeats() =>
            ExceptField("reserved_seats");
        public DepartmentQueryBuilder WithAssignedSeats(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("assigned_seats", alias, new GraphQlDirective?[] { include, skip });
        public DepartmentQueryBuilder ExceptAssignedSeats() =>
            ExceptField("assigned_seats");
        public DepartmentQueryBuilder WithMembers(UserQueryBuilder userQueryBuilder, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithObjectField("members", alias, userQueryBuilder, new GraphQlDirective?[] { include, skip });
        public DepartmentQueryBuilder ExceptMembers() =>
            ExceptField("members");
        public DepartmentQueryBuilder WithOwners(UserQueryBuilder userQueryBuilder, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithObjectField("owners", alias, userQueryBuilder, new GraphQlDirective?[] { include, skip });
        public DepartmentQueryBuilder ExceptOwners() =>
            ExceptField("owners");
    }
}
