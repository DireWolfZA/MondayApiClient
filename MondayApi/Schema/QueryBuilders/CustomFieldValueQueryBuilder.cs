using System.Collections.Generic;

namespace MondayApi.Schema {
    public class CustomFieldValueQueryBuilder : GraphQlQueryBuilder<CustomFieldValueQueryBuilder> {
        private static readonly GraphQlFieldMetadata[] AllFieldMetadata = new[] {
            new GraphQlFieldMetadata { Name = "custom_field_meta_id" },
            new GraphQlFieldMetadata { Name = "value" }
        };

        protected override string TypeName => "CustomFieldValue";
        public override IReadOnlyList<GraphQlFieldMetadata> AllFields => AllFieldMetadata;

        public CustomFieldValueQueryBuilder WithCustomFieldMetaID(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("custom_field_meta_id", alias, new GraphQlDirective?[] { include, skip });
        public CustomFieldValueQueryBuilder ExceptCustomFieldMetaID() =>
            ExceptField("custom_field_meta_id");
        public CustomFieldValueQueryBuilder WithValue(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("value", alias, new GraphQlDirective?[] { include, skip });
        public CustomFieldValueQueryBuilder ExceptValue() =>
            ExceptField("value");
    }
}
