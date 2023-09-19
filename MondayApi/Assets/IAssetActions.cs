using System.Collections.Generic;
using System.Threading.Tasks;
using MondayApi.Schema;

namespace MondayApi.Assets {
    public interface IAssetActions {
        Task<IEnumerable<Asset>> GetByItemAsync(string itemID);
        Task<IEnumerable<Update>> GetByItemUpdatesAsync(string itemID);
        Task<Asset> GetOneAsync(string id);
    }
}
