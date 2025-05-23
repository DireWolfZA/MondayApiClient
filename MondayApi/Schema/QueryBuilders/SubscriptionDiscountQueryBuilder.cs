using System.Collections.Generic;

namespace MondayApi.Schema {
    public class SubscriptionDiscountQueryBuilder : GraphQlQueryBuilder<SubscriptionDiscountQueryBuilder> {
        private static readonly GraphQlFieldMetadata[] AllFieldMetadata = new[] {
            new GraphQlFieldMetadata { Name = "value" },
            new GraphQlFieldMetadata { Name = "discount_model_type" },
            new GraphQlFieldMetadata { Name = "discount_type" }
        };

        protected override string TypeName => "SubscriptionDiscount";
        public override IReadOnlyList<GraphQlFieldMetadata> AllFields => AllFieldMetadata;

        public SubscriptionDiscountQueryBuilder WithValue(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("value", alias, new GraphQlDirective?[] { include, skip });
        public SubscriptionDiscountQueryBuilder ExceptValue() =>
            ExceptField("value");
        public SubscriptionDiscountQueryBuilder WithDiscountModelType(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("discount_model_type", alias, new GraphQlDirective?[] { include, skip });
        public SubscriptionDiscountQueryBuilder ExceptDiscountModelType() =>
            ExceptField("discount_model_type");
        public SubscriptionDiscountQueryBuilder WithDiscountType(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("discount_type", alias, new GraphQlDirective?[] { include, skip });
        public SubscriptionDiscountQueryBuilder ExceptDiscountType() =>
            ExceptField("discount_type");
    }
}
