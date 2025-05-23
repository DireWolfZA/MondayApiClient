using System.Collections.Generic;

namespace MondayApi.Schema {
    public class DropdownColumnSettingsQueryBuilder : GraphQlQueryBuilder<DropdownColumnSettingsQueryBuilder> {
        private static readonly GraphQlFieldMetadata[] AllFieldMetadata = new[] {
            new GraphQlFieldMetadata { Name = "type" },
            new GraphQlFieldMetadata { Name = "labels", IsComplex = true, QueryBuilderType = typeof(DropdownLabelQueryBuilder) }
        };

        protected override string TypeName => "DropdownColumnSettings";
        public override IReadOnlyList<GraphQlFieldMetadata> AllFields => AllFieldMetadata;

        public DropdownColumnSettingsQueryBuilder WithType(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("type", alias, new GraphQlDirective?[] { include, skip });
        public DropdownColumnSettingsQueryBuilder ExceptType() =>
            ExceptField("type");
        public DropdownColumnSettingsQueryBuilder WithLabels(DropdownLabelQueryBuilder dropdownLabelQueryBuilder, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithObjectField("labels", alias, dropdownLabelQueryBuilder, new GraphQlDirective?[] { include, skip });
        public DropdownColumnSettingsQueryBuilder ExceptLabels() =>
            ExceptField("labels");
    }
}
