using System.Collections.Generic;

namespace MondayApi.Schema {
    public class WidgetQueryBuilder : GraphQlQueryBuilder<WidgetQueryBuilder> {
        private static readonly GraphQlFieldMetadata[] AllFieldMetadata = new[] {
            new GraphQlFieldMetadata { Name = "id" },
            new GraphQlFieldMetadata { Name = "parent", IsComplex = true, QueryBuilderType = typeof(WidgetParentOutputQueryBuilder) },
            new GraphQlFieldMetadata { Name = "kind" },
            new GraphQlFieldMetadata { Name = "name" }
        };

        protected override string TypeName => "Widget";
        public override IReadOnlyList<GraphQlFieldMetadata> AllFields => AllFieldMetadata;

        public WidgetQueryBuilder WithID(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("id", alias, new GraphQlDirective?[] { include, skip });
        public WidgetQueryBuilder ExceptID() =>
            ExceptField("id");
        public WidgetQueryBuilder WithParent(WidgetParentOutputQueryBuilder widgetParentOutputQueryBuilder, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithObjectField("parent", alias, widgetParentOutputQueryBuilder, new GraphQlDirective?[] { include, skip });
        public WidgetQueryBuilder ExceptParent() =>
            ExceptField("parent");
        public WidgetQueryBuilder WithKind(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("kind", alias, new GraphQlDirective?[] { include, skip });
        public WidgetQueryBuilder ExceptKind() =>
            ExceptField("kind");
        public WidgetQueryBuilder WithName(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("name", alias, new GraphQlDirective?[] { include, skip });
        public WidgetQueryBuilder ExceptName() =>
            ExceptField("name");
    }
}
