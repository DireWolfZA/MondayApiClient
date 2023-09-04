using System.Threading.Tasks;
using MondayApi.Boards;
using MondayApi.Schema;
using MondayApi.Users;

namespace MondayApi {
    public interface IMondayApiClient {
        Task<Query> RunQuery(QueryQueryBuilder queryBuilder);

        IBoardActions Boards { get; }
        IUserActions Users { get; }
    }
}
