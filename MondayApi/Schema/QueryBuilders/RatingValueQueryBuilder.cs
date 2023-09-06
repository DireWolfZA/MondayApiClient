using System.Collections.Generic;

namespace MondayApi.Schema {
    public class RatingValueQueryBuilder : GraphQlQueryBuilder<RatingValueQueryBuilder> {
        private static readonly GraphQlFieldMetadata[] AllFieldMetadata = new[] {
            new GraphQlFieldMetadata { Name = "column", IsComplex = true, QueryBuilderType = typeof(ColumnQueryBuilder) },
            new GraphQlFieldMetadata { Name = "id" },
            new GraphQlFieldMetadata { Name = "rating" },
            new GraphQlFieldMetadata { Name = "text" },
            new GraphQlFieldMetadata { Name = "type" },
            new GraphQlFieldMetadata { Name = "updated_at" },
            new GraphQlFieldMetadata { Name = "value", IsComplex = true }
        };

        protected override string TypeName => "RatingValue";
        public override IReadOnlyList<GraphQlFieldMetadata> AllFields => AllFieldMetadata;

        public RatingValueQueryBuilder WithColumn(ColumnQueryBuilder columnQueryBuilder, string alias = null, IncludeDirective include = null, SkipDirective skip = null) =>
            WithObjectField("column", alias, columnQueryBuilder, new GraphQlDirective[] { include, skip });
        public RatingValueQueryBuilder ExceptColumn() =>
            ExceptField("column");
        public RatingValueQueryBuilder WithID(string alias = null, IncludeDirective include = null, SkipDirective skip = null) =>
            WithScalarField("id", alias, new GraphQlDirective[] { include, skip });
        public RatingValueQueryBuilder ExceptID() =>
            ExceptField("id");
        public RatingValueQueryBuilder WithRating(string alias = null, IncludeDirective include = null, SkipDirective skip = null) =>
            WithScalarField("rating", alias, new GraphQlDirective[] { include, skip });
        public RatingValueQueryBuilder ExceptRating() =>
            ExceptField("rating");
        public RatingValueQueryBuilder WithText(string alias = null, IncludeDirective include = null, SkipDirective skip = null) =>
            WithScalarField("text", alias, new GraphQlDirective[] { include, skip });
        public RatingValueQueryBuilder ExceptText() =>
            ExceptField("text");
        public RatingValueQueryBuilder WithType(string alias = null, IncludeDirective include = null, SkipDirective skip = null) =>
            WithScalarField("type", alias, new GraphQlDirective[] { include, skip });
        public RatingValueQueryBuilder ExceptType() =>
            ExceptField("type");
        public RatingValueQueryBuilder WithUpdatedAt(string alias = null, IncludeDirective include = null, SkipDirective skip = null) =>
            WithScalarField("updated_at", alias, new GraphQlDirective[] { include, skip });
        public RatingValueQueryBuilder ExceptUpdatedAt() =>
            ExceptField("updated_at");
        public RatingValueQueryBuilder WithValue(string alias = null, IncludeDirective include = null, SkipDirective skip = null) =>
            WithScalarField("value", alias, new GraphQlDirective[] { include, skip });
        public RatingValueQueryBuilder ExceptValue() =>
            ExceptField("value");
    }
}
