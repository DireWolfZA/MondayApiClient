using System.Collections.Generic;

namespace MondayApi.Schema {
    public class TagQueryBuilder : GraphQlQueryBuilder<TagQueryBuilder> {
        private static readonly GraphQlFieldMetadata[] AllFieldMetadata = new[] {
            new GraphQlFieldMetadata { Name = "color" },
            new GraphQlFieldMetadata { Name = "id" },
            new GraphQlFieldMetadata { Name = "name" }
        };

        protected override string TypeName => "Tag";
        public override IReadOnlyList<GraphQlFieldMetadata> AllFields => AllFieldMetadata;

        public TagQueryBuilder WithColor(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("color", alias, new GraphQlDirective?[] { include, skip });
        public TagQueryBuilder ExceptColor() =>
            ExceptField("color");
        public TagQueryBuilder WithID(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("id", alias, new GraphQlDirective?[] { include, skip });
        public TagQueryBuilder ExceptID() =>
            ExceptField("id");
        public TagQueryBuilder WithName(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("name", alias, new GraphQlDirective?[] { include, skip });
        public TagQueryBuilder ExceptName() =>
            ExceptField("name");
    }
}
