using System.Collections.Generic;

namespace MondayApi.Schema {
    public class CustomOutputFieldConfigQueryBuilder : GraphQlQueryBuilder<CustomOutputFieldConfigQueryBuilder> {
        private static readonly GraphQlFieldMetadata[] AllFieldMetadata = new[] {
            new GraphQlFieldMetadata { Name = "id" },
            new GraphQlFieldMetadata { Name = "fieldKey" },
            new GraphQlFieldMetadata { Name = "fieldTitle" },
            new GraphQlFieldMetadata { Name = "isNullable" },
            new GraphQlFieldMetadata { Name = "isArray" },
            new GraphQlFieldMetadata { Name = "isOptional" },
            new GraphQlFieldMetadata { Name = "information", IsComplex = true, QueryBuilderType = typeof(FieldInformationQueryBuilder) },
            new GraphQlFieldMetadata { Name = "description", IsComplex = true, QueryBuilderType = typeof(FieldInformationQueryBuilder) },
            new GraphQlFieldMetadata { Name = "type" },
            new GraphQlFieldMetadata { Name = "fieldTypeReferenceId" },
            new GraphQlFieldMetadata { Name = "constraints", IsComplex = true, QueryBuilderType = typeof(OutputFieldConstraintsQueryBuilder) },
            new GraphQlFieldMetadata { Name = "fieldTypeData", IsComplex = true, QueryBuilderType = typeof(FieldTypeQueryBuilder) }
        };

        protected override string TypeName => "CustomOutputFieldConfig";
        public override IReadOnlyList<GraphQlFieldMetadata> AllFields => AllFieldMetadata;

        public CustomOutputFieldConfigQueryBuilder WithID(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("id", alias, new GraphQlDirective?[] { include, skip });
        public CustomOutputFieldConfigQueryBuilder ExceptID() =>
            ExceptField("id");
        public CustomOutputFieldConfigQueryBuilder WithFieldKey(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("fieldKey", alias, new GraphQlDirective?[] { include, skip });
        public CustomOutputFieldConfigQueryBuilder ExceptFieldKey() =>
            ExceptField("fieldKey");
        public CustomOutputFieldConfigQueryBuilder WithFieldTitle(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("fieldTitle", alias, new GraphQlDirective?[] { include, skip });
        public CustomOutputFieldConfigQueryBuilder ExceptFieldTitle() =>
            ExceptField("fieldTitle");
        public CustomOutputFieldConfigQueryBuilder WithIsNullable(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("isNullable", alias, new GraphQlDirective?[] { include, skip });
        public CustomOutputFieldConfigQueryBuilder ExceptIsNullable() =>
            ExceptField("isNullable");
        public CustomOutputFieldConfigQueryBuilder WithIsArray(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("isArray", alias, new GraphQlDirective?[] { include, skip });
        public CustomOutputFieldConfigQueryBuilder ExceptIsArray() =>
            ExceptField("isArray");
        public CustomOutputFieldConfigQueryBuilder WithIsOptional(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("isOptional", alias, new GraphQlDirective?[] { include, skip });
        public CustomOutputFieldConfigQueryBuilder ExceptIsOptional() =>
            ExceptField("isOptional");
        public CustomOutputFieldConfigQueryBuilder WithInformation(FieldInformationQueryBuilder fieldInformationQueryBuilder, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithObjectField("information", alias, fieldInformationQueryBuilder, new GraphQlDirective?[] { include, skip });
        public CustomOutputFieldConfigQueryBuilder ExceptInformation() =>
            ExceptField("information");
        public CustomOutputFieldConfigQueryBuilder WithDescription(FieldInformationQueryBuilder fieldInformationQueryBuilder, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithObjectField("description", alias, fieldInformationQueryBuilder, new GraphQlDirective?[] { include, skip });
        public CustomOutputFieldConfigQueryBuilder ExceptDescription() =>
            ExceptField("description");
        public CustomOutputFieldConfigQueryBuilder WithType(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("type", alias, new GraphQlDirective?[] { include, skip });
        public CustomOutputFieldConfigQueryBuilder ExceptType() =>
            ExceptField("type");
        public CustomOutputFieldConfigQueryBuilder WithFieldTypeReferenceID(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("fieldTypeReferenceId", alias, new GraphQlDirective?[] { include, skip });
        public CustomOutputFieldConfigQueryBuilder ExceptFieldTypeReferenceID() =>
            ExceptField("fieldTypeReferenceId");
        public CustomOutputFieldConfigQueryBuilder WithConstraints(OutputFieldConstraintsQueryBuilder outputFieldConstraintsQueryBuilder, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithObjectField("constraints", alias, outputFieldConstraintsQueryBuilder, new GraphQlDirective?[] { include, skip });
        public CustomOutputFieldConfigQueryBuilder ExceptConstraints() =>
            ExceptField("constraints");
        public CustomOutputFieldConfigQueryBuilder WithFieldTypeData(FieldTypeQueryBuilder fieldTypeQueryBuilder, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithObjectField("fieldTypeData", alias, fieldTypeQueryBuilder, new GraphQlDirective?[] { include, skip });
        public CustomOutputFieldConfigQueryBuilder ExceptFieldTypeData() =>
            ExceptField("fieldTypeData");
    }
}
