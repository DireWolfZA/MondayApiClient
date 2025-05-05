using System.Collections.Generic;
using System.Threading.Tasks;
using MondayApi.Schema;

namespace MondayApi.Assets {
    public interface IAssetActions {
        Task<IEnumerable<IEnumerable<IFileValueItem>>?> GetItemFiles(string itemID, string[]? columnID = null);
        Task<IEnumerable<Asset>?> GetByItem(string itemID);
        Task<IEnumerable<Update>?> GetByItemUpdates(string itemID);
        Task<Asset?> GetOne(string id);
        Task<Asset> UploadFileToUpdate(string updateID, System.IO.Stream file, string filename);
        Task<Asset> UploadFileToItem(string itemID, string columnID, System.IO.Stream file, string filename);
        Task<Item> ClearItemFilesColumn(string boardID, string itemID, string columnID);
    }
}
