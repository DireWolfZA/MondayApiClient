using System.Collections.Generic;

namespace MondayApi.Schema {
    public class GraphQLHierarchyObjectItemQueryBuilder : GraphQlQueryBuilder<GraphQLHierarchyObjectItemQueryBuilder> {
        private static readonly GraphQlFieldMetadata[] AllFieldMetadata = new[] {
            new GraphQlFieldMetadata { Name = "id" },
            new GraphQlFieldMetadata { Name = "accountId" },
            new GraphQlFieldMetadata { Name = "object", IsComplex = true, QueryBuilderType = typeof(HierarchyObjectIDQueryBuilder) },
            new GraphQlFieldMetadata { Name = "folderId" },
            new GraphQlFieldMetadata { Name = "position" },
            new GraphQlFieldMetadata { Name = "createdAt" },
            new GraphQlFieldMetadata { Name = "updatedAt" }
        };

        protected override string TypeName => "GraphqlHierarchyObjectItem";
        public override IReadOnlyList<GraphQlFieldMetadata> AllFields => AllFieldMetadata;

        public GraphQLHierarchyObjectItemQueryBuilder WithID(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("id", alias, new GraphQlDirective?[] { include, skip });
        public GraphQLHierarchyObjectItemQueryBuilder ExceptID() =>
            ExceptField("id");
        public GraphQLHierarchyObjectItemQueryBuilder WithAccountID(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("accountId", alias, new GraphQlDirective?[] { include, skip });
        public GraphQLHierarchyObjectItemQueryBuilder ExceptAccountID() =>
            ExceptField("accountId");
        public GraphQLHierarchyObjectItemQueryBuilder WithObject(HierarchyObjectIDQueryBuilder hierarchyObjectIdQueryBuilder, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithObjectField("object", alias, hierarchyObjectIdQueryBuilder, new GraphQlDirective?[] { include, skip });
        public GraphQLHierarchyObjectItemQueryBuilder ExceptObject() =>
            ExceptField("object");
        public GraphQLHierarchyObjectItemQueryBuilder WithFolderID(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("folderId", alias, new GraphQlDirective?[] { include, skip });
        public GraphQLHierarchyObjectItemQueryBuilder ExceptFolderID() =>
            ExceptField("folderId");
        public GraphQLHierarchyObjectItemQueryBuilder WithPosition(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("position", alias, new GraphQlDirective?[] { include, skip });
        public GraphQLHierarchyObjectItemQueryBuilder ExceptPosition() =>
            ExceptField("position");
        public GraphQLHierarchyObjectItemQueryBuilder WithCreatedAt(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("createdAt", alias, new GraphQlDirective?[] { include, skip });
        public GraphQLHierarchyObjectItemQueryBuilder ExceptCreatedAt() =>
            ExceptField("createdAt");
        public GraphQLHierarchyObjectItemQueryBuilder WithUpdatedAt(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("updatedAt", alias, new GraphQlDirective?[] { include, skip });
        public GraphQLHierarchyObjectItemQueryBuilder ExceptUpdatedAt() =>
            ExceptField("updatedAt");
    }
}
