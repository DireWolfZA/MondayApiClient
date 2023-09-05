using System.Collections.Generic;

namespace MondayApi.Schema {
    public class IntegrationValueQueryBuilder : GraphQlQueryBuilder<IntegrationValueQueryBuilder> {
        private static readonly GraphQlFieldMetadata[] AllFieldMetadata = new[] {
            new GraphQlFieldMetadata { Name = "column", IsComplex = true, QueryBuilderType = typeof(ColumnQueryBuilder) },
            new GraphQlFieldMetadata { Name = "entity_id" },
            new GraphQlFieldMetadata { Name = "id" },
            new GraphQlFieldMetadata { Name = "issue_api_url" },
            new GraphQlFieldMetadata { Name = "issue_id" },
            new GraphQlFieldMetadata { Name = "text" },
            new GraphQlFieldMetadata { Name = "type" },
            new GraphQlFieldMetadata { Name = "value", IsComplex = true }
        };

        protected override string TypeName => "IntegrationValue";
        public override IReadOnlyList<GraphQlFieldMetadata> AllFields => AllFieldMetadata;

        public IntegrationValueQueryBuilder WithColumn(ColumnQueryBuilder columnQueryBuilder, string alias = null, IncludeDirective include = null, SkipDirective skip = null) =>
            WithObjectField("column", alias, columnQueryBuilder, new GraphQlDirective[] { include, skip });
        public IntegrationValueQueryBuilder ExceptColumn() =>
            ExceptField("column");
        public IntegrationValueQueryBuilder WithEntityId(string alias = null, IncludeDirective include = null, SkipDirective skip = null) =>
            WithScalarField("entity_id", alias, new GraphQlDirective[] { include, skip });
        public IntegrationValueQueryBuilder ExceptEntityId() =>
            ExceptField("entity_id");
        public IntegrationValueQueryBuilder WithId(string alias = null, IncludeDirective include = null, SkipDirective skip = null) =>
            WithScalarField("id", alias, new GraphQlDirective[] { include, skip });
        public IntegrationValueQueryBuilder ExceptId() =>
            ExceptField("id");
        public IntegrationValueQueryBuilder WithIssueApiUrl(string alias = null, IncludeDirective include = null, SkipDirective skip = null) =>
            WithScalarField("issue_api_url", alias, new GraphQlDirective[] { include, skip });
        public IntegrationValueQueryBuilder ExceptIssueApiUrl() =>
            ExceptField("issue_api_url");
        public IntegrationValueQueryBuilder WithIssueId(string alias = null, IncludeDirective include = null, SkipDirective skip = null) =>
            WithScalarField("issue_id", alias, new GraphQlDirective[] { include, skip });
        public IntegrationValueQueryBuilder ExceptIssueId() =>
            ExceptField("issue_id");
        public IntegrationValueQueryBuilder WithText(string alias = null, IncludeDirective include = null, SkipDirective skip = null) =>
            WithScalarField("text", alias, new GraphQlDirective[] { include, skip });
        public IntegrationValueQueryBuilder ExceptText() =>
            ExceptField("text");
        public IntegrationValueQueryBuilder WithType(string alias = null, IncludeDirective include = null, SkipDirective skip = null) =>
            WithScalarField("type", alias, new GraphQlDirective[] { include, skip });
        public IntegrationValueQueryBuilder ExceptType() =>
            ExceptField("type");
        public IntegrationValueQueryBuilder WithValue(string alias = null, IncludeDirective include = null, SkipDirective skip = null) =>
            WithScalarField("value", alias, new GraphQlDirective[] { include, skip });
        public IntegrationValueQueryBuilder ExceptValue() =>
            ExceptField("value");
    }
}
