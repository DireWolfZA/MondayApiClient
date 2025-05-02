using System.Collections.Generic;

namespace MondayApi.Schema {
    public class GroupValueQueryBuilder : GraphQlQueryBuilder<GroupValueQueryBuilder> {
        private static readonly GraphQlFieldMetadata[] AllFieldMetadata = new[] {
            new GraphQlFieldMetadata { Name = "column", IsComplex = true, QueryBuilderType = typeof(ColumnQueryBuilder) },
            new GraphQlFieldMetadata { Name = "group", IsComplex = true, QueryBuilderType = typeof(GroupQueryBuilder) },
            new GraphQlFieldMetadata { Name = "group_id" },
            new GraphQlFieldMetadata { Name = "id" },
            new GraphQlFieldMetadata { Name = "text" },
            new GraphQlFieldMetadata { Name = "type" },
            new GraphQlFieldMetadata { Name = "value" }
        };

        protected override string TypeName => "GroupValue";
        public override IReadOnlyList<GraphQlFieldMetadata> AllFields => AllFieldMetadata;

        public GroupValueQueryBuilder WithColumn(ColumnQueryBuilder columnQueryBuilder, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithObjectField("column", alias, columnQueryBuilder, new GraphQlDirective?[] { include, skip });
        public GroupValueQueryBuilder ExceptColumn() =>
            ExceptField("column");
        public GroupValueQueryBuilder WithGroup(GroupQueryBuilder groupQueryBuilder, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithObjectField("group", alias, groupQueryBuilder, new GraphQlDirective?[] { include, skip });
        public GroupValueQueryBuilder ExceptGroup() =>
            ExceptField("group");
        public GroupValueQueryBuilder WithGroupID(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("group_id", alias, new GraphQlDirective?[] { include, skip });
        public GroupValueQueryBuilder ExceptGroupID() =>
            ExceptField("group_id");
        public GroupValueQueryBuilder WithID(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("id", alias, new GraphQlDirective?[] { include, skip });
        public GroupValueQueryBuilder ExceptID() =>
            ExceptField("id");
        public GroupValueQueryBuilder WithText(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("text", alias, new GraphQlDirective?[] { include, skip });
        public GroupValueQueryBuilder ExceptText() =>
            ExceptField("text");
        public GroupValueQueryBuilder WithType(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("type", alias, new GraphQlDirective?[] { include, skip });
        public GroupValueQueryBuilder ExceptType() =>
            ExceptField("type");
        public GroupValueQueryBuilder WithValue(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("value", alias, new GraphQlDirective?[] { include, skip });
        public GroupValueQueryBuilder ExceptValue() =>
            ExceptField("value");
    }
}
