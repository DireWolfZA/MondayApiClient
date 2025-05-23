using System.Collections.Generic;

namespace MondayApi.Schema {
    public class StatusManagedColumnQueryBuilder : GraphQlQueryBuilder<StatusManagedColumnQueryBuilder> {
        private static readonly GraphQlFieldMetadata[] AllFieldMetadata = new[] {
            new GraphQlFieldMetadata { Name = "id" },
            new GraphQlFieldMetadata { Name = "title" },
            new GraphQlFieldMetadata { Name = "description" },
            new GraphQlFieldMetadata { Name = "settings_json" },
            new GraphQlFieldMetadata { Name = "created_by" },
            new GraphQlFieldMetadata { Name = "updated_by" },
            new GraphQlFieldMetadata { Name = "revision" },
            new GraphQlFieldMetadata { Name = "state" },
            new GraphQlFieldMetadata { Name = "created_at" },
            new GraphQlFieldMetadata { Name = "updated_at" },
            new GraphQlFieldMetadata { Name = "settings", IsComplex = true, QueryBuilderType = typeof(StatusColumnSettingsQueryBuilder) }
        };

        protected override string TypeName => "StatusManagedColumn";
        public override IReadOnlyList<GraphQlFieldMetadata> AllFields => AllFieldMetadata;

        public StatusManagedColumnQueryBuilder WithID(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("id", alias, new GraphQlDirective?[] { include, skip });
        public StatusManagedColumnQueryBuilder ExceptID() =>
            ExceptField("id");
        public StatusManagedColumnQueryBuilder WithTitle(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("title", alias, new GraphQlDirective?[] { include, skip });
        public StatusManagedColumnQueryBuilder ExceptTitle() =>
            ExceptField("title");
        public StatusManagedColumnQueryBuilder WithDescription(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("description", alias, new GraphQlDirective?[] { include, skip });
        public StatusManagedColumnQueryBuilder ExceptDescription() =>
            ExceptField("description");
        public StatusManagedColumnQueryBuilder WithSettingsJson(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("settings_json", alias, new GraphQlDirective?[] { include, skip });
        public StatusManagedColumnQueryBuilder ExceptSettingsJson() =>
            ExceptField("settings_json");
        public StatusManagedColumnQueryBuilder WithCreatedBy(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("created_by", alias, new GraphQlDirective?[] { include, skip });
        public StatusManagedColumnQueryBuilder ExceptCreatedBy() =>
            ExceptField("created_by");
        public StatusManagedColumnQueryBuilder WithUpdatedBy(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("updated_by", alias, new GraphQlDirective?[] { include, skip });
        public StatusManagedColumnQueryBuilder ExceptUpdatedBy() =>
            ExceptField("updated_by");
        public StatusManagedColumnQueryBuilder WithRevision(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("revision", alias, new GraphQlDirective?[] { include, skip });
        public StatusManagedColumnQueryBuilder ExceptRevision() =>
            ExceptField("revision");
        public StatusManagedColumnQueryBuilder WithState(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("state", alias, new GraphQlDirective?[] { include, skip });
        public StatusManagedColumnQueryBuilder ExceptState() =>
            ExceptField("state");
        public StatusManagedColumnQueryBuilder WithCreatedAt(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("created_at", alias, new GraphQlDirective?[] { include, skip });
        public StatusManagedColumnQueryBuilder ExceptCreatedAt() =>
            ExceptField("created_at");
        public StatusManagedColumnQueryBuilder WithUpdatedAt(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("updated_at", alias, new GraphQlDirective?[] { include, skip });
        public StatusManagedColumnQueryBuilder ExceptUpdatedAt() =>
            ExceptField("updated_at");
        public StatusManagedColumnQueryBuilder WithSettings(StatusColumnSettingsQueryBuilder statusColumnSettingsQueryBuilder, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithObjectField("settings", alias, statusColumnSettingsQueryBuilder, new GraphQlDirective?[] { include, skip });
        public StatusManagedColumnQueryBuilder ExceptSettings() =>
            ExceptField("settings");
    }
}
