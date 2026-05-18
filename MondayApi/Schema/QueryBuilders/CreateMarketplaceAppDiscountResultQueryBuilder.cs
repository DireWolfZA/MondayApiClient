using System.Collections.Generic;

namespace MondayApi.Schema {
    public class CreateMarketplaceAppDiscountResultQueryBuilder : GraphQlQueryBuilder<CreateMarketplaceAppDiscountResultQueryBuilder> {
        private static readonly GraphQlFieldMetadata[] AllFieldMetadata = new[] {
            new GraphQlFieldMetadata { Name = "granted_discount", IsComplex = true, QueryBuilderType = typeof(CreateMarketplaceAppDiscountQueryBuilder) }
        };

        protected override string TypeName => "CreateMarketplaceAppDiscountResult";
        public override IReadOnlyList<GraphQlFieldMetadata> AllFields => AllFieldMetadata;

        public CreateMarketplaceAppDiscountResultQueryBuilder WithGrantedDiscount(CreateMarketplaceAppDiscountQueryBuilder createMarketplaceAppDiscountQueryBuilder, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithObjectField("granted_discount", alias, createMarketplaceAppDiscountQueryBuilder, new GraphQlDirective?[] { include, skip });
        public CreateMarketplaceAppDiscountResultQueryBuilder ExceptGrantedDiscount() =>
            ExceptField("granted_discount");
    }
}
