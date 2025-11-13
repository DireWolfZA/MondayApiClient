using System.Collections.Generic;

namespace MondayApi.Schema {
    public class BatteryValueQueryBuilder : GraphQlQueryBuilder<BatteryValueQueryBuilder> {
        private static readonly GraphQlFieldMetadata[] AllFieldMetadata = new[] {
            new GraphQlFieldMetadata { Name = "battery_value", IsComplex = true, QueryBuilderType = typeof(BatteryValueItemQueryBuilder) },
            new GraphQlFieldMetadata { Name = "column", IsComplex = true, QueryBuilderType = typeof(ColumnQueryBuilder) },
            new GraphQlFieldMetadata { Name = "id" },
            new GraphQlFieldMetadata { Name = "text" },
            new GraphQlFieldMetadata { Name = "type" },
            new GraphQlFieldMetadata { Name = "value" }
        };

        protected override string TypeName => "BatteryValue";
        public override IReadOnlyList<GraphQlFieldMetadata> AllFields => AllFieldMetadata;

        public BatteryValueQueryBuilder WithBatteryValue(BatteryValueItemQueryBuilder batteryValueItemQueryBuilder, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithObjectField("battery_value", alias, batteryValueItemQueryBuilder, new GraphQlDirective?[] { include, skip });
        public BatteryValueQueryBuilder ExceptBatteryValue() =>
            ExceptField("battery_value");
        public BatteryValueQueryBuilder WithColumn(ColumnQueryBuilder columnQueryBuilder, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithObjectField("column", alias, columnQueryBuilder, new GraphQlDirective?[] { include, skip });
        public BatteryValueQueryBuilder ExceptColumn() =>
            ExceptField("column");
        public BatteryValueQueryBuilder WithID(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("id", alias, new GraphQlDirective?[] { include, skip });
        public BatteryValueQueryBuilder ExceptID() =>
            ExceptField("id");
        public BatteryValueQueryBuilder WithText(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("text", alias, new GraphQlDirective?[] { include, skip });
        public BatteryValueQueryBuilder ExceptText() =>
            ExceptField("text");
        public BatteryValueQueryBuilder WithType(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("type", alias, new GraphQlDirective?[] { include, skip });
        public BatteryValueQueryBuilder ExceptType() =>
            ExceptField("type");
        public BatteryValueQueryBuilder WithValue(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("value", alias, new GraphQlDirective?[] { include, skip });
        public BatteryValueQueryBuilder ExceptValue() =>
            ExceptField("value");
    }
}
