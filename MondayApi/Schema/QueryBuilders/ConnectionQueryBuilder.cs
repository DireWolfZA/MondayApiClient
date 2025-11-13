using System.Collections.Generic;

namespace MondayApi.Schema {
    public class ConnectionQueryBuilder : GraphQlQueryBuilder<ConnectionQueryBuilder> {
        private static readonly GraphQlFieldMetadata[] AllFieldMetadata = new[] {
            new GraphQlFieldMetadata { Name = "id" },
            new GraphQlFieldMetadata { Name = "accountId" },
            new GraphQlFieldMetadata { Name = "userId" },
            new GraphQlFieldMetadata { Name = "provider" },
            new GraphQlFieldMetadata { Name = "name" },
            new GraphQlFieldMetadata { Name = "method" },
            new GraphQlFieldMetadata { Name = "providerAccountIdentifier" },
            new GraphQlFieldMetadata { Name = "state" },
            new GraphQlFieldMetadata { Name = "createdAt" },
            new GraphQlFieldMetadata { Name = "updatedAt" }
        };

        protected override string TypeName => "Connection";
        public override IReadOnlyList<GraphQlFieldMetadata> AllFields => AllFieldMetadata;

        public ConnectionQueryBuilder WithID(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("id", alias, new GraphQlDirective?[] { include, skip });
        public ConnectionQueryBuilder ExceptID() =>
            ExceptField("id");
        public ConnectionQueryBuilder WithAccountID(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("accountId", alias, new GraphQlDirective?[] { include, skip });
        public ConnectionQueryBuilder ExceptAccountID() =>
            ExceptField("accountId");
        public ConnectionQueryBuilder WithUserID(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("userId", alias, new GraphQlDirective?[] { include, skip });
        public ConnectionQueryBuilder ExceptUserID() =>
            ExceptField("userId");
        public ConnectionQueryBuilder WithProvider(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("provider", alias, new GraphQlDirective?[] { include, skip });
        public ConnectionQueryBuilder ExceptProvider() =>
            ExceptField("provider");
        public ConnectionQueryBuilder WithName(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("name", alias, new GraphQlDirective?[] { include, skip });
        public ConnectionQueryBuilder ExceptName() =>
            ExceptField("name");
        public ConnectionQueryBuilder WithMethod(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("method", alias, new GraphQlDirective?[] { include, skip });
        public ConnectionQueryBuilder ExceptMethod() =>
            ExceptField("method");
        public ConnectionQueryBuilder WithProviderAccountIdentifier(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("providerAccountIdentifier", alias, new GraphQlDirective?[] { include, skip });
        public ConnectionQueryBuilder ExceptProviderAccountIdentifier() =>
            ExceptField("providerAccountIdentifier");
        public ConnectionQueryBuilder WithState(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("state", alias, new GraphQlDirective?[] { include, skip });
        public ConnectionQueryBuilder ExceptState() =>
            ExceptField("state");
        public ConnectionQueryBuilder WithCreatedAt(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("createdAt", alias, new GraphQlDirective?[] { include, skip });
        public ConnectionQueryBuilder ExceptCreatedAt() =>
            ExceptField("createdAt");
        public ConnectionQueryBuilder WithUpdatedAt(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("updatedAt", alias, new GraphQlDirective?[] { include, skip });
        public ConnectionQueryBuilder ExceptUpdatedAt() =>
            ExceptField("updatedAt");
    }
}
