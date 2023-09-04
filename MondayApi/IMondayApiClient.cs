using System.Threading.Tasks;
using MondayApi.Schema;

namespace MondayApi {
    public interface IMondayApiClient {
        Task<Query> RunQuery(QueryQueryBuilder queryBuilder);
    }
}
