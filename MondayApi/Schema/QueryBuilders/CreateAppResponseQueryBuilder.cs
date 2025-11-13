using System.Collections.Generic;

namespace MondayApi.Schema {
    public class CreateAppResponseQueryBuilder : GraphQlQueryBuilder<CreateAppResponseQueryBuilder> {
        private static readonly GraphQlFieldMetadata[] AllFieldMetadata = new[] {
            new GraphQlFieldMetadata { Name = "id" },
            new GraphQlFieldMetadata { Name = "api_app_id" },
            new GraphQlFieldMetadata { Name = "client_id" },
            new GraphQlFieldMetadata { Name = "client_secret" },
            new GraphQlFieldMetadata { Name = "signing_secret" }
        };

        protected override string TypeName => "CreateAppResponse";
        public override IReadOnlyList<GraphQlFieldMetadata> AllFields => AllFieldMetadata;

        public CreateAppResponseQueryBuilder WithID(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("id", alias, new GraphQlDirective?[] { include, skip });
        public CreateAppResponseQueryBuilder ExceptID() =>
            ExceptField("id");
        public CreateAppResponseQueryBuilder WithAPIAppID(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("api_app_id", alias, new GraphQlDirective?[] { include, skip });
        public CreateAppResponseQueryBuilder ExceptAPIAppID() =>
            ExceptField("api_app_id");
        public CreateAppResponseQueryBuilder WithClientID(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("client_id", alias, new GraphQlDirective?[] { include, skip });
        public CreateAppResponseQueryBuilder ExceptClientID() =>
            ExceptField("client_id");
        public CreateAppResponseQueryBuilder WithClientSecret(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("client_secret", alias, new GraphQlDirective?[] { include, skip });
        public CreateAppResponseQueryBuilder ExceptClientSecret() =>
            ExceptField("client_secret");
        public CreateAppResponseQueryBuilder WithSigningSecret(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("signing_secret", alias, new GraphQlDirective?[] { include, skip });
        public CreateAppResponseQueryBuilder ExceptSigningSecret() =>
            ExceptField("signing_secret");
    }
}
