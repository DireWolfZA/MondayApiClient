using System.Collections.Generic;

namespace MondayApi.Schema {
    public class GrantMarketplaceAppDiscountResultQueryBuilder : GraphQlQueryBuilder<GrantMarketplaceAppDiscountResultQueryBuilder> {
        private static readonly GraphQlFieldMetadata[] AllFieldMetadata = new[] {
            new GraphQlFieldMetadata { Name = "granted_discount", IsComplex = true, QueryBuilderType = typeof(GrantMarketplaceAppDiscountQueryBuilder) }
        };

        protected override string TypeName => "GrantMarketplaceAppDiscountResult";
        public override IReadOnlyList<GraphQlFieldMetadata> AllFields => AllFieldMetadata;

        public GrantMarketplaceAppDiscountResultQueryBuilder WithGrantedDiscount(GrantMarketplaceAppDiscountQueryBuilder grantMarketplaceAppDiscountQueryBuilder, string alias = null, IncludeDirective include = null, SkipDirective skip = null) =>
            WithObjectField("granted_discount", alias, grantMarketplaceAppDiscountQueryBuilder, new GraphQlDirective[] { include, skip });
        public GrantMarketplaceAppDiscountResultQueryBuilder ExceptGrantedDiscount() =>
            ExceptField("granted_discount");
    }
}
