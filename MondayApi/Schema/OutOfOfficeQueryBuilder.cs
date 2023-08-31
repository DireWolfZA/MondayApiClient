using System.Collections.Generic;

namespace MondayApi.Schema {
    public class OutOfOfficeQueryBuilder : GraphQlQueryBuilder<OutOfOfficeQueryBuilder> {
        private static readonly GraphQlFieldMetadata[] AllFieldMetadata =
            new[]
            {
                new GraphQlFieldMetadata { Name = "active" },
                new GraphQlFieldMetadata { Name = "disable_notifications" },
                new GraphQlFieldMetadata { Name = "end_date", IsComplex = true },
                new GraphQlFieldMetadata { Name = "start_date", IsComplex = true },
                new GraphQlFieldMetadata { Name = "type" }
            };

        protected override string TypeName { get { return "OutOfOffice"; } }

        public override IReadOnlyList<GraphQlFieldMetadata> AllFields { get { return AllFieldMetadata; } }

        public OutOfOfficeQueryBuilder WithActive(string alias = null, IncludeDirective include = null, SkipDirective skip = null) {
            return WithScalarField("active", alias, new GraphQlDirective[] { include, skip });
        }

        public OutOfOfficeQueryBuilder ExceptActive() {
            return ExceptField("active");
        }

        public OutOfOfficeQueryBuilder WithDisableNotifications(string alias = null, IncludeDirective include = null, SkipDirective skip = null) {
            return WithScalarField("disable_notifications", alias, new GraphQlDirective[] { include, skip });
        }

        public OutOfOfficeQueryBuilder ExceptDisableNotifications() {
            return ExceptField("disable_notifications");
        }

        public OutOfOfficeQueryBuilder WithEndDate(string alias = null, IncludeDirective include = null, SkipDirective skip = null) {
            return WithScalarField("end_date", alias, new GraphQlDirective[] { include, skip });
        }

        public OutOfOfficeQueryBuilder ExceptEndDate() {
            return ExceptField("end_date");
        }

        public OutOfOfficeQueryBuilder WithStartDate(string alias = null, IncludeDirective include = null, SkipDirective skip = null) {
            return WithScalarField("start_date", alias, new GraphQlDirective[] { include, skip });
        }

        public OutOfOfficeQueryBuilder ExceptStartDate() {
            return ExceptField("start_date");
        }

        public OutOfOfficeQueryBuilder WithType(string alias = null, IncludeDirective include = null, SkipDirective skip = null) {
            return WithScalarField("type", alias, new GraphQlDirective[] { include, skip });
        }

        public OutOfOfficeQueryBuilder ExceptType() {
            return ExceptField("type");
        }
    }
}
