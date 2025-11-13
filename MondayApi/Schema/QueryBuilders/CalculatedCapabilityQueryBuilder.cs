using System.Collections.Generic;

namespace MondayApi.Schema {
    public class CalculatedCapabilityQueryBuilder : GraphQlQueryBuilder<CalculatedCapabilityQueryBuilder> {
        private static readonly GraphQlFieldMetadata[] AllFieldMetadata = new[] {
            new GraphQlFieldMetadata { Name = "function" },
            new GraphQlFieldMetadata { Name = "calculated_type" }
        };

        protected override string TypeName => "CalculatedCapability";
        public override IReadOnlyList<GraphQlFieldMetadata> AllFields => AllFieldMetadata;

        public CalculatedCapabilityQueryBuilder WithFunction(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("function", alias, new GraphQlDirective?[] { include, skip });
        public CalculatedCapabilityQueryBuilder ExceptFunction() =>
            ExceptField("function");
        public CalculatedCapabilityQueryBuilder WithCalculatedType(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("calculated_type", alias, new GraphQlDirective?[] { include, skip });
        public CalculatedCapabilityQueryBuilder ExceptCalculatedType() =>
            ExceptField("calculated_type");
    }
}
