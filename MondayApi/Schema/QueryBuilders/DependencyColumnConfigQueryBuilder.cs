using System.Collections.Generic;

namespace MondayApi.Schema {
    public class DependencyColumnConfigQueryBuilder : GraphQlQueryBuilder<DependencyColumnConfigQueryBuilder> {
        private static readonly GraphQlFieldMetadata[] AllFieldMetadata = new[] {
            new GraphQlFieldMetadata { Name = "id" },
            new GraphQlFieldMetadata { Name = "account_id" },
            new GraphQlFieldMetadata { Name = "board_id" },
            new GraphQlFieldMetadata { Name = "data" },
            new GraphQlFieldMetadata { Name = "created_at" },
            new GraphQlFieldMetadata { Name = "updated_at" },
            new GraphQlFieldMetadata { Name = "config_type" }
        };

        protected override string TypeName => "DependencyColumnConfig";
        public override IReadOnlyList<GraphQlFieldMetadata> AllFields => AllFieldMetadata;

        public DependencyColumnConfigQueryBuilder WithID(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("id", alias, new GraphQlDirective?[] { include, skip });
        public DependencyColumnConfigQueryBuilder ExceptID() =>
            ExceptField("id");
        public DependencyColumnConfigQueryBuilder WithAccountID(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("account_id", alias, new GraphQlDirective?[] { include, skip });
        public DependencyColumnConfigQueryBuilder ExceptAccountID() =>
            ExceptField("account_id");
        public DependencyColumnConfigQueryBuilder WithBoardID(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("board_id", alias, new GraphQlDirective?[] { include, skip });
        public DependencyColumnConfigQueryBuilder ExceptBoardID() =>
            ExceptField("board_id");
        public DependencyColumnConfigQueryBuilder WithData(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("data", alias, new GraphQlDirective?[] { include, skip });
        public DependencyColumnConfigQueryBuilder ExceptData() =>
            ExceptField("data");
        public DependencyColumnConfigQueryBuilder WithCreatedAt(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("created_at", alias, new GraphQlDirective?[] { include, skip });
        public DependencyColumnConfigQueryBuilder ExceptCreatedAt() =>
            ExceptField("created_at");
        public DependencyColumnConfigQueryBuilder WithUpdatedAt(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("updated_at", alias, new GraphQlDirective?[] { include, skip });
        public DependencyColumnConfigQueryBuilder ExceptUpdatedAt() =>
            ExceptField("updated_at");
        public DependencyColumnConfigQueryBuilder WithConfigType(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("config_type", alias, new GraphQlDirective?[] { include, skip });
        public DependencyColumnConfigQueryBuilder ExceptConfigType() =>
            ExceptField("config_type");
    }
}
