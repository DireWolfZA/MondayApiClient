using System.Collections.Generic;

namespace MondayApi.Schema {
    public class PlanQueryBuilder : GraphQlQueryBuilder<PlanQueryBuilder> {
        private static readonly GraphQlFieldMetadata[] AllFieldMetadata =
            new[]
            {
                new GraphQlFieldMetadata { Name = "max_users" },
                new GraphQlFieldMetadata { Name = "period" },
                new GraphQlFieldMetadata { Name = "tier" },
                new GraphQlFieldMetadata { Name = "version" }
            };

        protected override string TypeName { get { return "Plan"; } }

        public override IReadOnlyList<GraphQlFieldMetadata> AllFields { get { return AllFieldMetadata; } }

        public PlanQueryBuilder WithMaxUsers(string alias = null, IncludeDirective include = null, SkipDirective skip = null) {
            return WithScalarField("max_users", alias, new GraphQlDirective[] { include, skip });
        }

        public PlanQueryBuilder ExceptMaxUsers() {
            return ExceptField("max_users");
        }

        public PlanQueryBuilder WithPeriod(string alias = null, IncludeDirective include = null, SkipDirective skip = null) {
            return WithScalarField("period", alias, new GraphQlDirective[] { include, skip });
        }

        public PlanQueryBuilder ExceptPeriod() {
            return ExceptField("period");
        }

        public PlanQueryBuilder WithTier(string alias = null, IncludeDirective include = null, SkipDirective skip = null) {
            return WithScalarField("tier", alias, new GraphQlDirective[] { include, skip });
        }

        public PlanQueryBuilder ExceptTier() {
            return ExceptField("tier");
        }

        public PlanQueryBuilder WithVersion(string alias = null, IncludeDirective include = null, SkipDirective skip = null) {
            return WithScalarField("version", alias, new GraphQlDirective[] { include, skip });
        }

        public PlanQueryBuilder ExceptVersion() {
            return ExceptField("version");
        }
    }
}
