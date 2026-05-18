using System.Collections.Generic;

namespace MondayApi.Schema {
    public class DirectoryResourceQueryBuilder : GraphQlQueryBuilder<DirectoryResourceQueryBuilder> {
        private static readonly GraphQlFieldMetadata[] AllFieldMetadata = new[] {
            new GraphQlFieldMetadata { Name = "id" },
            new GraphQlFieldMetadata { Name = "name" },
            new GraphQlFieldMetadata { Name = "email" },
            new GraphQlFieldMetadata { Name = "job_role" },
            new GraphQlFieldMetadata { Name = "skills", IsComplex = true },
            new GraphQlFieldMetadata { Name = "location" }
        };

        protected override string TypeName => "DirectoryResource";
        public override IReadOnlyList<GraphQlFieldMetadata> AllFields => AllFieldMetadata;

        public DirectoryResourceQueryBuilder WithID(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("id", alias, new GraphQlDirective?[] { include, skip });
        public DirectoryResourceQueryBuilder ExceptID() =>
            ExceptField("id");
        public DirectoryResourceQueryBuilder WithName(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("name", alias, new GraphQlDirective?[] { include, skip });
        public DirectoryResourceQueryBuilder ExceptName() =>
            ExceptField("name");
        public DirectoryResourceQueryBuilder WithEmail(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("email", alias, new GraphQlDirective?[] { include, skip });
        public DirectoryResourceQueryBuilder ExceptEmail() =>
            ExceptField("email");
        public DirectoryResourceQueryBuilder WithJobRole(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("job_role", alias, new GraphQlDirective?[] { include, skip });
        public DirectoryResourceQueryBuilder ExceptJobRole() =>
            ExceptField("job_role");
        public DirectoryResourceQueryBuilder WithSkills(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("skills", alias, new GraphQlDirective?[] { include, skip });
        public DirectoryResourceQueryBuilder ExceptSkills() =>
            ExceptField("skills");
        public DirectoryResourceQueryBuilder WithLocation(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("location", alias, new GraphQlDirective?[] { include, skip });
        public DirectoryResourceQueryBuilder ExceptLocation() =>
            ExceptField("location");
    }
}
