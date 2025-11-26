using System.Threading.Tasks;
using MondayApi.Schema;

namespace MondayApi.TimelineItems {
    public interface ITimelineItemActions {
        Task<TimelineItemsPage?> Get(string? cursor, int numPerPage, string itemID, bool? skipConnectedItems = false);
        Task<TimelineItem?> GetOne(string id);
        /// <param name="summary">Limited to 255 characters</param>
        Task<TimelineItem> Create(string itemID, System.DateTimeOffset createdAt, string? userID = null, string? summary = null, string? content = null, string? title = null, string? customActivityID = null, TimelineItemTimeRange? timeRange = null);
        Task<TimelineItem> Delete(string id);
    }
}
