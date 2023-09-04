using System.Collections.Generic;

namespace MondayApi.Schema {
    public class PlanQueryBuilder : GraphQlQueryBuilder<PlanQueryBuilder> {
        private static readonly GraphQlFieldMetadata[] AllFieldMetadata = new[] {
            new GraphQlFieldMetadata { Name = "max_users" },
            new GraphQlFieldMetadata { Name = "period" },
            new GraphQlFieldMetadata { Name = "tier" },
            new GraphQlFieldMetadata { Name = "version" }
        };

        protected override string TypeName => "Plan";
        public override IReadOnlyList<GraphQlFieldMetadata> AllFields => AllFieldMetadata;

        public PlanQueryBuilder WithMaxUsers(string alias = null, IncludeDirective include = null, SkipDirective skip = null) =>
            WithScalarField("max_users", alias, new GraphQlDirective[] { include, skip });
        public PlanQueryBuilder ExceptMaxUsers() =>
            ExceptField("max_users");
        public PlanQueryBuilder WithPeriod(string alias = null, IncludeDirective include = null, SkipDirective skip = null) =>
            WithScalarField("period", alias, new GraphQlDirective[] { include, skip });
        public PlanQueryBuilder ExceptPeriod() =>
            ExceptField("period");
        public PlanQueryBuilder WithTier(string alias = null, IncludeDirective include = null, SkipDirective skip = null) =>
            WithScalarField("tier", alias, new GraphQlDirective[] { include, skip });
        public PlanQueryBuilder ExceptTier() =>
            ExceptField("tier");
        public PlanQueryBuilder WithVersion(string alias = null, IncludeDirective include = null, SkipDirective skip = null) =>
            WithScalarField("version", alias, new GraphQlDirective[] { include, skip });
        public PlanQueryBuilder ExceptVersion() =>
            ExceptField("version");
    }
}
