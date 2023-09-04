using System.Threading.Tasks;
using MondayApi.Boards;
using MondayApi.Groups;
using MondayApi.Schema;
using MondayApi.Users;

namespace MondayApi {
    public interface IMondayApiClient {
        Task<Query> RunQuery(QueryQueryBuilder queryBuilder);

        IBoardActions Boards { get; }
        IGroupActions Groups { get; }
        IUserActions Users { get; }
    }
}
