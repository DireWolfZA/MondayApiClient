using System.Threading.Tasks;
using MondayApi.Assets;
using MondayApi.Boards;
using MondayApi.Columns;
using MondayApi.Groups;
using MondayApi.Items;
using MondayApi.Schema;
using MondayApi.Subitems;
using MondayApi.Updates;
using MondayApi.Users;
using MondayApi.Workspaces;

namespace MondayApi {
    public interface IMondayApiClient {
        Task<Query> RunQuery(QueryQueryBuilder queryBuilder);
        Task<Mutation> RunMutation(MutationQueryBuilder queryBuilder);
        Task<Mutation> RunFileMutation(MutationQueryBuilder queryBuilder, System.IO.Stream file, string filename);

        Task<T> Run<T>(GraphQlQueryBuilder queryBuilder);
        Task<T> RunFileMutation<T>(GraphQlQueryBuilder queryBuilder, System.IO.Stream file, string filename);

        IAssetActions Assets { get; }
        IBoardActions Boards { get; }
        IColumnActions Columns { get; }
        IGroupActions Groups { get; }
        IItemActions Items { get; }
        ISubitemActions Subitems { get; }
        IUpdateActions Updates { get; }
        IUserActions Users { get; }
        IWorkspaceActions Workspaces { get; }
    }
}
