using System.Collections.Generic;
using System.Threading.Tasks;
using MondayApi.Schema;

namespace MondayApi.Workspaces {
    public interface IWorkspaceActions {
        Task<IEnumerable<Workspace>> GetAsync(int pageNumber, int numPerPage);
        Task<Workspace> GetOneAsync(string id);
        Task<Workspace> CreateAsync(Workspace workspace);
        Task<Workspace> DeleteAsync(string id);
    }
}
