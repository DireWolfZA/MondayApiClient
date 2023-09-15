using System.Collections.Generic;
using System.Threading.Tasks;
using MondayApi.Schema;

namespace MondayApi.Groups {
    public interface IGroupActions {
        Task<IEnumerable<Group>> GetAsync(string boardID);
        Task<Group> GetOneAsync(string boardID, string groupID);
        Task<Group> CreateAsync(string boardID, Group group, string relativeTo = null, PositionRelative? positionRelative = null);
        Task<Group> UpdateAsync(string boardID, string groupID, GroupAttributes attribute, string newValue);
        Task<Group> DeleteAsync(string boardID, string groupID);
    }
}
