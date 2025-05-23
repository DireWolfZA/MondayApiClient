using System.Collections.Generic;

namespace MondayApi.Schema {
    public class DailyLimitQueryBuilder : GraphQlQueryBuilder<DailyLimitQueryBuilder> {
        private static readonly GraphQlFieldMetadata[] AllFieldMetadata = new[] {
            new GraphQlFieldMetadata { Name = "base" },
            new GraphQlFieldMetadata { Name = "total" }
        };

        protected override string TypeName => "DailyLimit";
        public override IReadOnlyList<GraphQlFieldMetadata> AllFields => AllFieldMetadata;

        public DailyLimitQueryBuilder WithBase(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("base", alias, new GraphQlDirective?[] { include, skip });
        public DailyLimitQueryBuilder ExceptBase() =>
            ExceptField("base");
        public DailyLimitQueryBuilder WithTotal(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("total", alias, new GraphQlDirective?[] { include, skip });
        public DailyLimitQueryBuilder ExceptTotal() =>
            ExceptField("total");
    }
}
