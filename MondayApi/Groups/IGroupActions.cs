using System.Collections.Generic;
using System.Threading.Tasks;
using MondayApi.Schema;

namespace MondayApi.Groups {
    public interface IGroupActions {
        Task<IEnumerable<Group>> GetAsync(string boardID);
        Task<Group> GetOneAsync(string boardID, string groupID);
    }
}
