using System.Collections.Generic;

namespace MondayApi.Schema {
    public class WidgetSchemaInfoQueryBuilder : GraphQlQueryBuilder<WidgetSchemaInfoQueryBuilder> {
        private static readonly GraphQlFieldMetadata[] AllFieldMetadata = new[] {
            new GraphQlFieldMetadata { Name = "widget_type" },
            new GraphQlFieldMetadata { Name = "schema" }
        };

        protected override string TypeName => "WidgetSchemaInfo";
        public override IReadOnlyList<GraphQlFieldMetadata> AllFields => AllFieldMetadata;

        public WidgetSchemaInfoQueryBuilder WithWidgetType(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("widget_type", alias, new GraphQlDirective?[] { include, skip });
        public WidgetSchemaInfoQueryBuilder ExceptWidgetType() =>
            ExceptField("widget_type");
        public WidgetSchemaInfoQueryBuilder WithSchema(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("schema", alias, new GraphQlDirective?[] { include, skip });
        public WidgetSchemaInfoQueryBuilder ExceptSchema() =>
            ExceptField("schema");
    }
}
