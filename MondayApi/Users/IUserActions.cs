using System.Collections.Generic;
using System.Threading.Tasks;
using MondayApi.Schema;

namespace MondayApi.Users {
    public interface IUserActions {
        Task<IEnumerable<User>> GetAsync(int pageNumber, int numPerPage);
        //Task<User> GetOneAsync(int id);
    }
}
