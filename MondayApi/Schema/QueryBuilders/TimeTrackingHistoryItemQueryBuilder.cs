using System.Collections.Generic;

namespace MondayApi.Schema {
    public class TimeTrackingHistoryItemQueryBuilder : GraphQlQueryBuilder<TimeTrackingHistoryItemQueryBuilder> {
        private static readonly GraphQlFieldMetadata[] AllFieldMetadata = new[] {
            new GraphQlFieldMetadata { Name = "created_at" },
            new GraphQlFieldMetadata { Name = "ended_at", IsComplex = true },
            new GraphQlFieldMetadata { Name = "ended_user_id" },
            new GraphQlFieldMetadata { Name = "id" },
            new GraphQlFieldMetadata { Name = "manually_entered_end_date" },
            new GraphQlFieldMetadata { Name = "manually_entered_end_time" },
            new GraphQlFieldMetadata { Name = "manually_entered_start_date" },
            new GraphQlFieldMetadata { Name = "manually_entered_start_time" },
            new GraphQlFieldMetadata { Name = "started_at", IsComplex = true },
            new GraphQlFieldMetadata { Name = "started_user_id" },
            new GraphQlFieldMetadata { Name = "status" },
            new GraphQlFieldMetadata { Name = "updated_at" }
        };

        protected override string TypeName => "TimeTrackingHistoryItem";
        public override IReadOnlyList<GraphQlFieldMetadata> AllFields => AllFieldMetadata;

        public TimeTrackingHistoryItemQueryBuilder WithCreatedAt(string alias = null, IncludeDirective include = null, SkipDirective skip = null) =>
            WithScalarField("created_at", alias, new GraphQlDirective[] { include, skip });
        public TimeTrackingHistoryItemQueryBuilder ExceptCreatedAt() =>
            ExceptField("created_at");
        public TimeTrackingHistoryItemQueryBuilder WithEndedAt(string alias = null, IncludeDirective include = null, SkipDirective skip = null) =>
            WithScalarField("ended_at", alias, new GraphQlDirective[] { include, skip });
        public TimeTrackingHistoryItemQueryBuilder ExceptEndedAt() =>
            ExceptField("ended_at");
        public TimeTrackingHistoryItemQueryBuilder WithEndedUserId(string alias = null, IncludeDirective include = null, SkipDirective skip = null) =>
            WithScalarField("ended_user_id", alias, new GraphQlDirective[] { include, skip });
        public TimeTrackingHistoryItemQueryBuilder ExceptEndedUserId() =>
            ExceptField("ended_user_id");
        public TimeTrackingHistoryItemQueryBuilder WithId(string alias = null, IncludeDirective include = null, SkipDirective skip = null) =>
            WithScalarField("id", alias, new GraphQlDirective[] { include, skip });
        public TimeTrackingHistoryItemQueryBuilder ExceptId() =>
            ExceptField("id");
        public TimeTrackingHistoryItemQueryBuilder WithManuallyEnteredEndDate(string alias = null, IncludeDirective include = null, SkipDirective skip = null) =>
            WithScalarField("manually_entered_end_date", alias, new GraphQlDirective[] { include, skip });
        public TimeTrackingHistoryItemQueryBuilder ExceptManuallyEnteredEndDate() =>
            ExceptField("manually_entered_end_date");
        public TimeTrackingHistoryItemQueryBuilder WithManuallyEnteredEndTime(string alias = null, IncludeDirective include = null, SkipDirective skip = null) =>
            WithScalarField("manually_entered_end_time", alias, new GraphQlDirective[] { include, skip });
        public TimeTrackingHistoryItemQueryBuilder ExceptManuallyEnteredEndTime() =>
            ExceptField("manually_entered_end_time");
        public TimeTrackingHistoryItemQueryBuilder WithManuallyEnteredStartDate(string alias = null, IncludeDirective include = null, SkipDirective skip = null) =>
            WithScalarField("manually_entered_start_date", alias, new GraphQlDirective[] { include, skip });
        public TimeTrackingHistoryItemQueryBuilder ExceptManuallyEnteredStartDate() =>
            ExceptField("manually_entered_start_date");
        public TimeTrackingHistoryItemQueryBuilder WithManuallyEnteredStartTime(string alias = null, IncludeDirective include = null, SkipDirective skip = null) =>
            WithScalarField("manually_entered_start_time", alias, new GraphQlDirective[] { include, skip });
        public TimeTrackingHistoryItemQueryBuilder ExceptManuallyEnteredStartTime() =>
            ExceptField("manually_entered_start_time");
        public TimeTrackingHistoryItemQueryBuilder WithStartedAt(string alias = null, IncludeDirective include = null, SkipDirective skip = null) =>
            WithScalarField("started_at", alias, new GraphQlDirective[] { include, skip });
        public TimeTrackingHistoryItemQueryBuilder ExceptStartedAt() =>
            ExceptField("started_at");
        public TimeTrackingHistoryItemQueryBuilder WithStartedUserId(string alias = null, IncludeDirective include = null, SkipDirective skip = null) =>
            WithScalarField("started_user_id", alias, new GraphQlDirective[] { include, skip });
        public TimeTrackingHistoryItemQueryBuilder ExceptStartedUserId() =>
            ExceptField("started_user_id");
        public TimeTrackingHistoryItemQueryBuilder WithStatus(string alias = null, IncludeDirective include = null, SkipDirective skip = null) =>
            WithScalarField("status", alias, new GraphQlDirective[] { include, skip });
        public TimeTrackingHistoryItemQueryBuilder ExceptStatus() =>
            ExceptField("status");
        public TimeTrackingHistoryItemQueryBuilder WithUpdatedAt(string alias = null, IncludeDirective include = null, SkipDirective skip = null) =>
            WithScalarField("updated_at", alias, new GraphQlDirective[] { include, skip });
        public TimeTrackingHistoryItemQueryBuilder ExceptUpdatedAt() =>
            ExceptField("updated_at");
    }
}
