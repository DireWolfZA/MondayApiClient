﻿using System.Collections.Generic;
using System.Threading.Tasks;
using MondayApi.Schema;

namespace MondayApi.Updates {
    public interface IUpdateActions {
        Task<IEnumerable<Update>> GetAsync(int pageNumber, int numPerPage, bool? includeReplies = false);
        Task<IEnumerable<Update>> GetByBoardAsync(int pageNumber, int numPerPage, string boardID, bool? includeReplies = false);
        Task<IEnumerable<Update>> GetByItemAsync(int pageNumber, int numPerPage, string itemID, bool? includeReplies = false);
    }
}