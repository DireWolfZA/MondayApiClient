using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MondayApi.Schema;

//https://developer.monday.com/api-reference/docs/files
namespace MondayApi.Assets {
    public class AssetActions : IAssetActions {
        private readonly IMondayApiClient client;
        public AssetActions(IMondayApiClient client) {
            this.client = client;
        }

        public async Task<IEnumerable<Asset>> GetByItemAsync(string itemID) {
            var query = new QueryQueryBuilder().WithItems(
                new ItemQueryBuilder().WithAssets(
                    new AssetQueryBuilder().WithAllScalarFields()
                ),
                ids: Utils.GetParameterToMulti(itemID)
            );
            var response = await client.RunQuery(query);
            return response.Items?.FirstOrDefault()?.Assets;
        }

        public async Task<IEnumerable<Update>> GetByItemUpdatesAsync(string itemID) {
            var query = new QueryQueryBuilder().WithItems(
                new ItemQueryBuilder().WithUpdates(
                    new UpdateQueryBuilder().WithID().WithAssets(
                        new AssetQueryBuilder().WithAllScalarFields()
                    )
                ),
                ids: Utils.GetParameterToMulti(itemID)
            );
            var response = await client.RunQuery(query);
            return response.Items?.FirstOrDefault()?.Updates;
        }

        public async Task<Asset> GetOneAsync(string id) {
            var query = new QueryQueryBuilder().WithAssets(
                new AssetQueryBuilder().WithAllScalarFields(),
                ids: Utils.GetParameterToMulti(id)
            );
            var response = await client.RunQuery(query);
            return response.Assets?.FirstOrDefault();
        }
    }
}
