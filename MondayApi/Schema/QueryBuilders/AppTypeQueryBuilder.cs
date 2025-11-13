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
            new GraphQlFieldMetadata { Name = "photo_url" },
            new GraphQlFieldMetadata { Name = "photo_url_small" },
            new GraphQlFieldMetadata { Name = "kind" },
            new GraphQlFieldMetadata { Name = "status" },
            new GraphQlFieldMetadata { Name = "version_type" },
            new GraphQlFieldMetadata { Name = "description" },
            new GraphQlFieldMetadata { Name = "slug" },
            new GraphQlFieldMetadata { Name = "permissions", IsComplex = true },
            new GraphQlFieldMetadata { Name = "webhook_url" },
            new GraphQlFieldMetadata { Name = "created_by" },
            new GraphQlFieldMetadata { Name = "account_id" },
            new GraphQlFieldMetadata { Name = "collaborators", IsComplex = true, QueryBuilderType = typeof(UserQueryBuilder) },
            new GraphQlFieldMetadata { Name = "features", IsComplex = true, QueryBuilderType = typeof(AppFeatureTypeQueryBuilder) }
        };

        protected override string TypeName => "AppType";
        public override IReadOnlyList<GraphQlFieldMetadata> AllFields => AllFieldMetadata;

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
        public AppTypeQueryBuilder WithPhotoURL(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("photo_url", alias, new GraphQlDirective?[] { include, skip });
        public AppTypeQueryBuilder ExceptPhotoURL() =>
            ExceptField("photo_url");
        public AppTypeQueryBuilder WithPhotoURLSmall(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("photo_url_small", alias, new GraphQlDirective?[] { include, skip });
        public AppTypeQueryBuilder ExceptPhotoURLSmall() =>
            ExceptField("photo_url_small");
        public AppTypeQueryBuilder WithKind(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("kind", alias, new GraphQlDirective?[] { include, skip });
        public AppTypeQueryBuilder ExceptKind() =>
            ExceptField("kind");
        public AppTypeQueryBuilder WithStatus(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("status", alias, new GraphQlDirective?[] { include, skip });
        public AppTypeQueryBuilder ExceptStatus() =>
            ExceptField("status");
        public AppTypeQueryBuilder WithVersionType(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("version_type", alias, new GraphQlDirective?[] { include, skip });
        public AppTypeQueryBuilder ExceptVersionType() =>
            ExceptField("version_type");
        public AppTypeQueryBuilder WithDescription(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("description", alias, new GraphQlDirective?[] { include, skip });
        public AppTypeQueryBuilder ExceptDescription() =>
            ExceptField("description");
        public AppTypeQueryBuilder WithSlug(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("slug", alias, new GraphQlDirective?[] { include, skip });
        public AppTypeQueryBuilder ExceptSlug() =>
            ExceptField("slug");
        public AppTypeQueryBuilder WithPermissions(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("permissions", alias, new GraphQlDirective?[] { include, skip });
        public AppTypeQueryBuilder ExceptPermissions() =>
            ExceptField("permissions");
        public AppTypeQueryBuilder WithWebhookURL(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("webhook_url", alias, new GraphQlDirective?[] { include, skip });
        public AppTypeQueryBuilder ExceptWebhookURL() =>
            ExceptField("webhook_url");
        public AppTypeQueryBuilder WithCreatedBy(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("created_by", alias, new GraphQlDirective?[] { include, skip });
        public AppTypeQueryBuilder ExceptCreatedBy() =>
            ExceptField("created_by");
        public AppTypeQueryBuilder WithAccountID(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("account_id", alias, new GraphQlDirective?[] { include, skip });
        public AppTypeQueryBuilder ExceptAccountID() =>
            ExceptField("account_id");
        public AppTypeQueryBuilder WithCollaborators(UserQueryBuilder userQueryBuilder, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithObjectField("collaborators", alias, userQueryBuilder, new GraphQlDirective?[] { include, skip });
        public AppTypeQueryBuilder ExceptCollaborators() =>
            ExceptField("collaborators");
        public AppTypeQueryBuilder WithFeatures(AppFeatureTypeQueryBuilder appFeatureTypeQueryBuilder, QueryBuilderParameter<bool?>? liveVersionOnly = null, QueryBuilderParameter<int?>? limit = null, QueryBuilderParameter<int?>? page = null, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) {
            var args = new List<QueryBuilderArgumentInfo>();
            if (liveVersionOnly != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "live_version_only", ArgumentValue = liveVersionOnly });
            if (limit != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "limit", ArgumentValue = limit });
            if (page != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "page", ArgumentValue = page });
            return WithObjectField("features", alias, appFeatureTypeQueryBuilder, new GraphQlDirective?[] { include, skip }, args);
        }
        public AppTypeQueryBuilder ExceptFeatures() =>
            ExceptField("features");
    }
}
