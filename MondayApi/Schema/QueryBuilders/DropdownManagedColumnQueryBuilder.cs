using System.Collections.Generic;

namespace MondayApi.Schema {
    public class DropdownManagedColumnQueryBuilder : GraphQlQueryBuilder<DropdownManagedColumnQueryBuilder> {
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
            new GraphQlFieldMetadata { Name = "settings", IsComplex = true, QueryBuilderType = typeof(DropdownColumnSettingsQueryBuilder) }
        };

        protected override string TypeName => "DropdownManagedColumn";
        public override IReadOnlyList<GraphQlFieldMetadata> AllFields => AllFieldMetadata;

        public DropdownManagedColumnQueryBuilder WithID(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("id", alias, new GraphQlDirective?[] { include, skip });
        public DropdownManagedColumnQueryBuilder ExceptID() =>
            ExceptField("id");
        public DropdownManagedColumnQueryBuilder WithTitle(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("title", alias, new GraphQlDirective?[] { include, skip });
        public DropdownManagedColumnQueryBuilder ExceptTitle() =>
            ExceptField("title");
        public DropdownManagedColumnQueryBuilder WithDescription(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("description", alias, new GraphQlDirective?[] { include, skip });
        public DropdownManagedColumnQueryBuilder ExceptDescription() =>
            ExceptField("description");
        public DropdownManagedColumnQueryBuilder WithSettingsJson(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("settings_json", alias, new GraphQlDirective?[] { include, skip });
        public DropdownManagedColumnQueryBuilder ExceptSettingsJson() =>
            ExceptField("settings_json");
        public DropdownManagedColumnQueryBuilder WithCreatedBy(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("created_by", alias, new GraphQlDirective?[] { include, skip });
        public DropdownManagedColumnQueryBuilder ExceptCreatedBy() =>
            ExceptField("created_by");
        public DropdownManagedColumnQueryBuilder WithUpdatedBy(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("updated_by", alias, new GraphQlDirective?[] { include, skip });
        public DropdownManagedColumnQueryBuilder ExceptUpdatedBy() =>
            ExceptField("updated_by");
        public DropdownManagedColumnQueryBuilder WithRevision(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("revision", alias, new GraphQlDirective?[] { include, skip });
        public DropdownManagedColumnQueryBuilder ExceptRevision() =>
            ExceptField("revision");
        public DropdownManagedColumnQueryBuilder WithState(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("state", alias, new GraphQlDirective?[] { include, skip });
        public DropdownManagedColumnQueryBuilder ExceptState() =>
            ExceptField("state");
        public DropdownManagedColumnQueryBuilder WithCreatedAt(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("created_at", alias, new GraphQlDirective?[] { include, skip });
        public DropdownManagedColumnQueryBuilder ExceptCreatedAt() =>
            ExceptField("created_at");
        public DropdownManagedColumnQueryBuilder WithUpdatedAt(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("updated_at", alias, new GraphQlDirective?[] { include, skip });
        public DropdownManagedColumnQueryBuilder ExceptUpdatedAt() =>
            ExceptField("updated_at");
        public DropdownManagedColumnQueryBuilder WithSettings(DropdownColumnSettingsQueryBuilder dropdownColumnSettingsQueryBuilder, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithObjectField("settings", alias, dropdownColumnSettingsQueryBuilder, new GraphQlDirective?[] { include, skip });
        public DropdownManagedColumnQueryBuilder ExceptSettings() =>
            ExceptField("settings");
    }
}
