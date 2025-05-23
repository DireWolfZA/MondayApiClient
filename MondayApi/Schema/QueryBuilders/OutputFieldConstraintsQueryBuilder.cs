using System.Collections.Generic;

namespace MondayApi.Schema {
    public class OutputFieldConstraintsQueryBuilder : GraphQlQueryBuilder<OutputFieldConstraintsQueryBuilder> {
        private static readonly GraphQlFieldMetadata[] AllFieldMetadata = new[] {
            new GraphQlFieldMetadata { Name = "dependencies" },
            new GraphQlFieldMetadata { Name = "subFieldsDependencies" },
            new GraphQlFieldMetadata { Name = "credentials" }
        };

        protected override string TypeName => "OutputFieldConstraints";
        public override IReadOnlyList<GraphQlFieldMetadata> AllFields => AllFieldMetadata;

        public OutputFieldConstraintsQueryBuilder WithDependencies(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("dependencies", alias, new GraphQlDirective?[] { include, skip });
        public OutputFieldConstraintsQueryBuilder ExceptDependencies() =>
            ExceptField("dependencies");
        public OutputFieldConstraintsQueryBuilder WithSubFieldsDependencies(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("subFieldsDependencies", alias, new GraphQlDirective?[] { include, skip });
        public OutputFieldConstraintsQueryBuilder ExceptSubFieldsDependencies() =>
            ExceptField("subFieldsDependencies");
        public OutputFieldConstraintsQueryBuilder WithCredentials(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("credentials", alias, new GraphQlDirective?[] { include, skip });
        public OutputFieldConstraintsQueryBuilder ExceptCredentials() =>
            ExceptField("credentials");
    }
}
