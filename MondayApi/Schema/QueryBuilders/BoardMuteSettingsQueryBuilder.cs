using System.Collections.Generic;

namespace MondayApi.Schema {
    public class BoardMuteSettingsQueryBuilder : GraphQlQueryBuilder<BoardMuteSettingsQueryBuilder> {
        private static readonly GraphQlFieldMetadata[] AllFieldMetadata = new[] {
            new GraphQlFieldMetadata { Name = "board_id" },
            new GraphQlFieldMetadata { Name = "mute_state" },
            new GraphQlFieldMetadata { Name = "enabled", IsComplex = true }
        };

        protected override string TypeName => "BoardMuteSettings";
        public override IReadOnlyList<GraphQlFieldMetadata> AllFields => AllFieldMetadata;

        public BoardMuteSettingsQueryBuilder WithBoardID(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("board_id", alias, new GraphQlDirective?[] { include, skip });
        public BoardMuteSettingsQueryBuilder ExceptBoardID() =>
            ExceptField("board_id");
        public BoardMuteSettingsQueryBuilder WithMuteState(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("mute_state", alias, new GraphQlDirective?[] { include, skip });
        public BoardMuteSettingsQueryBuilder ExceptMuteState() =>
            ExceptField("mute_state");
        public BoardMuteSettingsQueryBuilder WithEnabled(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("enabled", alias, new GraphQlDirective?[] { include, skip });
        public BoardMuteSettingsQueryBuilder ExceptEnabled() =>
            ExceptField("enabled");
    }
}
