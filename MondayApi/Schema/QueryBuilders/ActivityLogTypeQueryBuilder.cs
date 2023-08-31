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

        protected override string TypeName { get { return "ActivityLogType"; } }

        public override IReadOnlyList<GraphQlFieldMetadata> AllFields { get { return AllFieldMetadata; } }

        public ActivityLogTypeQueryBuilder WithAccountId(string alias = null, IncludeDirective include = null, SkipDirective skip = null) {
            return WithScalarField("account_id", alias, new GraphQlDirective[] { include, skip });
        }

        public ActivityLogTypeQueryBuilder ExceptAccountId() {
            return ExceptField("account_id");
        }

        public ActivityLogTypeQueryBuilder WithCreatedAt(string alias = null, IncludeDirective include = null, SkipDirective skip = null) {
            return WithScalarField("created_at", alias, new GraphQlDirective[] { include, skip });
        }

        public ActivityLogTypeQueryBuilder ExceptCreatedAt() {
            return ExceptField("created_at");
        }

        public ActivityLogTypeQueryBuilder WithData(string alias = null, IncludeDirective include = null, SkipDirective skip = null) {
            return WithScalarField("data", alias, new GraphQlDirective[] { include, skip });
        }

        public ActivityLogTypeQueryBuilder ExceptData() {
            return ExceptField("data");
        }

        public ActivityLogTypeQueryBuilder WithEntity(string alias = null, IncludeDirective include = null, SkipDirective skip = null) {
            return WithScalarField("entity", alias, new GraphQlDirective[] { include, skip });
        }

        public ActivityLogTypeQueryBuilder ExceptEntity() {
            return ExceptField("entity");
        }

        public ActivityLogTypeQueryBuilder WithEvent(string alias = null, IncludeDirective include = null, SkipDirective skip = null) {
            return WithScalarField("event", alias, new GraphQlDirective[] { include, skip });
        }

        public ActivityLogTypeQueryBuilder ExceptEvent() {
            return ExceptField("event");
        }

        public ActivityLogTypeQueryBuilder WithId(string alias = null, IncludeDirective include = null, SkipDirective skip = null) {
            return WithScalarField("id", alias, new GraphQlDirective[] { include, skip });
        }

        public ActivityLogTypeQueryBuilder ExceptId() {
            return ExceptField("id");
        }

        public ActivityLogTypeQueryBuilder WithUserId(string alias = null, IncludeDirective include = null, SkipDirective skip = null) {
            return WithScalarField("user_id", alias, new GraphQlDirective[] { include, skip });
        }

        public ActivityLogTypeQueryBuilder ExceptUserId() {
            return ExceptField("user_id");
        }
    }
}
