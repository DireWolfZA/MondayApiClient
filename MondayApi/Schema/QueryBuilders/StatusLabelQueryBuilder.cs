using System.Collections.Generic;

namespace MondayApi.Schema {
    public class StatusLabelQueryBuilder : GraphQlQueryBuilder<StatusLabelQueryBuilder> {
        private static readonly GraphQlFieldMetadata[] AllFieldMetadata = new[] {
            new GraphQlFieldMetadata { Name = "id" },
            new GraphQlFieldMetadata { Name = "label" },
            new GraphQlFieldMetadata { Name = "color" },
            new GraphQlFieldMetadata { Name = "index" },
            new GraphQlFieldMetadata { Name = "description" },
            new GraphQlFieldMetadata { Name = "is_deactivated" },
            new GraphQlFieldMetadata { Name = "is_done" }
        };

        protected override string TypeName => "StatusLabel";
        public override IReadOnlyList<GraphQlFieldMetadata> AllFields => AllFieldMetadata;

        public StatusLabelQueryBuilder WithID(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("id", alias, new GraphQlDirective?[] { include, skip });
        public StatusLabelQueryBuilder ExceptID() =>
            ExceptField("id");
        public StatusLabelQueryBuilder WithLabel(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("label", alias, new GraphQlDirective?[] { include, skip });
        public StatusLabelQueryBuilder ExceptLabel() =>
            ExceptField("label");
        public StatusLabelQueryBuilder WithColor(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("color", alias, new GraphQlDirective?[] { include, skip });
        public StatusLabelQueryBuilder ExceptColor() =>
            ExceptField("color");
        public StatusLabelQueryBuilder WithIndex(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("index", alias, new GraphQlDirective?[] { include, skip });
        public StatusLabelQueryBuilder ExceptIndex() =>
            ExceptField("index");
        public StatusLabelQueryBuilder WithDescription(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("description", alias, new GraphQlDirective?[] { include, skip });
        public StatusLabelQueryBuilder ExceptDescription() =>
            ExceptField("description");
        public StatusLabelQueryBuilder WithIsDeactivated(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("is_deactivated", alias, new GraphQlDirective?[] { include, skip });
        public StatusLabelQueryBuilder ExceptIsDeactivated() =>
            ExceptField("is_deactivated");
        public StatusLabelQueryBuilder WithIsDone(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("is_done", alias, new GraphQlDirective?[] { include, skip });
        public StatusLabelQueryBuilder ExceptIsDone() =>
            ExceptField("is_done");
    }
}
