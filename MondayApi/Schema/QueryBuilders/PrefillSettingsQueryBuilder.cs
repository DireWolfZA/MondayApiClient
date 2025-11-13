using System.Collections.Generic;

namespace MondayApi.Schema {
    public class PrefillSettingsQueryBuilder : GraphQlQueryBuilder<PrefillSettingsQueryBuilder> {
        private static readonly GraphQlFieldMetadata[] AllFieldMetadata = new[] {
            new GraphQlFieldMetadata { Name = "enabled" },
            new GraphQlFieldMetadata { Name = "source" },
            new GraphQlFieldMetadata { Name = "lookup" }
        };

        protected override string TypeName => "PrefillSettings";
        public override IReadOnlyList<GraphQlFieldMetadata> AllFields => AllFieldMetadata;

        public PrefillSettingsQueryBuilder WithEnabled(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("enabled", alias, new GraphQlDirective?[] { include, skip });
        public PrefillSettingsQueryBuilder ExceptEnabled() =>
            ExceptField("enabled");
        public PrefillSettingsQueryBuilder WithSource(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("source", alias, new GraphQlDirective?[] { include, skip });
        public PrefillSettingsQueryBuilder ExceptSource() =>
            ExceptField("source");
        public PrefillSettingsQueryBuilder WithLookup(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("lookup", alias, new GraphQlDirective?[] { include, skip });
        public PrefillSettingsQueryBuilder ExceptLookup() =>
            ExceptField("lookup");
    }
}
