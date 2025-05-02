using System.Collections.Generic;

namespace MondayApi.Schema {
    public class DeleteMarketplaceAppDiscountResultQueryBuilder : GraphQlQueryBuilder<DeleteMarketplaceAppDiscountResultQueryBuilder> {
        private static readonly GraphQlFieldMetadata[] AllFieldMetadata = new[] {
            new GraphQlFieldMetadata { Name = "deleted_discount", IsComplex = true, QueryBuilderType = typeof(DeleteMarketplaceAppDiscountQueryBuilder) }
        };

        protected override string TypeName => "DeleteMarketplaceAppDiscountResult";
        public override IReadOnlyList<GraphQlFieldMetadata> AllFields => AllFieldMetadata;

        public DeleteMarketplaceAppDiscountResultQueryBuilder WithDeletedDiscount(DeleteMarketplaceAppDiscountQueryBuilder deleteMarketplaceAppDiscountQueryBuilder, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithObjectField("deleted_discount", alias, deleteMarketplaceAppDiscountQueryBuilder, new GraphQlDirective?[] { include, skip });
        public DeleteMarketplaceAppDiscountResultQueryBuilder ExceptDeletedDiscount() =>
            ExceptField("deleted_discount");
    }
}
