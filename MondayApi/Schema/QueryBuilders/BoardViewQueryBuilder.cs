using System.Collections.Generic;

namespace MondayApi.Schema {
    public class BoardViewQueryBuilder : GraphQlQueryBuilder<BoardViewQueryBuilder> {
        private static readonly GraphQlFieldMetadata[] AllFieldMetadata = new[] {
            new GraphQlFieldMetadata { Name = "id" },
            new GraphQlFieldMetadata { Name = "name" },
            new GraphQlFieldMetadata { Name = "type" },
            new GraphQlFieldMetadata { Name = "settings_str" },
            new GraphQlFieldMetadata { Name = "view_specific_data_str" },
            new GraphQlFieldMetadata { Name = "source_view_id" },
            new GraphQlFieldMetadata { Name = "settings" },
            new GraphQlFieldMetadata { Name = "sort" },
            new GraphQlFieldMetadata { Name = "filter_user_id" },
            new GraphQlFieldMetadata { Name = "filter_team_id" },
            new GraphQlFieldMetadata { Name = "tags", IsComplex = true },
            new GraphQlFieldMetadata { Name = "filter" },
            new GraphQlFieldMetadata { Name = "access_level" }
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
        public BoardViewQueryBuilder WithType(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("type", alias, new GraphQlDirective?[] { include, skip });
        public BoardViewQueryBuilder ExceptType() =>
            ExceptField("type");
        public BoardViewQueryBuilder WithSettingsStr(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("settings_str", alias, new GraphQlDirective?[] { include, skip });
        public BoardViewQueryBuilder ExceptSettingsStr() =>
            ExceptField("settings_str");
        public BoardViewQueryBuilder WithViewSpecificDataStr(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("view_specific_data_str", alias, new GraphQlDirective?[] { include, skip });
        public BoardViewQueryBuilder ExceptViewSpecificDataStr() =>
            ExceptField("view_specific_data_str");
        public BoardViewQueryBuilder WithSourceViewID(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("source_view_id", alias, new GraphQlDirective?[] { include, skip });
        public BoardViewQueryBuilder ExceptSourceViewID() =>
            ExceptField("source_view_id");
        public BoardViewQueryBuilder WithSettings(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("settings", alias, new GraphQlDirective?[] { include, skip });
        public BoardViewQueryBuilder ExceptSettings() =>
            ExceptField("settings");
        public BoardViewQueryBuilder WithSort(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("sort", alias, new GraphQlDirective?[] { include, skip });
        public BoardViewQueryBuilder ExceptSort() =>
            ExceptField("sort");
        public BoardViewQueryBuilder WithFilterUserID(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("filter_user_id", alias, new GraphQlDirective?[] { include, skip });
        public BoardViewQueryBuilder ExceptFilterUserID() =>
            ExceptField("filter_user_id");
        public BoardViewQueryBuilder WithFilterTeamID(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("filter_team_id", alias, new GraphQlDirective?[] { include, skip });
        public BoardViewQueryBuilder ExceptFilterTeamID() =>
            ExceptField("filter_team_id");
        public BoardViewQueryBuilder WithTags(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("tags", alias, new GraphQlDirective?[] { include, skip });
        public BoardViewQueryBuilder ExceptTags() =>
            ExceptField("tags");
        public BoardViewQueryBuilder WithFilter(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("filter", alias, new GraphQlDirective?[] { include, skip });
        public BoardViewQueryBuilder ExceptFilter() =>
            ExceptField("filter");
        public BoardViewQueryBuilder WithAccessLevel(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("access_level", alias, new GraphQlDirective?[] { include, skip });
        public BoardViewQueryBuilder ExceptAccessLevel() =>
            ExceptField("access_level");
    }
}
