using System.Collections.Generic;

namespace MondayApi.Schema {
    public class DateValueQueryBuilder : GraphQlQueryBuilder<DateValueQueryBuilder> {
        private static readonly GraphQlFieldMetadata[] AllFieldMetadata = new[] {
            new GraphQlFieldMetadata { Name = "column", IsComplex = true, QueryBuilderType = typeof(ColumnQueryBuilder) },
            new GraphQlFieldMetadata { Name = "date" },
            new GraphQlFieldMetadata { Name = "icon" },
            new GraphQlFieldMetadata { Name = "id" },
            new GraphQlFieldMetadata { Name = "text" },
            new GraphQlFieldMetadata { Name = "time" },
            new GraphQlFieldMetadata { Name = "type" },
            new GraphQlFieldMetadata { Name = "updated_at" },
            new GraphQlFieldMetadata { Name = "value", IsComplex = true }
        };

        protected override string TypeName => "DateValue";
        public override IReadOnlyList<GraphQlFieldMetadata> AllFields => AllFieldMetadata;

        public DateValueQueryBuilder WithColumn(ColumnQueryBuilder columnQueryBuilder, string alias = null, IncludeDirective include = null, SkipDirective skip = null) =>
            WithObjectField("column", alias, columnQueryBuilder, new GraphQlDirective[] { include, skip });
        public DateValueQueryBuilder ExceptColumn() =>
            ExceptField("column");
        public DateValueQueryBuilder WithDate(string alias = null, IncludeDirective include = null, SkipDirective skip = null) =>
            WithScalarField("date", alias, new GraphQlDirective[] { include, skip });
        public DateValueQueryBuilder ExceptDate() =>
            ExceptField("date");
        public DateValueQueryBuilder WithIcon(string alias = null, IncludeDirective include = null, SkipDirective skip = null) =>
            WithScalarField("icon", alias, new GraphQlDirective[] { include, skip });
        public DateValueQueryBuilder ExceptIcon() =>
            ExceptField("icon");
        public DateValueQueryBuilder WithID(string alias = null, IncludeDirective include = null, SkipDirective skip = null) =>
            WithScalarField("id", alias, new GraphQlDirective[] { include, skip });
        public DateValueQueryBuilder ExceptID() =>
            ExceptField("id");
        public DateValueQueryBuilder WithText(string alias = null, IncludeDirective include = null, SkipDirective skip = null) =>
            WithScalarField("text", alias, new GraphQlDirective[] { include, skip });
        public DateValueQueryBuilder ExceptText() =>
            ExceptField("text");
        public DateValueQueryBuilder WithTime(string alias = null, IncludeDirective include = null, SkipDirective skip = null) =>
            WithScalarField("time", alias, new GraphQlDirective[] { include, skip });
        public DateValueQueryBuilder ExceptTime() =>
            ExceptField("time");
        public DateValueQueryBuilder WithType(string alias = null, IncludeDirective include = null, SkipDirective skip = null) =>
            WithScalarField("type", alias, new GraphQlDirective[] { include, skip });
        public DateValueQueryBuilder ExceptType() =>
            ExceptField("type");
        public DateValueQueryBuilder WithUpdatedAt(string alias = null, IncludeDirective include = null, SkipDirective skip = null) =>
            WithScalarField("updated_at", alias, new GraphQlDirective[] { include, skip });
        public DateValueQueryBuilder ExceptUpdatedAt() =>
            ExceptField("updated_at");
        public DateValueQueryBuilder WithValue(string alias = null, IncludeDirective include = null, SkipDirective skip = null) =>
            WithScalarField("value", alias, new GraphQlDirective[] { include, skip });
        public DateValueQueryBuilder ExceptValue() =>
            ExceptField("value");
    }
}
