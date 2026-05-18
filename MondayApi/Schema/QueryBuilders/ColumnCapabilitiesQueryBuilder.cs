using System.Collections.Generic;

namespace MondayApi.Schema {
    public class ColumnCapabilitiesQueryBuilder : GraphQlQueryBuilder<ColumnCapabilitiesQueryBuilder> {
        private static readonly GraphQlFieldMetadata[] AllFieldMetadata = new[] {
            new GraphQlFieldMetadata { Name = "calculated", IsComplex = true, QueryBuilderType = typeof(CalculatedCapabilityQueryBuilder) },
            new GraphQlFieldMetadata { Name = "visibility" }
        };

        protected override string TypeName => "ColumnCapabilities";
        public override IReadOnlyList<GraphQlFieldMetadata> AllFields => AllFieldMetadata;

        public ColumnCapabilitiesQueryBuilder WithCalculated(CalculatedCapabilityQueryBuilder calculatedCapabilityQueryBuilder, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithObjectField("calculated", alias, calculatedCapabilityQueryBuilder, new GraphQlDirective?[] { include, skip });
        public ColumnCapabilitiesQueryBuilder ExceptCalculated() =>
            ExceptField("calculated");
        public ColumnCapabilitiesQueryBuilder WithVisibility(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("visibility", alias, new GraphQlDirective?[] { include, skip });
        public ColumnCapabilitiesQueryBuilder ExceptVisibility() =>
            ExceptField("visibility");
    }
}
