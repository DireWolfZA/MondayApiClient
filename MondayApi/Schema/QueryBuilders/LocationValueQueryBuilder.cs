using System.Collections.Generic;

namespace MondayApi.Schema {
    public class LocationValueQueryBuilder : GraphQlQueryBuilder<LocationValueQueryBuilder> {
        private static readonly GraphQlFieldMetadata[] AllFieldMetadata = new[] {
            new GraphQlFieldMetadata { Name = "address" },
            new GraphQlFieldMetadata { Name = "city" },
            new GraphQlFieldMetadata { Name = "city_short" },
            new GraphQlFieldMetadata { Name = "column", IsComplex = true, QueryBuilderType = typeof(ColumnQueryBuilder) },
            new GraphQlFieldMetadata { Name = "country" },
            new GraphQlFieldMetadata { Name = "country_short" },
            new GraphQlFieldMetadata { Name = "id" },
            new GraphQlFieldMetadata { Name = "lat" },
            new GraphQlFieldMetadata { Name = "lng" },
            new GraphQlFieldMetadata { Name = "place_id" },
            new GraphQlFieldMetadata { Name = "street" },
            new GraphQlFieldMetadata { Name = "street_number" },
            new GraphQlFieldMetadata { Name = "street_number_short" },
            new GraphQlFieldMetadata { Name = "street_short" },
            new GraphQlFieldMetadata { Name = "text" },
            new GraphQlFieldMetadata { Name = "type" },
            new GraphQlFieldMetadata { Name = "updated_at" },
            new GraphQlFieldMetadata { Name = "value", IsComplex = true }
        };

        protected override string TypeName => "LocationValue";
        public override IReadOnlyList<GraphQlFieldMetadata> AllFields => AllFieldMetadata;

        public LocationValueQueryBuilder WithAddress(string alias = null, IncludeDirective include = null, SkipDirective skip = null) =>
            WithScalarField("address", alias, new GraphQlDirective[] { include, skip });
        public LocationValueQueryBuilder ExceptAddress() =>
            ExceptField("address");
        public LocationValueQueryBuilder WithCity(string alias = null, IncludeDirective include = null, SkipDirective skip = null) =>
            WithScalarField("city", alias, new GraphQlDirective[] { include, skip });
        public LocationValueQueryBuilder ExceptCity() =>
            ExceptField("city");
        public LocationValueQueryBuilder WithCityShort(string alias = null, IncludeDirective include = null, SkipDirective skip = null) =>
            WithScalarField("city_short", alias, new GraphQlDirective[] { include, skip });
        public LocationValueQueryBuilder ExceptCityShort() =>
            ExceptField("city_short");
        public LocationValueQueryBuilder WithColumn(ColumnQueryBuilder columnQueryBuilder, string alias = null, IncludeDirective include = null, SkipDirective skip = null) =>
            WithObjectField("column", alias, columnQueryBuilder, new GraphQlDirective[] { include, skip });
        public LocationValueQueryBuilder ExceptColumn() =>
            ExceptField("column");
        public LocationValueQueryBuilder WithCountry(string alias = null, IncludeDirective include = null, SkipDirective skip = null) =>
            WithScalarField("country", alias, new GraphQlDirective[] { include, skip });
        public LocationValueQueryBuilder ExceptCountry() =>
            ExceptField("country");
        public LocationValueQueryBuilder WithCountryShort(string alias = null, IncludeDirective include = null, SkipDirective skip = null) =>
            WithScalarField("country_short", alias, new GraphQlDirective[] { include, skip });
        public LocationValueQueryBuilder ExceptCountryShort() =>
            ExceptField("country_short");
        public LocationValueQueryBuilder WithID(string alias = null, IncludeDirective include = null, SkipDirective skip = null) =>
            WithScalarField("id", alias, new GraphQlDirective[] { include, skip });
        public LocationValueQueryBuilder ExceptID() =>
            ExceptField("id");
        public LocationValueQueryBuilder WithLat(string alias = null, IncludeDirective include = null, SkipDirective skip = null) =>
            WithScalarField("lat", alias, new GraphQlDirective[] { include, skip });
        public LocationValueQueryBuilder ExceptLat() =>
            ExceptField("lat");
        public LocationValueQueryBuilder WithLng(string alias = null, IncludeDirective include = null, SkipDirective skip = null) =>
            WithScalarField("lng", alias, new GraphQlDirective[] { include, skip });
        public LocationValueQueryBuilder ExceptLng() =>
            ExceptField("lng");
        public LocationValueQueryBuilder WithPlaceID(string alias = null, IncludeDirective include = null, SkipDirective skip = null) =>
            WithScalarField("place_id", alias, new GraphQlDirective[] { include, skip });
        public LocationValueQueryBuilder ExceptPlaceID() =>
            ExceptField("place_id");
        public LocationValueQueryBuilder WithStreet(string alias = null, IncludeDirective include = null, SkipDirective skip = null) =>
            WithScalarField("street", alias, new GraphQlDirective[] { include, skip });
        public LocationValueQueryBuilder ExceptStreet() =>
            ExceptField("street");
        public LocationValueQueryBuilder WithStreetNumber(string alias = null, IncludeDirective include = null, SkipDirective skip = null) =>
            WithScalarField("street_number", alias, new GraphQlDirective[] { include, skip });
        public LocationValueQueryBuilder ExceptStreetNumber() =>
            ExceptField("street_number");
        public LocationValueQueryBuilder WithStreetNumberShort(string alias = null, IncludeDirective include = null, SkipDirective skip = null) =>
            WithScalarField("street_number_short", alias, new GraphQlDirective[] { include, skip });
        public LocationValueQueryBuilder ExceptStreetNumberShort() =>
            ExceptField("street_number_short");
        public LocationValueQueryBuilder WithStreetShort(string alias = null, IncludeDirective include = null, SkipDirective skip = null) =>
            WithScalarField("street_short", alias, new GraphQlDirective[] { include, skip });
        public LocationValueQueryBuilder ExceptStreetShort() =>
            ExceptField("street_short");
        public LocationValueQueryBuilder WithText(string alias = null, IncludeDirective include = null, SkipDirective skip = null) =>
            WithScalarField("text", alias, new GraphQlDirective[] { include, skip });
        public LocationValueQueryBuilder ExceptText() =>
            ExceptField("text");
        public LocationValueQueryBuilder WithType(string alias = null, IncludeDirective include = null, SkipDirective skip = null) =>
            WithScalarField("type", alias, new GraphQlDirective[] { include, skip });
        public LocationValueQueryBuilder ExceptType() =>
            ExceptField("type");
        public LocationValueQueryBuilder WithUpdatedAt(string alias = null, IncludeDirective include = null, SkipDirective skip = null) =>
            WithScalarField("updated_at", alias, new GraphQlDirective[] { include, skip });
        public LocationValueQueryBuilder ExceptUpdatedAt() =>
            ExceptField("updated_at");
        public LocationValueQueryBuilder WithValue(string alias = null, IncludeDirective include = null, SkipDirective skip = null) =>
            WithScalarField("value", alias, new GraphQlDirective[] { include, skip });
        public LocationValueQueryBuilder ExceptValue() =>
            ExceptField("value");
    }
}
