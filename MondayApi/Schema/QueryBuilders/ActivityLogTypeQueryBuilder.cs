using System.Collections.Generic;

namespace MondayApi.Schema {
    public class ActivityLogTypeQueryBuilder : GraphQlQueryBuilder<ActivityLogTypeQueryBuilder> {
        private static readonly GraphQlFieldMetadata[] AllFieldMetadata = new[] {
            new GraphQlFieldMetadata { Name = "account_id" },
            new GraphQlFieldMetadata { Name = "created_at" },
            new GraphQlFieldMetadata { Name = "data" },
            new GraphQlFieldMetadata { Name = "entity" },
            new GraphQlFieldMetadata { Name = "event" },
            new GraphQlFieldMetadata { Name = "id" },
            new GraphQlFieldMetadata { Name = "user_id" }
        };

        protected override string TypeName => "ActivityLogType";
        public override IReadOnlyList<GraphQlFieldMetadata> AllFields => AllFieldMetadata;

        public ActivityLogTypeQueryBuilder WithAccountID(string alias = null, IncludeDirective include = null, SkipDirective skip = null) =>
            WithScalarField("account_id", alias, new GraphQlDirective[] { include, skip });
        public ActivityLogTypeQueryBuilder ExceptAccountID() =>
            ExceptField("account_id");
        public ActivityLogTypeQueryBuilder WithCreatedAt(string alias = null, IncludeDirective include = null, SkipDirective skip = null) =>
            WithScalarField("created_at", alias, new GraphQlDirective[] { include, skip });
        public ActivityLogTypeQueryBuilder ExceptCreatedAt() =>
            ExceptField("created_at");
        public ActivityLogTypeQueryBuilder WithData(string alias = null, IncludeDirective include = null, SkipDirective skip = null) =>
            WithScalarField("data", alias, new GraphQlDirective[] { include, skip });
        public ActivityLogTypeQueryBuilder ExceptData() =>
            ExceptField("data");
        public ActivityLogTypeQueryBuilder WithEntity(string alias = null, IncludeDirective include = null, SkipDirective skip = null) =>
            WithScalarField("entity", alias, new GraphQlDirective[] { include, skip });
        public ActivityLogTypeQueryBuilder ExceptEntity() =>
            ExceptField("entity");
        public ActivityLogTypeQueryBuilder WithEvent(string alias = null, IncludeDirective include = null, SkipDirective skip = null) =>
            WithScalarField("event", alias, new GraphQlDirective[] { include, skip });
        public ActivityLogTypeQueryBuilder ExceptEvent() =>
            ExceptField("event");
        public ActivityLogTypeQueryBuilder WithID(string alias = null, IncludeDirective include = null, SkipDirective skip = null) =>
            WithScalarField("id", alias, new GraphQlDirective[] { include, skip });
        public ActivityLogTypeQueryBuilder ExceptID() =>
            ExceptField("id");
        public ActivityLogTypeQueryBuilder WithUserID(string alias = null, IncludeDirective include = null, SkipDirective skip = null) =>
            WithScalarField("user_id", alias, new GraphQlDirective[] { include, skip });
        public ActivityLogTypeQueryBuilder ExceptUserID() =>
            ExceptField("user_id");
    }
}
