using System.Collections.Generic;

namespace MondayApi.Schema {
    public class GraphQLFolderQueryBuilder : GraphQlQueryBuilder<GraphQLFolderQueryBuilder> {
        private static readonly GraphQlFieldMetadata[] AllFieldMetadata = new[] {
            new GraphQlFieldMetadata { Name = "id" },
            new GraphQlFieldMetadata { Name = "accountId" },
            new GraphQlFieldMetadata { Name = "name" },
            new GraphQlFieldMetadata { Name = "createdAt" },
            new GraphQlFieldMetadata { Name = "updatedAt" },
            new GraphQlFieldMetadata { Name = "createdBy" }
        };

        protected override string TypeName => "GraphqlFolder";
        public override IReadOnlyList<GraphQlFieldMetadata> AllFields => AllFieldMetadata;

        public GraphQLFolderQueryBuilder WithID(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("id", alias, new GraphQlDirective?[] { include, skip });
        public GraphQLFolderQueryBuilder ExceptID() =>
            ExceptField("id");
        public GraphQLFolderQueryBuilder WithAccountID(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("accountId", alias, new GraphQlDirective?[] { include, skip });
        public GraphQLFolderQueryBuilder ExceptAccountID() =>
            ExceptField("accountId");
        public GraphQLFolderQueryBuilder WithName(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("name", alias, new GraphQlDirective?[] { include, skip });
        public GraphQLFolderQueryBuilder ExceptName() =>
            ExceptField("name");
        public GraphQLFolderQueryBuilder WithCreatedAt(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("createdAt", alias, new GraphQlDirective?[] { include, skip });
        public GraphQLFolderQueryBuilder ExceptCreatedAt() =>
            ExceptField("createdAt");
        public GraphQLFolderQueryBuilder WithUpdatedAt(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("updatedAt", alias, new GraphQlDirective?[] { include, skip });
        public GraphQLFolderQueryBuilder ExceptUpdatedAt() =>
            ExceptField("updatedAt");
        public GraphQLFolderQueryBuilder WithCreatedBy(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("createdBy", alias, new GraphQlDirective?[] { include, skip });
        public GraphQLFolderQueryBuilder ExceptCreatedBy() =>
            ExceptField("createdBy");
    }
}
