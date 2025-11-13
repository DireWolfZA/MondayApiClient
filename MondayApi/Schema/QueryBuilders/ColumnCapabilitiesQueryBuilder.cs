using System.Collections.Generic;

namespace MondayApi.Schema {
    public class ColumnCapabilitiesQueryBuilder : GraphQlQueryBuilder<ColumnCapabilitiesQueryBuilder> {
        private static readonly GraphQlFieldMetadata[] AllFieldMetadata = new[] {
            new GraphQlFieldMetadata { Name = "calculated", IsComplex = true, QueryBuilderType = typeof(CalculatedCapabilityQueryBuilder) }
        };

        protected override string TypeName => "ColumnCapabilities";
        public override IReadOnlyList<GraphQlFieldMetadata> AllFields => AllFieldMetadata;

        public ColumnCapabilitiesQueryBuilder WithCalculated(CalculatedCapabilityQueryBuilder calculatedCapabilityQueryBuilder, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithObjectField("calculated", alias, calculatedCapabilityQueryBuilder, new GraphQlDirective?[] { include, skip });
        public ColumnCapabilitiesQueryBuilder ExceptCalculated() =>
            ExceptField("calculated");
    }
}
