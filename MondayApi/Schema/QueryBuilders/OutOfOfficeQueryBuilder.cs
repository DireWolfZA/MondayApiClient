using System.Collections.Generic;

namespace MondayApi.Schema {
    public class OutOfOfficeQueryBuilder : GraphQlQueryBuilder<OutOfOfficeQueryBuilder> {
        private static readonly GraphQlFieldMetadata[] AllFieldMetadata = new[] {
            new GraphQlFieldMetadata { Name = "active" },
            new GraphQlFieldMetadata { Name = "disable_notifications" },
            new GraphQlFieldMetadata { Name = "end_date" },
            new GraphQlFieldMetadata { Name = "start_date" },
            new GraphQlFieldMetadata { Name = "type" }
        };

        protected override string TypeName => "OutOfOffice";
        public override IReadOnlyList<GraphQlFieldMetadata> AllFields => AllFieldMetadata;

        public OutOfOfficeQueryBuilder WithActive(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("active", alias, new GraphQlDirective?[] { include, skip });
        public OutOfOfficeQueryBuilder ExceptActive() =>
            ExceptField("active");
        public OutOfOfficeQueryBuilder WithDisableNotifications(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("disable_notifications", alias, new GraphQlDirective?[] { include, skip });
        public OutOfOfficeQueryBuilder ExceptDisableNotifications() =>
            ExceptField("disable_notifications");
        public OutOfOfficeQueryBuilder WithEndDate(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("end_date", alias, new GraphQlDirective?[] { include, skip });
        public OutOfOfficeQueryBuilder ExceptEndDate() =>
            ExceptField("end_date");
        public OutOfOfficeQueryBuilder WithStartDate(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("start_date", alias, new GraphQlDirective?[] { include, skip });
        public OutOfOfficeQueryBuilder ExceptStartDate() =>
            ExceptField("start_date");
        public OutOfOfficeQueryBuilder WithType(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("type", alias, new GraphQlDirective?[] { include, skip });
        public OutOfOfficeQueryBuilder ExceptType() =>
            ExceptField("type");
    }
}
