using System.Collections.Generic;
using System.Threading.Tasks;
using MondayApi.Schema;

namespace MondayApi.Workspaces {
    public interface IWorkspaceActions {
        Task<IEnumerable<Workspace>> Get(int pageNumber, int numPerPage);
        Task<Workspace> GetOne(string id);
        Task<Workspace> Create(Workspace workspace);
        Task<Workspace> Delete(string id);
    }
}
