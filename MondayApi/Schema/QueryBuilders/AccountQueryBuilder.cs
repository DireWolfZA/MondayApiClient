using System.Collections.Generic;

namespace MondayApi.Schema {
    public class AccountQueryBuilder : GraphQlQueryBuilder<AccountQueryBuilder> {
        private static readonly GraphQlFieldMetadata[] AllFieldMetadata = new[] {
            new GraphQlFieldMetadata { Name = "country_code" },
            new GraphQlFieldMetadata { Name = "first_day_of_the_week" },
            new GraphQlFieldMetadata { Name = "id" },
            new GraphQlFieldMetadata { Name = "logo" },
            new GraphQlFieldMetadata { Name = "name" },
            new GraphQlFieldMetadata { Name = "plan", IsComplex = true, QueryBuilderType = typeof(PlanQueryBuilder) },
            new GraphQlFieldMetadata { Name = "products", IsComplex = true, QueryBuilderType = typeof(AccountProductQueryBuilder) },
            new GraphQlFieldMetadata { Name = "show_timeline_weekends" },
            new GraphQlFieldMetadata { Name = "sign_up_product_kind" },
            new GraphQlFieldMetadata { Name = "slug" },
            new GraphQlFieldMetadata { Name = "tier" }
        };

        protected override string TypeName { get { return "Account"; } }

        public override IReadOnlyList<GraphQlFieldMetadata> AllFields { get { return AllFieldMetadata; } }

        public AccountQueryBuilder WithCountryCode(string alias = null, IncludeDirective include = null, SkipDirective skip = null) {
            return WithScalarField("country_code", alias, new GraphQlDirective[] { include, skip });
        }

        public AccountQueryBuilder ExceptCountryCode() {
            return ExceptField("country_code");
        }

        public AccountQueryBuilder WithFirstDayOfTheWeek(string alias = null, IncludeDirective include = null, SkipDirective skip = null) {
            return WithScalarField("first_day_of_the_week", alias, new GraphQlDirective[] { include, skip });
        }

        public AccountQueryBuilder ExceptFirstDayOfTheWeek() {
            return ExceptField("first_day_of_the_week");
        }

        public AccountQueryBuilder WithId(string alias = null, IncludeDirective include = null, SkipDirective skip = null) {
            return WithScalarField("id", alias, new GraphQlDirective[] { include, skip });
        }

        public AccountQueryBuilder ExceptId() {
            return ExceptField("id");
        }

        public AccountQueryBuilder WithLogo(string alias = null, IncludeDirective include = null, SkipDirective skip = null) {
            return WithScalarField("logo", alias, new GraphQlDirective[] { include, skip });
        }

        public AccountQueryBuilder ExceptLogo() {
            return ExceptField("logo");
        }

        public AccountQueryBuilder WithName(string alias = null, IncludeDirective include = null, SkipDirective skip = null) {
            return WithScalarField("name", alias, new GraphQlDirective[] { include, skip });
        }

        public AccountQueryBuilder ExceptName() {
            return ExceptField("name");
        }

        public AccountQueryBuilder WithPlan(PlanQueryBuilder planQueryBuilder, string alias = null, IncludeDirective include = null, SkipDirective skip = null) {
            return WithObjectField("plan", alias, planQueryBuilder, new GraphQlDirective[] { include, skip });
        }

        public AccountQueryBuilder ExceptPlan() {
            return ExceptField("plan");
        }

        public AccountQueryBuilder WithProducts(AccountProductQueryBuilder accountProductQueryBuilder, string alias = null, IncludeDirective include = null, SkipDirective skip = null) {
            return WithObjectField("products", alias, accountProductQueryBuilder, new GraphQlDirective[] { include, skip });
        }

        public AccountQueryBuilder ExceptProducts() {
            return ExceptField("products");
        }

        public AccountQueryBuilder WithShowTimelineWeekends(string alias = null, IncludeDirective include = null, SkipDirective skip = null) {
            return WithScalarField("show_timeline_weekends", alias, new GraphQlDirective[] { include, skip });
        }

        public AccountQueryBuilder ExceptShowTimelineWeekends() {
            return ExceptField("show_timeline_weekends");
        }

        public AccountQueryBuilder WithSignUpProductKind(string alias = null, IncludeDirective include = null, SkipDirective skip = null) {
            return WithScalarField("sign_up_product_kind", alias, new GraphQlDirective[] { include, skip });
        }

        public AccountQueryBuilder ExceptSignUpProductKind() {
            return ExceptField("sign_up_product_kind");
        }

        public AccountQueryBuilder WithSlug(string alias = null, IncludeDirective include = null, SkipDirective skip = null) {
            return WithScalarField("slug", alias, new GraphQlDirective[] { include, skip });
        }

        public AccountQueryBuilder ExceptSlug() {
            return ExceptField("slug");
        }

        public AccountQueryBuilder WithTier(string alias = null, IncludeDirective include = null, SkipDirective skip = null) {
            return WithScalarField("tier", alias, new GraphQlDirective[] { include, skip });
        }

        public AccountQueryBuilder ExceptTier() {
            return ExceptField("tier");
        }
    }
}
