using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using MondayApi.Schema;

namespace MondayApi.ActivityLogs {
    public interface IActivityLogActions {
        Task<IEnumerable<ActivityLogType>> Get(int pageNumber, int numPerPage, string boardID,
            string[]? userIDs = null, string[]? columnIDs = null, string[]? groupIDs = null,
            string[]? itemIDs = null, DateTime? from = null, DateTime? to = null);
    }
}
