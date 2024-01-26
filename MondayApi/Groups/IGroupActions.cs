using System.Collections.Generic;
using System.Threading.Tasks;
using MondayApi.Schema;

namespace MondayApi.Groups {
    public interface IGroupActions {
        Task<IEnumerable<Group>> GetAsync(string boardID);
        Task<Group> GetOneAsync(string boardID, string groupID);
        Task<Group> CreateAsync(string boardID, string title, string relativeTo = null, PositionRelative? positionRelative = null);
        /// <summary>When updating group color, see <seealso href="https://dapulse-res.cloudinary.com/image/upload/v1669754611/remote_mondaycom_static/developers/screenshots/status-labels-2.png" /> for valid color names</summary>
        Task<Group> UpdateAsync(string boardID, string groupID, GroupAttributes attribute, string newValue);
        Task<Group> DeleteAsync(string boardID, string groupID);
    }
}
