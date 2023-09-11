using System.Collections.Generic;
using System.Threading.Tasks;
using MondayApi.Schema;

namespace MondayApi.Subitems {
    public interface ISubitemActions {
        Task<IEnumerable<Item>> GetAsync(string parentItemID, bool withColumnValues = false, IEnumerable<string> columnIDs = null);
    }
}
