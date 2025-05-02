using System.Collections.Generic;

namespace MondayApi.Schema {
    public class CustomActivityQueryBuilder : GraphQlQueryBuilder<CustomActivityQueryBuilder> {
        private static readonly GraphQlFieldMetadata[] AllFieldMetadata = new[] {
            new GraphQlFieldMetadata { Name = "id" },
            new GraphQlFieldMetadata { Name = "type" },
            new GraphQlFieldMetadata { Name = "name" },
            new GraphQlFieldMetadata { Name = "icon_id" },
            new GraphQlFieldMetadata { Name = "color" }
        };

        protected override string TypeName => "CustomActivity";
        public override IReadOnlyList<GraphQlFieldMetadata> AllFields => AllFieldMetadata;

        public CustomActivityQueryBuilder WithID(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("id", alias, new GraphQlDirective?[] { include, skip });
        public CustomActivityQueryBuilder ExceptID() =>
            ExceptField("id");
        public CustomActivityQueryBuilder WithType(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("type", alias, new GraphQlDirective?[] { include, skip });
        public CustomActivityQueryBuilder ExceptType() =>
            ExceptField("type");
        public CustomActivityQueryBuilder WithName(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("name", alias, new GraphQlDirective?[] { include, skip });
        public CustomActivityQueryBuilder ExceptName() =>
            ExceptField("name");
        public CustomActivityQueryBuilder WithIconID(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("icon_id", alias, new GraphQlDirective?[] { include, skip });
        public CustomActivityQueryBuilder ExceptIconID() =>
            ExceptField("icon_id");
        public CustomActivityQueryBuilder WithColor(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("color", alias, new GraphQlDirective?[] { include, skip });
        public CustomActivityQueryBuilder ExceptColor() =>
            ExceptField("color");
    }
}
