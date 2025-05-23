using System.Collections.Generic;

namespace MondayApi.Schema {
    public class DropdownLabelQueryBuilder : GraphQlQueryBuilder<DropdownLabelQueryBuilder> {
        private static readonly GraphQlFieldMetadata[] AllFieldMetadata = new[] {
            new GraphQlFieldMetadata { Name = "id" },
            new GraphQlFieldMetadata { Name = "label" },
            new GraphQlFieldMetadata { Name = "is_deactivated" }
        };

        protected override string TypeName => "DropdownLabel";
        public override IReadOnlyList<GraphQlFieldMetadata> AllFields => AllFieldMetadata;

        public DropdownLabelQueryBuilder WithID(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("id", alias, new GraphQlDirective?[] { include, skip });
        public DropdownLabelQueryBuilder ExceptID() =>
            ExceptField("id");
        public DropdownLabelQueryBuilder WithLabel(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("label", alias, new GraphQlDirective?[] { include, skip });
        public DropdownLabelQueryBuilder ExceptLabel() =>
            ExceptField("label");
        public DropdownLabelQueryBuilder WithIsDeactivated(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("is_deactivated", alias, new GraphQlDirective?[] { include, skip });
        public DropdownLabelQueryBuilder ExceptIsDeactivated() =>
            ExceptField("is_deactivated");
    }
}
