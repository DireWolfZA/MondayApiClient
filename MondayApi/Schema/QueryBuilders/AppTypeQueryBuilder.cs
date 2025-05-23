using System.Collections.Generic;

namespace MondayApi.Schema {
    public class AppTypeQueryBuilder : GraphQlQueryBuilder<AppTypeQueryBuilder> {
        private static readonly GraphQlFieldMetadata[] AllFieldMetadata = new[] {
            new GraphQlFieldMetadata { Name = "id" },
            new GraphQlFieldMetadata { Name = "created_at" },
            new GraphQlFieldMetadata { Name = "updated_at" },
            new GraphQlFieldMetadata { Name = "name" },
            new GraphQlFieldMetadata { Name = "api_app_id" },
            new GraphQlFieldMetadata { Name = "client_id" },
            new GraphQlFieldMetadata { Name = "kind" },
            new GraphQlFieldMetadata { Name = "state" },
            new GraphQlFieldMetadata { Name = "user_id" },
            new GraphQlFieldMetadata { Name = "features", IsComplex = true, QueryBuilderType = typeof(AppFeatureTypeQueryBuilder) }
        };

        protected override string TypeName => "AppType";
        public override IReadOnlyList<GraphQlFieldMetadata> AllFields => AllFieldMetadata;

        public AppTypeQueryBuilder WithFeatures(AppFeatureTypeQueryBuilder appFeatureTypeQueryBuilder, QueryBuilderParameter<int?>? limit = null, QueryBuilderParameter<int?>? page = null, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) {
            var args = new List<QueryBuilderArgumentInfo>();
            if (limit != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "limit", ArgumentValue = limit });
            if (page != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "page", ArgumentValue = page });
            return WithObjectField("features", alias, appFeatureTypeQueryBuilder, new GraphQlDirective?[] { include, skip }, args);
        }

        public AppTypeQueryBuilder WithID(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("id", alias, new GraphQlDirective?[] { include, skip });
        public AppTypeQueryBuilder ExceptID() =>
            ExceptField("id");
        public AppTypeQueryBuilder WithCreatedAt(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("created_at", alias, new GraphQlDirective?[] { include, skip });
        public AppTypeQueryBuilder ExceptCreatedAt() =>
            ExceptField("created_at");
        public AppTypeQueryBuilder WithUpdatedAt(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("updated_at", alias, new GraphQlDirective?[] { include, skip });
        public AppTypeQueryBuilder ExceptUpdatedAt() =>
            ExceptField("updated_at");
        public AppTypeQueryBuilder WithName(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("name", alias, new GraphQlDirective?[] { include, skip });
        public AppTypeQueryBuilder ExceptName() =>
            ExceptField("name");
        public AppTypeQueryBuilder WithApiAppID(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("api_app_id", alias, new GraphQlDirective?[] { include, skip });
        public AppTypeQueryBuilder ExceptApiAppID() =>
            ExceptField("api_app_id");
        public AppTypeQueryBuilder WithClientID(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("client_id", alias, new GraphQlDirective?[] { include, skip });
        public AppTypeQueryBuilder ExceptClientID() =>
            ExceptField("client_id");
        public AppTypeQueryBuilder WithKind(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("kind", alias, new GraphQlDirective?[] { include, skip });
        public AppTypeQueryBuilder ExceptKind() =>
            ExceptField("kind");
        public AppTypeQueryBuilder WithState(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("state", alias, new GraphQlDirective?[] { include, skip });
        public AppTypeQueryBuilder ExceptState() =>
            ExceptField("state");
        public AppTypeQueryBuilder WithUserID(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("user_id", alias, new GraphQlDirective?[] { include, skip });
        public AppTypeQueryBuilder ExceptUserID() =>
            ExceptField("user_id");
        public AppTypeQueryBuilder ExceptFeatures() =>
            ExceptField("features");
    }
}
