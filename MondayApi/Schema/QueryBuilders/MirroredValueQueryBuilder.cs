using System.Collections.Generic;

namespace MondayApi.Schema {
    public class MirroredValueQueryBuilder : GraphQlQueryBuilder<MirroredValueQueryBuilder> {
        private static readonly GraphQlFieldMetadata[] AllFieldMetadata = new GraphQlFieldMetadata[0];

        public MirroredValueQueryBuilder() => WithTypeName();
        protected override string TypeName => "MirroredValue";
        public override IReadOnlyList<GraphQlFieldMetadata> AllFields => AllFieldMetadata;

        public MirroredValueQueryBuilder WithBoardFragment(BoardQueryBuilder boardQueryBuilder, IncludeDirective include = null, SkipDirective skip = null) =>
            WithFragment(boardQueryBuilder, new GraphQlDirective[] { include, skip });
        public MirroredValueQueryBuilder WithBoardRelationValueFragment(BoardRelationValueQueryBuilder boardRelationValueQueryBuilder, IncludeDirective include = null, SkipDirective skip = null) =>
            WithFragment(boardRelationValueQueryBuilder, new GraphQlDirective[] { include, skip });
        public MirroredValueQueryBuilder WithButtonValueFragment(ButtonValueQueryBuilder buttonValueQueryBuilder, IncludeDirective include = null, SkipDirective skip = null) =>
            WithFragment(buttonValueQueryBuilder, new GraphQlDirective[] { include, skip });
        public MirroredValueQueryBuilder WithCheckboxValueFragment(CheckboxValueQueryBuilder checkboxValueQueryBuilder, IncludeDirective include = null, SkipDirective skip = null) =>
            WithFragment(checkboxValueQueryBuilder, new GraphQlDirective[] { include, skip });
        public MirroredValueQueryBuilder WithColorPickerValueFragment(ColorPickerValueQueryBuilder colorPickerValueQueryBuilder, IncludeDirective include = null, SkipDirective skip = null) =>
            WithFragment(colorPickerValueQueryBuilder, new GraphQlDirective[] { include, skip });
        public MirroredValueQueryBuilder WithCountryValueFragment(CountryValueQueryBuilder countryValueQueryBuilder, IncludeDirective include = null, SkipDirective skip = null) =>
            WithFragment(countryValueQueryBuilder, new GraphQlDirective[] { include, skip });
        public MirroredValueQueryBuilder WithCreationLogValueFragment(CreationLogValueQueryBuilder creationLogValueQueryBuilder, IncludeDirective include = null, SkipDirective skip = null) =>
            WithFragment(creationLogValueQueryBuilder, new GraphQlDirective[] { include, skip });
        public MirroredValueQueryBuilder WithDateValueFragment(DateValueQueryBuilder dateValueQueryBuilder, IncludeDirective include = null, SkipDirective skip = null) =>
            WithFragment(dateValueQueryBuilder, new GraphQlDirective[] { include, skip });
        public MirroredValueQueryBuilder WithDependencyValueFragment(DependencyValueQueryBuilder dependencyValueQueryBuilder, IncludeDirective include = null, SkipDirective skip = null) =>
            WithFragment(dependencyValueQueryBuilder, new GraphQlDirective[] { include, skip });
        public MirroredValueQueryBuilder WithDocValueFragment(DocValueQueryBuilder docValueQueryBuilder, IncludeDirective include = null, SkipDirective skip = null) =>
            WithFragment(docValueQueryBuilder, new GraphQlDirective[] { include, skip });
        public MirroredValueQueryBuilder WithDropdownValueFragment(DropdownValueQueryBuilder dropdownValueQueryBuilder, IncludeDirective include = null, SkipDirective skip = null) =>
            WithFragment(dropdownValueQueryBuilder, new GraphQlDirective[] { include, skip });
        public MirroredValueQueryBuilder WithEmailValueFragment(EmailValueQueryBuilder emailValueQueryBuilder, IncludeDirective include = null, SkipDirective skip = null) =>
            WithFragment(emailValueQueryBuilder, new GraphQlDirective[] { include, skip });
        public MirroredValueQueryBuilder WithFileValueFragment(FileValueQueryBuilder fileValueQueryBuilder, IncludeDirective include = null, SkipDirective skip = null) =>
            WithFragment(fileValueQueryBuilder, new GraphQlDirective[] { include, skip });
        public MirroredValueQueryBuilder WithFormulaValueFragment(FormulaValueQueryBuilder formulaValueQueryBuilder, IncludeDirective include = null, SkipDirective skip = null) =>
            WithFragment(formulaValueQueryBuilder, new GraphQlDirective[] { include, skip });
        public MirroredValueQueryBuilder WithGroupFragment(GroupQueryBuilder groupQueryBuilder, IncludeDirective include = null, SkipDirective skip = null) =>
            WithFragment(groupQueryBuilder, new GraphQlDirective[] { include, skip });
        public MirroredValueQueryBuilder WithHourValueFragment(HourValueQueryBuilder hourValueQueryBuilder, IncludeDirective include = null, SkipDirective skip = null) =>
            WithFragment(hourValueQueryBuilder, new GraphQlDirective[] { include, skip });
        public MirroredValueQueryBuilder WithIntegrationValueFragment(IntegrationValueQueryBuilder integrationValueQueryBuilder, IncludeDirective include = null, SkipDirective skip = null) =>
            WithFragment(integrationValueQueryBuilder, new GraphQlDirective[] { include, skip });
        public MirroredValueQueryBuilder WithItemIdValueFragment(ItemIdValueQueryBuilder itemIdValueQueryBuilder, IncludeDirective include = null, SkipDirective skip = null) =>
            WithFragment(itemIdValueQueryBuilder, new GraphQlDirective[] { include, skip });
        public MirroredValueQueryBuilder WithLastUpdatedValueFragment(LastUpdatedValueQueryBuilder lastUpdatedValueQueryBuilder, IncludeDirective include = null, SkipDirective skip = null) =>
            WithFragment(lastUpdatedValueQueryBuilder, new GraphQlDirective[] { include, skip });
        public MirroredValueQueryBuilder WithLinkValueFragment(LinkValueQueryBuilder linkValueQueryBuilder, IncludeDirective include = null, SkipDirective skip = null) =>
            WithFragment(linkValueQueryBuilder, new GraphQlDirective[] { include, skip });
        public MirroredValueQueryBuilder WithLocationValueFragment(LocationValueQueryBuilder locationValueQueryBuilder, IncludeDirective include = null, SkipDirective skip = null) =>
            WithFragment(locationValueQueryBuilder, new GraphQlDirective[] { include, skip });
        public MirroredValueQueryBuilder WithLongTextValueFragment(LongTextValueQueryBuilder longTextValueQueryBuilder, IncludeDirective include = null, SkipDirective skip = null) =>
            WithFragment(longTextValueQueryBuilder, new GraphQlDirective[] { include, skip });
        public MirroredValueQueryBuilder WithMirrorValueFragment(MirrorValueQueryBuilder mirrorValueQueryBuilder, IncludeDirective include = null, SkipDirective skip = null) =>
            WithFragment(mirrorValueQueryBuilder, new GraphQlDirective[] { include, skip });
        public MirroredValueQueryBuilder WithNumbersValueFragment(NumbersValueQueryBuilder numbersValueQueryBuilder, IncludeDirective include = null, SkipDirective skip = null) =>
            WithFragment(numbersValueQueryBuilder, new GraphQlDirective[] { include, skip });
        public MirroredValueQueryBuilder WithPeopleValueFragment(PeopleValueQueryBuilder peopleValueQueryBuilder, IncludeDirective include = null, SkipDirective skip = null) =>
            WithFragment(peopleValueQueryBuilder, new GraphQlDirective[] { include, skip });
        public MirroredValueQueryBuilder WithPhoneValueFragment(PhoneValueQueryBuilder phoneValueQueryBuilder, IncludeDirective include = null, SkipDirective skip = null) =>
            WithFragment(phoneValueQueryBuilder, new GraphQlDirective[] { include, skip });
        public MirroredValueQueryBuilder WithProgressValueFragment(ProgressValueQueryBuilder progressValueQueryBuilder, IncludeDirective include = null, SkipDirective skip = null) =>
            WithFragment(progressValueQueryBuilder, new GraphQlDirective[] { include, skip });
        public MirroredValueQueryBuilder WithRatingValueFragment(RatingValueQueryBuilder ratingValueQueryBuilder, IncludeDirective include = null, SkipDirective skip = null) =>
            WithFragment(ratingValueQueryBuilder, new GraphQlDirective[] { include, skip });
        public MirroredValueQueryBuilder WithStatusValueFragment(StatusValueQueryBuilder statusValueQueryBuilder, IncludeDirective include = null, SkipDirective skip = null) =>
            WithFragment(statusValueQueryBuilder, new GraphQlDirective[] { include, skip });
        public MirroredValueQueryBuilder WithSubtasksValueFragment(SubtasksValueQueryBuilder subtasksValueQueryBuilder, IncludeDirective include = null, SkipDirective skip = null) =>
            WithFragment(subtasksValueQueryBuilder, new GraphQlDirective[] { include, skip });
        public MirroredValueQueryBuilder WithTagsValueFragment(TagsValueQueryBuilder tagsValueQueryBuilder, IncludeDirective include = null, SkipDirective skip = null) =>
            WithFragment(tagsValueQueryBuilder, new GraphQlDirective[] { include, skip });
        public MirroredValueQueryBuilder WithTeamValueFragment(TeamValueQueryBuilder teamValueQueryBuilder, IncludeDirective include = null, SkipDirective skip = null) =>
            WithFragment(teamValueQueryBuilder, new GraphQlDirective[] { include, skip });
        public MirroredValueQueryBuilder WithTextValueFragment(TextValueQueryBuilder textValueQueryBuilder, IncludeDirective include = null, SkipDirective skip = null) =>
            WithFragment(textValueQueryBuilder, new GraphQlDirective[] { include, skip });
        public MirroredValueQueryBuilder WithTimeTrackingValueFragment(TimeTrackingValueQueryBuilder timeTrackingValueQueryBuilder, IncludeDirective include = null, SkipDirective skip = null) =>
            WithFragment(timeTrackingValueQueryBuilder, new GraphQlDirective[] { include, skip });
        public MirroredValueQueryBuilder WithTimelineValueFragment(TimelineValueQueryBuilder timelineValueQueryBuilder, IncludeDirective include = null, SkipDirective skip = null) =>
            WithFragment(timelineValueQueryBuilder, new GraphQlDirective[] { include, skip });
        public MirroredValueQueryBuilder WithUnsupportedValueFragment(UnsupportedValueQueryBuilder unsupportedValueQueryBuilder, IncludeDirective include = null, SkipDirective skip = null) =>
            WithFragment(unsupportedValueQueryBuilder, new GraphQlDirective[] { include, skip });
        public MirroredValueQueryBuilder WithVoteValueFragment(VoteValueQueryBuilder voteValueQueryBuilder, IncludeDirective include = null, SkipDirective skip = null) =>
            WithFragment(voteValueQueryBuilder, new GraphQlDirective[] { include, skip });
        public MirroredValueQueryBuilder WithWeekValueFragment(WeekValueQueryBuilder weekValueQueryBuilder, IncludeDirective include = null, SkipDirective skip = null) =>
            WithFragment(weekValueQueryBuilder, new GraphQlDirective[] { include, skip });
        public MirroredValueQueryBuilder WithWorldClockValueFragment(WorldClockValueQueryBuilder worldClockValueQueryBuilder, IncludeDirective include = null, SkipDirective skip = null) =>
            WithFragment(worldClockValueQueryBuilder, new GraphQlDirective[] { include, skip });
    }
}
