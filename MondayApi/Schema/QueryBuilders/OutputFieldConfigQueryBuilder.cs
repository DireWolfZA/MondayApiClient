using System.Collections.Generic;

namespace MondayApi.Schema {
    public class OutputFieldConfigQueryBuilder : GraphQlQueryBuilder<OutputFieldConfigQueryBuilder> {
        private static readonly GraphQlFieldMetadata[] AllFieldMetadata = new[] {
            new GraphQlFieldMetadata { Name = "id" },
            new GraphQlFieldMetadata { Name = "fieldKey" },
            new GraphQlFieldMetadata { Name = "fieldTitle" },
            new GraphQlFieldMetadata { Name = "isNullable" },
            new GraphQlFieldMetadata { Name = "isArray" },
            new GraphQlFieldMetadata { Name = "isOptional" },
            new GraphQlFieldMetadata { Name = "information", IsComplex = true, QueryBuilderType = typeof(FieldInformationQueryBuilder) },
            new GraphQlFieldMetadata { Name = "description", IsComplex = true, QueryBuilderType = typeof(FieldInformationQueryBuilder) },
            new GraphQlFieldMetadata { Name = "type" }
        };

        public OutputFieldConfigQueryBuilder() => WithTypeName();
        protected override string TypeName => "OutputFieldConfig";
        public override IReadOnlyList<GraphQlFieldMetadata> AllFields => AllFieldMetadata;

        public OutputFieldConfigQueryBuilder WithID(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("id", alias, new GraphQlDirective?[] { include, skip });
        public OutputFieldConfigQueryBuilder ExceptID() =>
            ExceptField("id");
        public OutputFieldConfigQueryBuilder WithFieldKey(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("fieldKey", alias, new GraphQlDirective?[] { include, skip });
        public OutputFieldConfigQueryBuilder ExceptFieldKey() =>
            ExceptField("fieldKey");
        public OutputFieldConfigQueryBuilder WithFieldTitle(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("fieldTitle", alias, new GraphQlDirective?[] { include, skip });
        public OutputFieldConfigQueryBuilder ExceptFieldTitle() =>
            ExceptField("fieldTitle");
        public OutputFieldConfigQueryBuilder WithIsNullable(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("isNullable", alias, new GraphQlDirective?[] { include, skip });
        public OutputFieldConfigQueryBuilder ExceptIsNullable() =>
            ExceptField("isNullable");
        public OutputFieldConfigQueryBuilder WithIsArray(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("isArray", alias, new GraphQlDirective?[] { include, skip });
        public OutputFieldConfigQueryBuilder ExceptIsArray() =>
            ExceptField("isArray");
        public OutputFieldConfigQueryBuilder WithIsOptional(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("isOptional", alias, new GraphQlDirective?[] { include, skip });
        public OutputFieldConfigQueryBuilder ExceptIsOptional() =>
            ExceptField("isOptional");
        public OutputFieldConfigQueryBuilder WithInformation(FieldInformationQueryBuilder fieldInformationQueryBuilder, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithObjectField("information", alias, fieldInformationQueryBuilder, new GraphQlDirective?[] { include, skip });
        public OutputFieldConfigQueryBuilder ExceptInformation() =>
            ExceptField("information");
        public OutputFieldConfigQueryBuilder WithDescription(FieldInformationQueryBuilder fieldInformationQueryBuilder, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithObjectField("description", alias, fieldInformationQueryBuilder, new GraphQlDirective?[] { include, skip });
        public OutputFieldConfigQueryBuilder ExceptDescription() =>
            ExceptField("description");
        public OutputFieldConfigQueryBuilder WithType(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("type", alias, new GraphQlDirective?[] { include, skip });
        public OutputFieldConfigQueryBuilder ExceptType() =>
            ExceptField("type");
        public OutputFieldConfigQueryBuilder WithCustomOutputFieldConfigFragment(CustomOutputFieldConfigQueryBuilder customOutputFieldConfigQueryBuilder, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithFragment(customOutputFieldConfigQueryBuilder, new GraphQlDirective?[] { include, skip });
        public OutputFieldConfigQueryBuilder WithPrimitiveOutputFieldConfigFragment(PrimitiveOutputFieldConfigQueryBuilder primitiveOutputFieldConfigQueryBuilder, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithFragment(primitiveOutputFieldConfigQueryBuilder, new GraphQlDirective?[] { include, skip });
    }
}
