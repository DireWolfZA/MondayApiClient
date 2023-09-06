using System.Collections.Generic;

namespace MondayApi.Schema {
    public class StatusValueQueryBuilder : GraphQlQueryBuilder<StatusValueQueryBuilder> {
        private static readonly GraphQlFieldMetadata[] AllFieldMetadata = new[] {
            new GraphQlFieldMetadata { Name = "column", IsComplex = true, QueryBuilderType = typeof(ColumnQueryBuilder) },
            new GraphQlFieldMetadata { Name = "id" },
            new GraphQlFieldMetadata { Name = "index" },
            new GraphQlFieldMetadata { Name = "is_done" },
            new GraphQlFieldMetadata { Name = "label" },
            new GraphQlFieldMetadata { Name = "label_style", IsComplex = true, QueryBuilderType = typeof(StatusLabelStyleQueryBuilder) },
            new GraphQlFieldMetadata { Name = "text" },
            new GraphQlFieldMetadata { Name = "type" },
            new GraphQlFieldMetadata { Name = "update_id" },
            new GraphQlFieldMetadata { Name = "updated_at" },
            new GraphQlFieldMetadata { Name = "value", IsComplex = true }
        };

        protected override string TypeName => "StatusValue";
        public override IReadOnlyList<GraphQlFieldMetadata> AllFields => AllFieldMetadata;

        public StatusValueQueryBuilder WithColumn(ColumnQueryBuilder columnQueryBuilder, string alias = null, IncludeDirective include = null, SkipDirective skip = null) =>
            WithObjectField("column", alias, columnQueryBuilder, new GraphQlDirective[] { include, skip });
        public StatusValueQueryBuilder ExceptColumn() =>
            ExceptField("column");
        public StatusValueQueryBuilder WithID(string alias = null, IncludeDirective include = null, SkipDirective skip = null) =>
            WithScalarField("id", alias, new GraphQlDirective[] { include, skip });
        public StatusValueQueryBuilder ExceptID() =>
            ExceptField("id");
        public StatusValueQueryBuilder WithIndex(string alias = null, IncludeDirective include = null, SkipDirective skip = null) =>
            WithScalarField("index", alias, new GraphQlDirective[] { include, skip });
        public StatusValueQueryBuilder ExceptIndex() =>
            ExceptField("index");
        public StatusValueQueryBuilder WithIsDone(string alias = null, IncludeDirective include = null, SkipDirective skip = null) =>
            WithScalarField("is_done", alias, new GraphQlDirective[] { include, skip });
        public StatusValueQueryBuilder ExceptIsDone() =>
            ExceptField("is_done");
        public StatusValueQueryBuilder WithLabel(string alias = null, IncludeDirective include = null, SkipDirective skip = null) =>
            WithScalarField("label", alias, new GraphQlDirective[] { include, skip });
        public StatusValueQueryBuilder ExceptLabel() =>
            ExceptField("label");
        public StatusValueQueryBuilder WithLabelStyle(StatusLabelStyleQueryBuilder statusLabelStyleQueryBuilder, string alias = null, IncludeDirective include = null, SkipDirective skip = null) =>
            WithObjectField("label_style", alias, statusLabelStyleQueryBuilder, new GraphQlDirective[] { include, skip });
        public StatusValueQueryBuilder ExceptLabelStyle() =>
            ExceptField("label_style");
        public StatusValueQueryBuilder WithText(string alias = null, IncludeDirective include = null, SkipDirective skip = null) =>
            WithScalarField("text", alias, new GraphQlDirective[] { include, skip });
        public StatusValueQueryBuilder ExceptText() =>
            ExceptField("text");
        public StatusValueQueryBuilder WithType(string alias = null, IncludeDirective include = null, SkipDirective skip = null) =>
            WithScalarField("type", alias, new GraphQlDirective[] { include, skip });
        public StatusValueQueryBuilder ExceptType() =>
            ExceptField("type");
        public StatusValueQueryBuilder WithUpdateID(string alias = null, IncludeDirective include = null, SkipDirective skip = null) =>
            WithScalarField("update_id", alias, new GraphQlDirective[] { include, skip });
        public StatusValueQueryBuilder ExceptUpdateID() =>
            ExceptField("update_id");
        public StatusValueQueryBuilder WithUpdatedAt(string alias = null, IncludeDirective include = null, SkipDirective skip = null) =>
            WithScalarField("updated_at", alias, new GraphQlDirective[] { include, skip });
        public StatusValueQueryBuilder ExceptUpdatedAt() =>
            ExceptField("updated_at");
        public StatusValueQueryBuilder WithValue(string alias = null, IncludeDirective include = null, SkipDirective skip = null) =>
            WithScalarField("value", alias, new GraphQlDirective[] { include, skip });
        public StatusValueQueryBuilder ExceptValue() =>
            ExceptField("value");
    }
}
