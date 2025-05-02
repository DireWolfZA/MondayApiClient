using System.Collections.Generic;

namespace MondayApi.Schema {
    public class BoardViewQueryBuilder : GraphQlQueryBuilder<BoardViewQueryBuilder> {
        private static readonly GraphQlFieldMetadata[] AllFieldMetadata = new[] {
            new GraphQlFieldMetadata { Name = "id" },
            new GraphQlFieldMetadata { Name = "name" },
            new GraphQlFieldMetadata { Name = "settings_str" },
            new GraphQlFieldMetadata { Name = "source_view_id" },
            new GraphQlFieldMetadata { Name = "type" },
            new GraphQlFieldMetadata { Name = "view_specific_data_str" }
        };

        protected override string TypeName => "BoardView";
        public override IReadOnlyList<GraphQlFieldMetadata> AllFields => AllFieldMetadata;

        public BoardViewQueryBuilder WithID(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("id", alias, new GraphQlDirective?[] { include, skip });
        public BoardViewQueryBuilder ExceptID() =>
            ExceptField("id");
        public BoardViewQueryBuilder WithName(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("name", alias, new GraphQlDirective?[] { include, skip });
        public BoardViewQueryBuilder ExceptName() =>
            ExceptField("name");
        public BoardViewQueryBuilder WithSettingsStr(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("settings_str", alias, new GraphQlDirective?[] { include, skip });
        public BoardViewQueryBuilder ExceptSettingsStr() =>
            ExceptField("settings_str");
        public BoardViewQueryBuilder WithSourceViewID(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("source_view_id", alias, new GraphQlDirective?[] { include, skip });
        public BoardViewQueryBuilder ExceptSourceViewID() =>
            ExceptField("source_view_id");
        public BoardViewQueryBuilder WithType(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("type", alias, new GraphQlDirective?[] { include, skip });
        public BoardViewQueryBuilder ExceptType() =>
            ExceptField("type");
        public BoardViewQueryBuilder WithViewSpecificDataStr(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("view_specific_data_str", alias, new GraphQlDirective?[] { include, skip });
        public BoardViewQueryBuilder ExceptViewSpecificDataStr() =>
            ExceptField("view_specific_data_str");
    }
}
