using System.Collections.Generic;

namespace MondayApi.Schema {
    public class AggregateGroupByResultQueryBuilder : GraphQlQueryBuilder<AggregateGroupByResultQueryBuilder> {
        private static readonly GraphQlFieldMetadata[] AllFieldMetadata = new[] {
            new GraphQlFieldMetadata { Name = "value_string" },
            new GraphQlFieldMetadata { Name = "value_int" },
            new GraphQlFieldMetadata { Name = "value_float" },
            new GraphQlFieldMetadata { Name = "value_boolean" }
        };

        protected override string TypeName => "AggregateGroupByResult";
        public override IReadOnlyList<GraphQlFieldMetadata> AllFields => AllFieldMetadata;

        public AggregateGroupByResultQueryBuilder WithValueString(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("value_string", alias, new GraphQlDirective?[] { include, skip });
        public AggregateGroupByResultQueryBuilder ExceptValueString() =>
            ExceptField("value_string");
        public AggregateGroupByResultQueryBuilder WithValueInt(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("value_int", alias, new GraphQlDirective?[] { include, skip });
        public AggregateGroupByResultQueryBuilder ExceptValueInt() =>
            ExceptField("value_int");
        public AggregateGroupByResultQueryBuilder WithValueFloat(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("value_float", alias, new GraphQlDirective?[] { include, skip });
        public AggregateGroupByResultQueryBuilder ExceptValueFloat() =>
            ExceptField("value_float");
        public AggregateGroupByResultQueryBuilder WithValueBoolean(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("value_boolean", alias, new GraphQlDirective?[] { include, skip });
        public AggregateGroupByResultQueryBuilder ExceptValueBoolean() =>
            ExceptField("value_boolean");
    }
}
