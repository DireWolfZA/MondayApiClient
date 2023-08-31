using System.Collections.Generic;

namespace MondayApi.Schema {
    public class TagQueryBuilder : GraphQlQueryBuilder<TagQueryBuilder> {
        private static readonly GraphQlFieldMetadata[] AllFieldMetadata = new[] {
            new GraphQlFieldMetadata { Name = "color" },
            new GraphQlFieldMetadata { Name = "id" },
            new GraphQlFieldMetadata { Name = "name" }
        };

        protected override string TypeName { get { return "Tag"; } }

        public override IReadOnlyList<GraphQlFieldMetadata> AllFields { get { return AllFieldMetadata; } }

        public TagQueryBuilder WithColor(string alias = null, IncludeDirective include = null, SkipDirective skip = null) {
            return WithScalarField("color", alias, new GraphQlDirective[] { include, skip });
        }

        public TagQueryBuilder ExceptColor() {
            return ExceptField("color");
        }

        public TagQueryBuilder WithId(string alias = null, IncludeDirective include = null, SkipDirective skip = null) {
            return WithScalarField("id", alias, new GraphQlDirective[] { include, skip });
        }

        public TagQueryBuilder ExceptId() {
            return ExceptField("id");
        }

        public TagQueryBuilder WithName(string alias = null, IncludeDirective include = null, SkipDirective skip = null) {
            return WithScalarField("name", alias, new GraphQlDirective[] { include, skip });
        }

        public TagQueryBuilder ExceptName() {
            return ExceptField("name");
        }
    }
}
