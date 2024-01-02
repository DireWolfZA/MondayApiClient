using System.Collections.Generic;
using System.Threading.Tasks;
using MondayApi.Schema;

namespace MondayApi.Users {
    public interface IUserActions {
        Task<IEnumerable<User>> GetAsync(int? pageNumber = null, int? numPerPage = null);
        Task<User> GetOneAsync(string id);
    }
}
