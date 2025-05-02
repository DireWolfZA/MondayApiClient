using System.Collections.Generic;

namespace MondayApi.Schema {
    public class AppsMonetizationInfoQueryBuilder : GraphQlQueryBuilder<AppsMonetizationInfoQueryBuilder> {
        private static readonly GraphQlFieldMetadata[] AllFieldMetadata = new[] {
            new GraphQlFieldMetadata { Name = "seats_count" }
        };

        protected override string TypeName => "AppsMonetizationInfo";
        public override IReadOnlyList<GraphQlFieldMetadata> AllFields => AllFieldMetadata;

        public AppsMonetizationInfoQueryBuilder WithSeatsCount(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("seats_count", alias, new GraphQlDirective?[] { include, skip });
        public AppsMonetizationInfoQueryBuilder ExceptSeatsCount() =>
            ExceptField("seats_count");
    }
}
