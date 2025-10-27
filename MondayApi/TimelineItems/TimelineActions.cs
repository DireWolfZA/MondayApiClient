using System;
using System.Threading.Tasks;
using MondayApi.Schema;

//https://developer.monday.com/api-reference/reference/timeline-item-ea
namespace MondayApi.TimelineItems {
    public class TimelineItemActions : ITimelineItemActions {
        private readonly IMondayApiClient client;
        public TimelineItemActions(IMondayApiClient client) {
            this.client = client;
        }

        public async Task<TimelineItemsPage?> Get(string? cursor, int numPerPage, string itemID) {
            var query = new QueryQueryBuilder().WithTimeline(
                new TimelineResponseQueryBuilder().WithAllScalarFields().WithTimelineItemsPage(
                    new TimelineItemsPageQueryBuilder().WithAllScalarFields().WithTimelineItems(
                        new TimelineItemQueryBuilder()
                            .WithAllScalarFields()
                            .WithUser(new UserQueryBuilder().WithID())
                    ),
                    cursor: cursor,
                    limit: numPerPage
                ),
                id: itemID
            );

            var response = await client.RunQuery(query);
            return response.Timeline?.TimelineItemsPage;
        }

        public async Task<TimelineItem?> GetOne(string id) {
            var query = new QueryQueryBuilder().WithTimelineItem(
                new TimelineItemQueryBuilder().WithAllScalarFields(),
                id: id
            );

            var response = await client.RunQuery(query);
            return response.TimelineItem;
        }

        /// <inheritdoc/>
        public async Task<TimelineItem> Create(
            string itemID, DateTimeOffset createdAt, string? userID = null, string? summary = null, string? content = null,
            string? title = null, string? customActivityID = null, TimelineItemTimeRange? timeRange = null
        ) {
            var mutation = new MutationQueryBuilder().WithCreateTimelineItem(
                new TimelineItemQueryBuilder().WithAllScalarFields(),
                itemID: itemID,
                title: title ?? "",
                timestamp: createdAt,
                customActivityID: customActivityID ?? "",
                userID: userID == null ? null : int.Parse(userID),
                summary: summary,
                content: content,
                timeRange: timeRange
            );

            var response = await client.RunMutation(mutation);
            return response.CreateTimelineItem!;
        }

        public async Task<TimelineItem> Delete(string id) {
            var mutation = new MutationQueryBuilder().WithDeleteTimelineItem(
                new TimelineItemQueryBuilder().WithAllScalarFields().ExceptCreatedAt(),
                id: id);

            var response = await client.RunMutation(mutation);
            return response.DeleteTimelineItem!;
        }
    }
}
