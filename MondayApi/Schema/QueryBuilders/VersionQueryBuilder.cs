using System.Collections.Generic;

namespace MondayApi.Schema {
    public class VersionQueryBuilder : GraphQlQueryBuilder<VersionQueryBuilder> {
        private static readonly GraphQlFieldMetadata[] AllFieldMetadata = new[] {
            new GraphQlFieldMetadata { Name = "display_name" },
            new GraphQlFieldMetadata { Name = "kind" },
            new GraphQlFieldMetadata { Name = "value" }
        };

        protected override string TypeName => "Version";
        public override IReadOnlyList<GraphQlFieldMetadata> AllFields => AllFieldMetadata;

        public VersionQueryBuilder WithDisplayName(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("display_name", alias, new GraphQlDirective?[] { include, skip });
        public VersionQueryBuilder ExceptDisplayName() =>
            ExceptField("display_name");
        public VersionQueryBuilder WithKind(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("kind", alias, new GraphQlDirective?[] { include, skip });
        public VersionQueryBuilder ExceptKind() =>
            ExceptField("kind");
        public VersionQueryBuilder WithValue(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("value", alias, new GraphQlDirective?[] { include, skip });
        public VersionQueryBuilder ExceptValue() =>
            ExceptField("value");
    }
}
