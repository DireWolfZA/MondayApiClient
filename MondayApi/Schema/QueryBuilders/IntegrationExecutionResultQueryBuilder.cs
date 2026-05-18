using System.Collections.Generic;

namespace MondayApi.Schema {
    public class IntegrationExecutionResultQueryBuilder : GraphQlQueryBuilder<IntegrationExecutionResultQueryBuilder> {
        private static readonly GraphQlFieldMetadata[] AllFieldMetadata = new[] {
            new GraphQlFieldMetadata { Name = "output_fields" }
        };

        protected override string TypeName => "IntegrationExecutionResult";
        public override IReadOnlyList<GraphQlFieldMetadata> AllFields => AllFieldMetadata;

        public IntegrationExecutionResultQueryBuilder WithOutputFields(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("output_fields", alias, new GraphQlDirective?[] { include, skip });
        public IntegrationExecutionResultQueryBuilder ExceptOutputFields() =>
            ExceptField("output_fields");
    }
}
