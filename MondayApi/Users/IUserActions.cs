using System.Collections.Generic;
using System.Threading.Tasks;
using MondayApi.Schema;

namespace MondayApi.Users {
    public interface IUserActions {
        Task<IEnumerable<User>> Get(int? pageNumber = null, int? numPerPage = null);
        Task<User?> GetOne(string id);
    }
}
