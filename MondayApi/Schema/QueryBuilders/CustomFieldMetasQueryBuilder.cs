using System.Collections.Generic;

namespace MondayApi.Schema {
    public class CustomFieldMetasQueryBuilder : GraphQlQueryBuilder<CustomFieldMetasQueryBuilder> {
        private static readonly GraphQlFieldMetadata[] AllFieldMetadata = new[] {
            new GraphQlFieldMetadata { Name = "description" },
            new GraphQlFieldMetadata { Name = "editable" },
            new GraphQlFieldMetadata { Name = "field_type" },
            new GraphQlFieldMetadata { Name = "flagged" },
            new GraphQlFieldMetadata { Name = "icon" },
            new GraphQlFieldMetadata { Name = "id" },
            new GraphQlFieldMetadata { Name = "position" },
            new GraphQlFieldMetadata { Name = "title" }
        };

        protected override string TypeName => "CustomFieldMetas";
        public override IReadOnlyList<GraphQlFieldMetadata> AllFields => AllFieldMetadata;

        public CustomFieldMetasQueryBuilder WithDescription(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("description", alias, new GraphQlDirective?[] { include, skip });
        public CustomFieldMetasQueryBuilder ExceptDescription() =>
            ExceptField("description");
        public CustomFieldMetasQueryBuilder WithEditable(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("editable", alias, new GraphQlDirective?[] { include, skip });
        public CustomFieldMetasQueryBuilder ExceptEditable() =>
            ExceptField("editable");
        public CustomFieldMetasQueryBuilder WithFieldType(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("field_type", alias, new GraphQlDirective?[] { include, skip });
        public CustomFieldMetasQueryBuilder ExceptFieldType() =>
            ExceptField("field_type");
        public CustomFieldMetasQueryBuilder WithFlagged(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("flagged", alias, new GraphQlDirective?[] { include, skip });
        public CustomFieldMetasQueryBuilder ExceptFlagged() =>
            ExceptField("flagged");
        public CustomFieldMetasQueryBuilder WithIcon(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("icon", alias, new GraphQlDirective?[] { include, skip });
        public CustomFieldMetasQueryBuilder ExceptIcon() =>
            ExceptField("icon");
        public CustomFieldMetasQueryBuilder WithID(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("id", alias, new GraphQlDirective?[] { include, skip });
        public CustomFieldMetasQueryBuilder ExceptID() =>
            ExceptField("id");
        public CustomFieldMetasQueryBuilder WithPosition(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("position", alias, new GraphQlDirective?[] { include, skip });
        public CustomFieldMetasQueryBuilder ExceptPosition() =>
            ExceptField("position");
        public CustomFieldMetasQueryBuilder WithTitle(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("title", alias, new GraphQlDirective?[] { include, skip });
        public CustomFieldMetasQueryBuilder ExceptTitle() =>
            ExceptField("title");
    }
}
