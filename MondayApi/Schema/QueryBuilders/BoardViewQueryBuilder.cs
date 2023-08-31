using System.Collections.Generic;

namespace MondayApi.Schema {
    public class BoardViewQueryBuilder : GraphQlQueryBuilder<BoardViewQueryBuilder> {
        private static readonly GraphQlFieldMetadata[] AllFieldMetadata = new[] {
            new GraphQlFieldMetadata { Name = "id" },
            new GraphQlFieldMetadata { Name = "name" },
            new GraphQlFieldMetadata { Name = "settings_str" },
            new GraphQlFieldMetadata { Name = "type" },
            new GraphQlFieldMetadata { Name = "view_specific_data_str" }
        };

        protected override string TypeName { get { return "BoardView"; } }

        public override IReadOnlyList<GraphQlFieldMetadata> AllFields { get { return AllFieldMetadata; } }

        public BoardViewQueryBuilder WithId(string alias = null, IncludeDirective include = null, SkipDirective skip = null) {
            return WithScalarField("id", alias, new GraphQlDirective[] { include, skip });
        }

        public BoardViewQueryBuilder ExceptId() {
            return ExceptField("id");
        }

        public BoardViewQueryBuilder WithName(string alias = null, IncludeDirective include = null, SkipDirective skip = null) {
            return WithScalarField("name", alias, new GraphQlDirective[] { include, skip });
        }

        public BoardViewQueryBuilder ExceptName() {
            return ExceptField("name");
        }

        public BoardViewQueryBuilder WithSettingsStr(string alias = null, IncludeDirective include = null, SkipDirective skip = null) {
            return WithScalarField("settings_str", alias, new GraphQlDirective[] { include, skip });
        }

        public BoardViewQueryBuilder ExceptSettingsStr() {
            return ExceptField("settings_str");
        }

        public BoardViewQueryBuilder WithType(string alias = null, IncludeDirective include = null, SkipDirective skip = null) {
            return WithScalarField("type", alias, new GraphQlDirective[] { include, skip });
        }

        public BoardViewQueryBuilder ExceptType() {
            return ExceptField("type");
        }

        public BoardViewQueryBuilder WithViewSpecificDataStr(string alias = null, IncludeDirective include = null, SkipDirective skip = null) {
            return WithScalarField("view_specific_data_str", alias, new GraphQlDirective[] { include, skip });
        }

        public BoardViewQueryBuilder ExceptViewSpecificDataStr() {
            return ExceptField("view_specific_data_str");
        }
    }
}
