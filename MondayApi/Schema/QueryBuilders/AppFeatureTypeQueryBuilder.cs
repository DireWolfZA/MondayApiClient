using System.Collections.Generic;

namespace MondayApi.Schema {
    public class AppFeatureTypeQueryBuilder : GraphQlQueryBuilder<AppFeatureTypeQueryBuilder> {
        private static readonly GraphQlFieldMetadata[] AllFieldMetadata = new[] {
            new GraphQlFieldMetadata { Name = "id" },
            new GraphQlFieldMetadata { Name = "created_at" },
            new GraphQlFieldMetadata { Name = "updated_at" },
            new GraphQlFieldMetadata { Name = "name" },
            new GraphQlFieldMetadata { Name = "app_id" },
            new GraphQlFieldMetadata { Name = "type" },
            new GraphQlFieldMetadata { Name = "data" }
        };

        protected override string TypeName => "AppFeatureType";
        public override IReadOnlyList<GraphQlFieldMetadata> AllFields => AllFieldMetadata;

        public AppFeatureTypeQueryBuilder WithID(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("id", alias, new GraphQlDirective?[] { include, skip });
        public AppFeatureTypeQueryBuilder ExceptID() =>
            ExceptField("id");
        public AppFeatureTypeQueryBuilder WithCreatedAt(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("created_at", alias, new GraphQlDirective?[] { include, skip });
        public AppFeatureTypeQueryBuilder ExceptCreatedAt() =>
            ExceptField("created_at");
        public AppFeatureTypeQueryBuilder WithUpdatedAt(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("updated_at", alias, new GraphQlDirective?[] { include, skip });
        public AppFeatureTypeQueryBuilder ExceptUpdatedAt() =>
            ExceptField("updated_at");
        public AppFeatureTypeQueryBuilder WithName(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("name", alias, new GraphQlDirective?[] { include, skip });
        public AppFeatureTypeQueryBuilder ExceptName() =>
            ExceptField("name");
        public AppFeatureTypeQueryBuilder WithAppID(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("app_id", alias, new GraphQlDirective?[] { include, skip });
        public AppFeatureTypeQueryBuilder ExceptAppID() =>
            ExceptField("app_id");
        public AppFeatureTypeQueryBuilder WithType(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("type", alias, new GraphQlDirective?[] { include, skip });
        public AppFeatureTypeQueryBuilder ExceptType() =>
            ExceptField("type");
        public AppFeatureTypeQueryBuilder WithData(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("data", alias, new GraphQlDirective?[] { include, skip });
        public AppFeatureTypeQueryBuilder ExceptData() =>
            ExceptField("data");
    }
}
