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

        public async Task<IEnumerable<Workspace>> Get(int pageNumber, int numPerPage) {
            var query = new QueryQueryBuilder().WithWorkspaces(
                new WorkspaceQueryBuilder().WithAllScalarFields(),
                page: pageNumber,
                limit: numPerPage
            );
            var response = await client.RunQuery(query);
            return response.Workspaces;
        }

        public async Task<Workspace> GetOne(string id) {
            var query = new QueryQueryBuilder().WithWorkspaces(
                new WorkspaceQueryBuilder().WithAllScalarFields(),
                ids: new string[] { id }
            );
            var response = await client.RunQuery(query);
            return response.Workspaces?.FirstOrDefault();
        }

        public async Task<Workspace> Create(Workspace workspace) {
            Utils.Utils.RequireArgument(nameof(workspace.Name), workspace.Name);
            Utils.Utils.RequireArgument(nameof(workspace.Kind), workspace.Kind);

            var mutation = new MutationQueryBuilder().WithCreateWorkspace(
                new WorkspaceQueryBuilder().WithAllScalarFields(),
                name: workspace.Name,
                kind: workspace.Kind,
                description: workspace.Description
            );

            var response = await client.RunMutation(mutation);
            return response.CreateWorkspace;
        }

        public async Task<Workspace> Delete(string id) {
            var mutation = new MutationQueryBuilder().WithDeleteWorkspace(new WorkspaceQueryBuilder().WithAllScalarFields(), id);

            var response = await client.RunMutation(mutation);
            return response.DeleteWorkspace;
        }
    }
}
