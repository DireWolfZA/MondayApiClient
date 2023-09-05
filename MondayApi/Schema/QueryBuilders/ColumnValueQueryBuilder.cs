using System.Collections.Generic;

namespace MondayApi.Schema {
    public class ColumnValueQueryBuilder : GraphQlQueryBuilder<ColumnValueQueryBuilder> {
        private static readonly GraphQlFieldMetadata[] AllFieldMetadata = new[] {
            new GraphQlFieldMetadata { Name = "column", IsComplex = true, QueryBuilderType = typeof(ColumnQueryBuilder) },
            new GraphQlFieldMetadata { Name = "id" },
            new GraphQlFieldMetadata { Name = "text" },
            new GraphQlFieldMetadata { Name = "type" },
            new GraphQlFieldMetadata { Name = "value", IsComplex = true }
        };

        public ColumnValueQueryBuilder() => WithTypeName();
        protected override string TypeName => "ColumnValue";
        public override IReadOnlyList<GraphQlFieldMetadata> AllFields => AllFieldMetadata;

        public ColumnValueQueryBuilder WithColumn(ColumnQueryBuilder columnQueryBuilder, string alias = null, IncludeDirective include = null, SkipDirective skip = null) =>
            WithObjectField("column", alias, columnQueryBuilder, new GraphQlDirective[] { include, skip });
        public ColumnValueQueryBuilder ExceptColumn() =>
            ExceptField("column");
        public ColumnValueQueryBuilder WithId(string alias = null, IncludeDirective include = null, SkipDirective skip = null) =>
            WithScalarField("id", alias, new GraphQlDirective[] { include, skip });
        public ColumnValueQueryBuilder ExceptId() =>
            ExceptField("id");
        public ColumnValueQueryBuilder WithText(string alias = null, IncludeDirective include = null, SkipDirective skip = null) =>
            WithScalarField("text", alias, new GraphQlDirective[] { include, skip });
        public ColumnValueQueryBuilder ExceptText() =>
            ExceptField("text");
        public ColumnValueQueryBuilder WithType(string alias = null, IncludeDirective include = null, SkipDirective skip = null) =>
            WithScalarField("type", alias, new GraphQlDirective[] { include, skip });
        public ColumnValueQueryBuilder ExceptType() =>
            ExceptField("type");
        public ColumnValueQueryBuilder WithValue(string alias = null, IncludeDirective include = null, SkipDirective skip = null) =>
            WithScalarField("value", alias, new GraphQlDirective[] { include, skip });
        public ColumnValueQueryBuilder ExceptValue() =>
            ExceptField("value");
        public ColumnValueQueryBuilder WithBoardRelationValueFragment(BoardRelationValueQueryBuilder boardRelationValueQueryBuilder, IncludeDirective include = null, SkipDirective skip = null) =>
            WithFragment(boardRelationValueQueryBuilder, new GraphQlDirective[] { include, skip });
        public ColumnValueQueryBuilder WithButtonValueFragment(ButtonValueQueryBuilder buttonValueQueryBuilder, IncludeDirective include = null, SkipDirective skip = null) =>
            WithFragment(buttonValueQueryBuilder, new GraphQlDirective[] { include, skip });
        public ColumnValueQueryBuilder WithCheckboxValueFragment(CheckboxValueQueryBuilder checkboxValueQueryBuilder, IncludeDirective include = null, SkipDirective skip = null) =>
            WithFragment(checkboxValueQueryBuilder, new GraphQlDirective[] { include, skip });
        public ColumnValueQueryBuilder WithColorPickerValueFragment(ColorPickerValueQueryBuilder colorPickerValueQueryBuilder, IncludeDirective include = null, SkipDirective skip = null) =>
            WithFragment(colorPickerValueQueryBuilder, new GraphQlDirective[] { include, skip });
        public ColumnValueQueryBuilder WithCountryValueFragment(CountryValueQueryBuilder countryValueQueryBuilder, IncludeDirective include = null, SkipDirective skip = null) =>
            WithFragment(countryValueQueryBuilder, new GraphQlDirective[] { include, skip });
        public ColumnValueQueryBuilder WithCreationLogValueFragment(CreationLogValueQueryBuilder creationLogValueQueryBuilder, IncludeDirective include = null, SkipDirective skip = null) =>
            WithFragment(creationLogValueQueryBuilder, new GraphQlDirective[] { include, skip });
        public ColumnValueQueryBuilder WithDateValueFragment(DateValueQueryBuilder dateValueQueryBuilder, IncludeDirective include = null, SkipDirective skip = null) =>
            WithFragment(dateValueQueryBuilder, new GraphQlDirective[] { include, skip });
        public ColumnValueQueryBuilder WithDependencyValueFragment(DependencyValueQueryBuilder dependencyValueQueryBuilder, IncludeDirective include = null, SkipDirective skip = null) =>
            WithFragment(dependencyValueQueryBuilder, new GraphQlDirective[] { include, skip });
        public ColumnValueQueryBuilder WithDocValueFragment(DocValueQueryBuilder docValueQueryBuilder, IncludeDirective include = null, SkipDirective skip = null) =>
            WithFragment(docValueQueryBuilder, new GraphQlDirective[] { include, skip });
        public ColumnValueQueryBuilder WithDropdownValueFragment(DropdownValueQueryBuilder dropdownValueQueryBuilder, IncludeDirective include = null, SkipDirective skip = null) =>
            WithFragment(dropdownValueQueryBuilder, new GraphQlDirective[] { include, skip });
        public ColumnValueQueryBuilder WithEmailValueFragment(EmailValueQueryBuilder emailValueQueryBuilder, IncludeDirective include = null, SkipDirective skip = null) =>
            WithFragment(emailValueQueryBuilder, new GraphQlDirective[] { include, skip });
        public ColumnValueQueryBuilder WithFileValueFragment(FileValueQueryBuilder fileValueQueryBuilder, IncludeDirective include = null, SkipDirective skip = null) =>
            WithFragment(fileValueQueryBuilder, new GraphQlDirective[] { include, skip });
        public ColumnValueQueryBuilder WithFormulaValueFragment(FormulaValueQueryBuilder formulaValueQueryBuilder, IncludeDirective include = null, SkipDirective skip = null) =>
            WithFragment(formulaValueQueryBuilder, new GraphQlDirective[] { include, skip });
        public ColumnValueQueryBuilder WithHourValueFragment(HourValueQueryBuilder hourValueQueryBuilder, IncludeDirective include = null, SkipDirective skip = null) =>
            WithFragment(hourValueQueryBuilder, new GraphQlDirective[] { include, skip });
        public ColumnValueQueryBuilder WithIntegrationValueFragment(IntegrationValueQueryBuilder integrationValueQueryBuilder, IncludeDirective include = null, SkipDirective skip = null) =>
            WithFragment(integrationValueQueryBuilder, new GraphQlDirective[] { include, skip });
        public ColumnValueQueryBuilder WithItemIdValueFragment(ItemIdValueQueryBuilder itemIdValueQueryBuilder, IncludeDirective include = null, SkipDirective skip = null) =>
            WithFragment(itemIdValueQueryBuilder, new GraphQlDirective[] { include, skip });
        public ColumnValueQueryBuilder WithLastUpdatedValueFragment(LastUpdatedValueQueryBuilder lastUpdatedValueQueryBuilder, IncludeDirective include = null, SkipDirective skip = null) =>
            WithFragment(lastUpdatedValueQueryBuilder, new GraphQlDirective[] { include, skip });
        public ColumnValueQueryBuilder WithLinkValueFragment(LinkValueQueryBuilder linkValueQueryBuilder, IncludeDirective include = null, SkipDirective skip = null) =>
            WithFragment(linkValueQueryBuilder, new GraphQlDirective[] { include, skip });
        public ColumnValueQueryBuilder WithLocationValueFragment(LocationValueQueryBuilder locationValueQueryBuilder, IncludeDirective include = null, SkipDirective skip = null) =>
            WithFragment(locationValueQueryBuilder, new GraphQlDirective[] { include, skip });
        public ColumnValueQueryBuilder WithLongTextValueFragment(LongTextValueQueryBuilder longTextValueQueryBuilder, IncludeDirective include = null, SkipDirective skip = null) =>
            WithFragment(longTextValueQueryBuilder, new GraphQlDirective[] { include, skip });
        public ColumnValueQueryBuilder WithMirrorValueFragment(MirrorValueQueryBuilder mirrorValueQueryBuilder, IncludeDirective include = null, SkipDirective skip = null) =>
            WithFragment(mirrorValueQueryBuilder, new GraphQlDirective[] { include, skip });
        public ColumnValueQueryBuilder WithNumbersValueFragment(NumbersValueQueryBuilder numbersValueQueryBuilder, IncludeDirective include = null, SkipDirective skip = null) =>
            WithFragment(numbersValueQueryBuilder, new GraphQlDirective[] { include, skip });
        public ColumnValueQueryBuilder WithPeopleValueFragment(PeopleValueQueryBuilder peopleValueQueryBuilder, IncludeDirective include = null, SkipDirective skip = null) =>
            WithFragment(peopleValueQueryBuilder, new GraphQlDirective[] { include, skip });
        public ColumnValueQueryBuilder WithPhoneValueFragment(PhoneValueQueryBuilder phoneValueQueryBuilder, IncludeDirective include = null, SkipDirective skip = null) =>
            WithFragment(phoneValueQueryBuilder, new GraphQlDirective[] { include, skip });
        public ColumnValueQueryBuilder WithProgressValueFragment(ProgressValueQueryBuilder progressValueQueryBuilder, IncludeDirective include = null, SkipDirective skip = null) =>
            WithFragment(progressValueQueryBuilder, new GraphQlDirective[] { include, skip });
        public ColumnValueQueryBuilder WithRatingValueFragment(RatingValueQueryBuilder ratingValueQueryBuilder, IncludeDirective include = null, SkipDirective skip = null) =>
            WithFragment(ratingValueQueryBuilder, new GraphQlDirective[] { include, skip });
        public ColumnValueQueryBuilder WithStatusValueFragment(StatusValueQueryBuilder statusValueQueryBuilder, IncludeDirective include = null, SkipDirective skip = null) =>
            WithFragment(statusValueQueryBuilder, new GraphQlDirective[] { include, skip });
        public ColumnValueQueryBuilder WithSubtasksValueFragment(SubtasksValueQueryBuilder subtasksValueQueryBuilder, IncludeDirective include = null, SkipDirective skip = null) =>
            WithFragment(subtasksValueQueryBuilder, new GraphQlDirective[] { include, skip });
        public ColumnValueQueryBuilder WithTagsValueFragment(TagsValueQueryBuilder tagsValueQueryBuilder, IncludeDirective include = null, SkipDirective skip = null) =>
            WithFragment(tagsValueQueryBuilder, new GraphQlDirective[] { include, skip });
        public ColumnValueQueryBuilder WithTeamValueFragment(TeamValueQueryBuilder teamValueQueryBuilder, IncludeDirective include = null, SkipDirective skip = null) =>
            WithFragment(teamValueQueryBuilder, new GraphQlDirective[] { include, skip });
        public ColumnValueQueryBuilder WithTextValueFragment(TextValueQueryBuilder textValueQueryBuilder, IncludeDirective include = null, SkipDirective skip = null) =>
            WithFragment(textValueQueryBuilder, new GraphQlDirective[] { include, skip });
        public ColumnValueQueryBuilder WithTimeTrackingValueFragment(TimeTrackingValueQueryBuilder timeTrackingValueQueryBuilder, IncludeDirective include = null, SkipDirective skip = null) =>
            WithFragment(timeTrackingValueQueryBuilder, new GraphQlDirective[] { include, skip });
        public ColumnValueQueryBuilder WithTimelineValueFragment(TimelineValueQueryBuilder timelineValueQueryBuilder, IncludeDirective include = null, SkipDirective skip = null) =>
            WithFragment(timelineValueQueryBuilder, new GraphQlDirective[] { include, skip });
        public ColumnValueQueryBuilder WithUnsupportedValueFragment(UnsupportedValueQueryBuilder unsupportedValueQueryBuilder, IncludeDirective include = null, SkipDirective skip = null) =>
            WithFragment(unsupportedValueQueryBuilder, new GraphQlDirective[] { include, skip });
        public ColumnValueQueryBuilder WithVoteValueFragment(VoteValueQueryBuilder voteValueQueryBuilder, IncludeDirective include = null, SkipDirective skip = null) =>
            WithFragment(voteValueQueryBuilder, new GraphQlDirective[] { include, skip });
        public ColumnValueQueryBuilder WithWeekValueFragment(WeekValueQueryBuilder weekValueQueryBuilder, IncludeDirective include = null, SkipDirective skip = null) =>
            WithFragment(weekValueQueryBuilder, new GraphQlDirective[] { include, skip });
        public ColumnValueQueryBuilder WithWorldClockValueFragment(WorldClockValueQueryBuilder worldClockValueQueryBuilder, IncludeDirective include = null, SkipDirective skip = null) =>
            WithFragment(worldClockValueQueryBuilder, new GraphQlDirective[] { include, skip });
    }
}
