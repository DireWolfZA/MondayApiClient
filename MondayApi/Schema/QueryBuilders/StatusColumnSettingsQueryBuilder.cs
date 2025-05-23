using System.Collections.Generic;

namespace MondayApi.Schema {
    public class StatusColumnSettingsQueryBuilder : GraphQlQueryBuilder<StatusColumnSettingsQueryBuilder> {
        private static readonly GraphQlFieldMetadata[] AllFieldMetadata = new[] {
            new GraphQlFieldMetadata { Name = "type" },
            new GraphQlFieldMetadata { Name = "labels", IsComplex = true, QueryBuilderType = typeof(StatusLabelQueryBuilder) }
        };

        protected override string TypeName => "StatusColumnSettings";
        public override IReadOnlyList<GraphQlFieldMetadata> AllFields => AllFieldMetadata;

        public StatusColumnSettingsQueryBuilder WithType(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("type", alias, new GraphQlDirective?[] { include, skip });
        public StatusColumnSettingsQueryBuilder ExceptType() =>
            ExceptField("type");
        public StatusColumnSettingsQueryBuilder WithLabels(StatusLabelQueryBuilder statusLabelQueryBuilder, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithObjectField("labels", alias, statusLabelQueryBuilder, new GraphQlDirective?[] { include, skip });
        public StatusColumnSettingsQueryBuilder ExceptLabels() =>
            ExceptField("labels");
    }
}
