using System.Collections.Generic;

namespace MondayApi.Schema {
    public class BatteryValueItemQueryBuilder : GraphQlQueryBuilder<BatteryValueItemQueryBuilder> {
        private static readonly GraphQlFieldMetadata[] AllFieldMetadata = new[] {
            new GraphQlFieldMetadata { Name = "count" },
            new GraphQlFieldMetadata { Name = "key" }
        };

        protected override string TypeName => "BatteryValueItem";
        public override IReadOnlyList<GraphQlFieldMetadata> AllFields => AllFieldMetadata;

        public BatteryValueItemQueryBuilder WithCount(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("count", alias, new GraphQlDirective?[] { include, skip });
        public BatteryValueItemQueryBuilder ExceptCount() =>
            ExceptField("count");
        public BatteryValueItemQueryBuilder WithKey(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("key", alias, new GraphQlDirective?[] { include, skip });
        public BatteryValueItemQueryBuilder ExceptKey() =>
            ExceptField("key");
    }
}
