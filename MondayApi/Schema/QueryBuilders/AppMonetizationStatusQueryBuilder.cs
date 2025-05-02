using System.Collections.Generic;

namespace MondayApi.Schema {
    public class AppMonetizationStatusQueryBuilder : GraphQlQueryBuilder<AppMonetizationStatusQueryBuilder> {
        private static readonly GraphQlFieldMetadata[] AllFieldMetadata = new[] {
            new GraphQlFieldMetadata { Name = "is_supported" }
        };

        protected override string TypeName => "AppMonetizationStatus";
        public override IReadOnlyList<GraphQlFieldMetadata> AllFields => AllFieldMetadata;

        public AppMonetizationStatusQueryBuilder WithIsSupported(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("is_supported", alias, new GraphQlDirective?[] { include, skip });
        public AppMonetizationStatusQueryBuilder ExceptIsSupported() =>
            ExceptField("is_supported");
    }
}
