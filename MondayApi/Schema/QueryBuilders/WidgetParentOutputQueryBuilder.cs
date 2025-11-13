using System.Collections.Generic;

namespace MondayApi.Schema {
    public class WidgetParentOutputQueryBuilder : GraphQlQueryBuilder<WidgetParentOutputQueryBuilder> {
        private static readonly GraphQlFieldMetadata[] AllFieldMetadata = new[] {
            new GraphQlFieldMetadata { Name = "kind" },
            new GraphQlFieldMetadata { Name = "id" }
        };

        protected override string TypeName => "WidgetParentOutput";
        public override IReadOnlyList<GraphQlFieldMetadata> AllFields => AllFieldMetadata;

        public WidgetParentOutputQueryBuilder WithKind(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("kind", alias, new GraphQlDirective?[] { include, skip });
        public WidgetParentOutputQueryBuilder ExceptKind() =>
            ExceptField("kind");
        public WidgetParentOutputQueryBuilder WithID(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("id", alias, new GraphQlDirective?[] { include, skip });
        public WidgetParentOutputQueryBuilder ExceptID() =>
            ExceptField("id");
    }
}
