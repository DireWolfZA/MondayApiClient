using System.Collections.Generic;

namespace MondayApi.Schema {
    public class PeopleEntityQueryBuilder : GraphQlQueryBuilder<PeopleEntityQueryBuilder> {
        private static readonly GraphQlFieldMetadata[] AllFieldMetadata = new[] {
            new GraphQlFieldMetadata { Name = "id" },
            new GraphQlFieldMetadata { Name = "kind" }
        };

        protected override string TypeName => "PeopleEntity";
        public override IReadOnlyList<GraphQlFieldMetadata> AllFields => AllFieldMetadata;

        public PeopleEntityQueryBuilder WithID(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("id", alias, new GraphQlDirective?[] { include, skip });
        public PeopleEntityQueryBuilder ExceptID() =>
            ExceptField("id");
        public PeopleEntityQueryBuilder WithKind(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("kind", alias, new GraphQlDirective?[] { include, skip });
        public PeopleEntityQueryBuilder ExceptKind() =>
            ExceptField("kind");
    }
}
