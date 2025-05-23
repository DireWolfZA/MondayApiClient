using System.Collections.Generic;

namespace MondayApi.Schema {
    public class InputFieldConstraintsQueryBuilder : GraphQlQueryBuilder<InputFieldConstraintsQueryBuilder> {
        private static readonly GraphQlFieldMetadata[] AllFieldMetadata = new[] {
            new GraphQlFieldMetadata { Name = "remoteOptionsDependencies" },
            new GraphQlFieldMetadata { Name = "dependencies" },
            new GraphQlFieldMetadata { Name = "subFieldsDependencies" },
            new GraphQlFieldMetadata { Name = "credentials" }
        };

        protected override string TypeName => "InputFieldConstraints";
        public override IReadOnlyList<GraphQlFieldMetadata> AllFields => AllFieldMetadata;

        public InputFieldConstraintsQueryBuilder WithRemoteOptionsDependencies(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("remoteOptionsDependencies", alias, new GraphQlDirective?[] { include, skip });
        public InputFieldConstraintsQueryBuilder ExceptRemoteOptionsDependencies() =>
            ExceptField("remoteOptionsDependencies");
        public InputFieldConstraintsQueryBuilder WithDependencies(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("dependencies", alias, new GraphQlDirective?[] { include, skip });
        public InputFieldConstraintsQueryBuilder ExceptDependencies() =>
            ExceptField("dependencies");
        public InputFieldConstraintsQueryBuilder WithSubFieldsDependencies(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("subFieldsDependencies", alias, new GraphQlDirective?[] { include, skip });
        public InputFieldConstraintsQueryBuilder ExceptSubFieldsDependencies() =>
            ExceptField("subFieldsDependencies");
        public InputFieldConstraintsQueryBuilder WithCredentials(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("credentials", alias, new GraphQlDirective?[] { include, skip });
        public InputFieldConstraintsQueryBuilder ExceptCredentials() =>
            ExceptField("credentials");
    }
}
