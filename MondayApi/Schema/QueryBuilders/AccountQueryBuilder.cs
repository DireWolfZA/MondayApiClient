using System.Collections.Generic;

namespace MondayApi.Schema {
    public class AccountQueryBuilder : GraphQlQueryBuilder<AccountQueryBuilder> {
        private static readonly GraphQlFieldMetadata[] AllFieldMetadata = new[] {
            new GraphQlFieldMetadata { Name = "active_members_count" },
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

        protected override string TypeName => "Account";
        public override IReadOnlyList<GraphQlFieldMetadata> AllFields => AllFieldMetadata;

        public AccountQueryBuilder WithActiveMembersCount(string alias = null, IncludeDirective include = null, SkipDirective skip = null) =>
            WithScalarField("active_members_count", alias, new GraphQlDirective[] { include, skip });
        public AccountQueryBuilder ExceptActiveMembersCount() =>
            ExceptField("active_members_count");
        public AccountQueryBuilder WithCountryCode(string alias = null, IncludeDirective include = null, SkipDirective skip = null) =>
            WithScalarField("country_code", alias, new GraphQlDirective[] { include, skip });
        public AccountQueryBuilder ExceptCountryCode() =>
            ExceptField("country_code");
        public AccountQueryBuilder WithFirstDayOfTheWeek(string alias = null, IncludeDirective include = null, SkipDirective skip = null) =>
            WithScalarField("first_day_of_the_week", alias, new GraphQlDirective[] { include, skip });
        public AccountQueryBuilder ExceptFirstDayOfTheWeek() =>
            ExceptField("first_day_of_the_week");
        public AccountQueryBuilder WithID(string alias = null, IncludeDirective include = null, SkipDirective skip = null) =>
            WithScalarField("id", alias, new GraphQlDirective[] { include, skip });
        public AccountQueryBuilder ExceptID() =>
            ExceptField("id");
        public AccountQueryBuilder WithLogo(string alias = null, IncludeDirective include = null, SkipDirective skip = null) =>
            WithScalarField("logo", alias, new GraphQlDirective[] { include, skip });
        public AccountQueryBuilder ExceptLogo() =>
            ExceptField("logo");
        public AccountQueryBuilder WithName(string alias = null, IncludeDirective include = null, SkipDirective skip = null) =>
            WithScalarField("name", alias, new GraphQlDirective[] { include, skip });
        public AccountQueryBuilder ExceptName() =>
            ExceptField("name");
        public AccountQueryBuilder WithPlan(PlanQueryBuilder planQueryBuilder, string alias = null, IncludeDirective include = null, SkipDirective skip = null) =>
            WithObjectField("plan", alias, planQueryBuilder, new GraphQlDirective[] { include, skip });
        public AccountQueryBuilder ExceptPlan() =>
            ExceptField("plan");
        public AccountQueryBuilder WithProducts(AccountProductQueryBuilder accountProductQueryBuilder, string alias = null, IncludeDirective include = null, SkipDirective skip = null) =>
            WithObjectField("products", alias, accountProductQueryBuilder, new GraphQlDirective[] { include, skip });
        public AccountQueryBuilder ExceptProducts() =>
            ExceptField("products");
        public AccountQueryBuilder WithShowTimelineWeekends(string alias = null, IncludeDirective include = null, SkipDirective skip = null) =>
            WithScalarField("show_timeline_weekends", alias, new GraphQlDirective[] { include, skip });
        public AccountQueryBuilder ExceptShowTimelineWeekends() =>
            ExceptField("show_timeline_weekends");
        public AccountQueryBuilder WithSignUpProductKind(string alias = null, IncludeDirective include = null, SkipDirective skip = null) =>
            WithScalarField("sign_up_product_kind", alias, new GraphQlDirective[] { include, skip });
        public AccountQueryBuilder ExceptSignUpProductKind() =>
            ExceptField("sign_up_product_kind");
        public AccountQueryBuilder WithSlug(string alias = null, IncludeDirective include = null, SkipDirective skip = null) =>
            WithScalarField("slug", alias, new GraphQlDirective[] { include, skip });
        public AccountQueryBuilder ExceptSlug() =>
            ExceptField("slug");
        public AccountQueryBuilder WithTier(string alias = null, IncludeDirective include = null, SkipDirective skip = null) =>
            WithScalarField("tier", alias, new GraphQlDirective[] { include, skip });
        public AccountQueryBuilder ExceptTier() =>
            ExceptField("tier");
    }
}
