using System.Threading.Tasks;
using MondayApi.Boards;
using MondayApi.Columns;
using MondayApi.Groups;
using MondayApi.Items;
using MondayApi.Schema;
using MondayApi.Subitems;
using MondayApi.Users;

namespace MondayApi {
    public interface IMondayApiClient {
        Task<Query> RunQuery(QueryQueryBuilder queryBuilder);
        Task<Mutation> RunMutation(MutationQueryBuilder queryBuilder);

        IBoardActions Boards { get; }
        IColumnActions Columns { get; }
        IGroupActions Groups { get; }
        IItemActions Items { get; }
        ISubitemActions Subitems { get; }
        IUserActions Users { get; }
    }
}
