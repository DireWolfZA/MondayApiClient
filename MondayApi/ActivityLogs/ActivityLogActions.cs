using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MondayApi.Schema;

//https://developer.monday.com/api-reference/reference/activity-logs
namespace MondayApi.ActivityLogs {
    public class ActivityLogActions : IActivityLogActions {
        private readonly IMondayApiClient client;
        public ActivityLogActions(IMondayApiClient client) {
            this.client = client;
        }

        public async Task<IEnumerable<ActivityLogType>> Get(int pageNumber, int numPerPage, string boardID,
                string[]? userIDs = null, string[]? columnIDs = null, string[]? groupIDs = null,
                string[]? itemIDs = null, DateTime? from = null, DateTime? to = null) {

            var query = new QueryQueryBuilder().WithBoards(
                new BoardQueryBuilder().WithActivityLogs(
                    new ActivityLogTypeQueryBuilder().WithAllScalarFields(),
                    page: pageNumber,
                    limit: numPerPage,
                    userIDs: userIDs,
                    columnIDs: columnIDs,
                    groupIDs: groupIDs,
                    itemIDs: itemIDs,
                    from: (DateTimeOffset?)from,
                    to: (DateTimeOffset?)to
                ),
                ids: new string[] { boardID }
            );

            var response = await client.RunQuery(query);
            return response.Boards.First()!.ActivityLogs!;
        }
    }
}
