using System.Collections.Generic;

namespace MondayApi.Schema {
    public class ObjectQueryBuilder : GraphQlQueryBuilder<ObjectQueryBuilder> {
        private static readonly GraphQlFieldMetadata[] AllFieldMetadata = new[] {
            new GraphQlFieldMetadata { Name = "id" },
            new GraphQlFieldMetadata { Name = "name" },
            new GraphQlFieldMetadata { Name = "description" },
            new GraphQlFieldMetadata { Name = "privacy_kind" },
            new GraphQlFieldMetadata { Name = "folder_id" },
            new GraphQlFieldMetadata { Name = "updated_at" },
            new GraphQlFieldMetadata { Name = "state" },
            new GraphQlFieldMetadata { Name = "creator" },
            new GraphQlFieldMetadata { Name = "workspace_id" },
            new GraphQlFieldMetadata { Name = "owners", IsComplex = true, QueryBuilderType = typeof(UserQueryBuilder) },
            new GraphQlFieldMetadata { Name = "subscribers", IsComplex = true, QueryBuilderType = typeof(UserQueryBuilder) }
        };

        protected override string TypeName => "Object";
        public override IReadOnlyList<GraphQlFieldMetadata> AllFields => AllFieldMetadata;

        public ObjectQueryBuilder WithID(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("id", alias, new GraphQlDirective?[] { include, skip });
        public ObjectQueryBuilder ExceptID() =>
            ExceptField("id");
        public ObjectQueryBuilder WithName(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("name", alias, new GraphQlDirective?[] { include, skip });
        public ObjectQueryBuilder ExceptName() =>
            ExceptField("name");
        public ObjectQueryBuilder WithDescription(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("description", alias, new GraphQlDirective?[] { include, skip });
        public ObjectQueryBuilder ExceptDescription() =>
            ExceptField("description");
        public ObjectQueryBuilder WithPrivacyKind(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("privacy_kind", alias, new GraphQlDirective?[] { include, skip });
        public ObjectQueryBuilder ExceptPrivacyKind() =>
            ExceptField("privacy_kind");
        public ObjectQueryBuilder WithFolderID(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("folder_id", alias, new GraphQlDirective?[] { include, skip });
        public ObjectQueryBuilder ExceptFolderID() =>
            ExceptField("folder_id");
        public ObjectQueryBuilder WithUpdatedAt(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("updated_at", alias, new GraphQlDirective?[] { include, skip });
        public ObjectQueryBuilder ExceptUpdatedAt() =>
            ExceptField("updated_at");
        public ObjectQueryBuilder WithState(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("state", alias, new GraphQlDirective?[] { include, skip });
        public ObjectQueryBuilder ExceptState() =>
            ExceptField("state");
        public ObjectQueryBuilder WithCreator(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("creator", alias, new GraphQlDirective?[] { include, skip });
        public ObjectQueryBuilder ExceptCreator() =>
            ExceptField("creator");
        public ObjectQueryBuilder WithWorkspaceID(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("workspace_id", alias, new GraphQlDirective?[] { include, skip });
        public ObjectQueryBuilder ExceptWorkspaceID() =>
            ExceptField("workspace_id");
        public ObjectQueryBuilder WithOwners(UserQueryBuilder userQueryBuilder, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithObjectField("owners", alias, userQueryBuilder, new GraphQlDirective?[] { include, skip });
        public ObjectQueryBuilder ExceptOwners() =>
            ExceptField("owners");
        public ObjectQueryBuilder WithSubscribers(UserQueryBuilder userQueryBuilder, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithObjectField("subscribers", alias, userQueryBuilder, new GraphQlDirective?[] { include, skip });
        public ObjectQueryBuilder ExceptSubscribers() =>
            ExceptField("subscribers");
    }
}
