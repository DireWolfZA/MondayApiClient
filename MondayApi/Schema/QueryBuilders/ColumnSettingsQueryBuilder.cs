using System;
using System.Collections.Generic;

namespace MondayApi.Schema {
    public class ColumnSettingsQueryBuilder : GraphQlQueryBuilder<ColumnSettingsQueryBuilder> {
        private static readonly GraphQlFieldMetadata[] AllFieldMetadata = Array.Empty<GraphQlFieldMetadata>();

        public ColumnSettingsQueryBuilder() => WithTypeName();
        protected override string TypeName => "ColumnSettings";
        public override IReadOnlyList<GraphQlFieldMetadata> AllFields => AllFieldMetadata;

        public ColumnSettingsQueryBuilder WithStatusColumnSettingsFragment(StatusColumnSettingsQueryBuilder statusColumnSettingsQueryBuilder, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithFragment(statusColumnSettingsQueryBuilder, new GraphQlDirective?[] { include, skip });
        public ColumnSettingsQueryBuilder WithDropdownColumnSettingsFragment(DropdownColumnSettingsQueryBuilder dropdownColumnSettingsQueryBuilder, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithFragment(dropdownColumnSettingsQueryBuilder, new GraphQlDirective?[] { include, skip });
    }
}
