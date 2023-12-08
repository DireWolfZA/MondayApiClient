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
        Task<T> RunQuery<T>(QueryQueryBuilder queryBuilder);
        Task<Query> RunQuery(QueryQueryBuilder queryBuilder);

        Task<T> RunMutation<T>(MutationQueryBuilder queryBuilder);
        Task<Mutation> RunMutation(MutationQueryBuilder queryBuilder);

        Task<T> RunFileMutation<T>(MutationQueryBuilder queryBuilder, System.IO.Stream file, string filename);
        Task<Mutation> RunFileMutation(MutationQueryBuilder queryBuilder, System.IO.Stream file, string filename);

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
