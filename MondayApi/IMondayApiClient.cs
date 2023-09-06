using System.Threading.Tasks;
using MondayApi.Boards;
using MondayApi.Groups;
using MondayApi.Items;
using MondayApi.Schema;
using MondayApi.Users;

namespace MondayApi {
    public interface IMondayApiClient {
        Task<Query> RunQuery(QueryQueryBuilder queryBuilder);

        IBoardActions Boards { get; }
        IGroupActions Groups { get; }
        IItemActions Items { get; }
        IUserActions Users { get; }
    }
}
