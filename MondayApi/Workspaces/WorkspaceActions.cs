using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MondayApi.Schema;

//https://developer.monday.com/api-reference/docs/workspaces
namespace MondayApi.Workspaces {
    public class WorkspaceActions : IWorkspaceActions {
        private readonly IMondayApiClient client;
        public WorkspaceActions(IMondayApiClient client) {
            this.client = client;
        }

        public async Task<IEnumerable<Workspace>> GetAsync(int pageNumber, int numPerPage) {
            var query = new QueryQueryBuilder().WithWorkspaces(
                new WorkspaceQueryBuilder().WithAllScalarFields(),
                limit: Utils.GetParameter<int?>(numPerPage),
                page: Utils.GetParameter<int?>(pageNumber)
            );
            var response = await client.RunQuery(query);
            return response.Workspaces;
        }

        public async Task<Workspace> GetOneAsync(string id) {
            var query = new QueryQueryBuilder().WithWorkspaces(
                new WorkspaceQueryBuilder().WithAllScalarFields(),
                ids: Utils.GetParameterToMulti(id)
            );
            var response = await client.RunQuery(query);
            return response.Workspaces?.FirstOrDefault();
        }
    }
}
