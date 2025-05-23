using System.Collections.Generic;

namespace MondayApi.Schema {
    public class ManagedColumnQueryBuilder : GraphQlQueryBuilder<ManagedColumnQueryBuilder> {
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
            new GraphQlFieldMetadata { Name = "settings", IsComplex = true, QueryBuilderType = typeof(ColumnSettingsQueryBuilder) }
        };

        protected override string TypeName => "ManagedColumn";
        public override IReadOnlyList<GraphQlFieldMetadata> AllFields => AllFieldMetadata;

        public ManagedColumnQueryBuilder WithID(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("id", alias, new GraphQlDirective?[] { include, skip });
        public ManagedColumnQueryBuilder ExceptID() =>
            ExceptField("id");
        public ManagedColumnQueryBuilder WithTitle(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("title", alias, new GraphQlDirective?[] { include, skip });
        public ManagedColumnQueryBuilder ExceptTitle() =>
            ExceptField("title");
        public ManagedColumnQueryBuilder WithDescription(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("description", alias, new GraphQlDirective?[] { include, skip });
        public ManagedColumnQueryBuilder ExceptDescription() =>
            ExceptField("description");
        public ManagedColumnQueryBuilder WithSettingsJson(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("settings_json", alias, new GraphQlDirective?[] { include, skip });
        public ManagedColumnQueryBuilder ExceptSettingsJson() =>
            ExceptField("settings_json");
        public ManagedColumnQueryBuilder WithCreatedBy(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("created_by", alias, new GraphQlDirective?[] { include, skip });
        public ManagedColumnQueryBuilder ExceptCreatedBy() =>
            ExceptField("created_by");
        public ManagedColumnQueryBuilder WithUpdatedBy(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("updated_by", alias, new GraphQlDirective?[] { include, skip });
        public ManagedColumnQueryBuilder ExceptUpdatedBy() =>
            ExceptField("updated_by");
        public ManagedColumnQueryBuilder WithRevision(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("revision", alias, new GraphQlDirective?[] { include, skip });
        public ManagedColumnQueryBuilder ExceptRevision() =>
            ExceptField("revision");
        public ManagedColumnQueryBuilder WithState(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("state", alias, new GraphQlDirective?[] { include, skip });
        public ManagedColumnQueryBuilder ExceptState() =>
            ExceptField("state");
        public ManagedColumnQueryBuilder WithCreatedAt(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("created_at", alias, new GraphQlDirective?[] { include, skip });
        public ManagedColumnQueryBuilder ExceptCreatedAt() =>
            ExceptField("created_at");
        public ManagedColumnQueryBuilder WithUpdatedAt(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("updated_at", alias, new GraphQlDirective?[] { include, skip });
        public ManagedColumnQueryBuilder ExceptUpdatedAt() =>
            ExceptField("updated_at");
        public ManagedColumnQueryBuilder WithSettings(ColumnSettingsQueryBuilder columnSettingsQueryBuilder, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithObjectField("settings", alias, columnSettingsQueryBuilder, new GraphQlDirective?[] { include, skip });
        public ManagedColumnQueryBuilder ExceptSettings() =>
            ExceptField("settings");
    }
}
