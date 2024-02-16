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

        public async Task<IEnumerable<IEnumerable<IFileValueItem>>> GetItemFilesAsync(string itemID, string columnID = null) {
            var query = new QueryQueryBuilder().WithItems(
                new ItemQueryBuilder().WithColumnValues(
                    new ColumnValueQueryBuilder().WithAllScalarFields().WithFileValueFragment(
                        new FileValueQueryBuilder().WithFiles(
                            new FileValueItemQueryBuilder().WithAllScalarFields() // ExceptCreatedAt to work around bug in current version of API - returns values like `55686-09-26T02:33:47+00:00`
                                .WithFileAssetValueFragment(new FileAssetValueQueryBuilder().WithAllScalarFields().ExceptCreatedAt().WithAsset(new AssetQueryBuilder().WithAllScalarFields()))
                                .WithFileDocValueFragment(new FileDocValueQueryBuilder().WithAllScalarFields().ExceptCreatedAt().WithDoc(new DocumentQueryBuilder().WithAllScalarFields()))
                                .WithFileLinkValueFragment(new FileLinkValueQueryBuilder().WithAllScalarFields().ExceptCreatedAt())
                        )
                    ),
                    ids: Utils.GetParameterToMulti(columnID),
                    types: Utils.GetParameterWithNameToMulti(ColumnType.File)
                ),
                ids: Utils.GetParameterToMulti(itemID)
            );
            var response = await client.RunQuery(query);
            return response.Items?.FirstOrDefault()?.ColumnValues?.OfType<FileValue>()?.Select(fv => fv.Files);
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

        public async Task<Asset> UploadFileToUpdateAsync(string updateID, System.IO.Stream file, string filename) {
            var fileParam = new GraphQlQueryParameter<object>("file", "File!");

            var mutation = new MutationQueryBuilder().WithAddFileToUpdate(
                new AssetQueryBuilder().WithAllScalarFields(),
                updateID: updateID,
                file: fileParam
            ).WithParameter(fileParam);
            var response = await client.RunFileMutation(mutation, file, filename);
            return response.AddFileToUpdate;
        }

        public async Task<Asset> UploadFileToItemAsync(string itemID, string columnID, System.IO.Stream file, string filename) {
            var fileParam = new GraphQlQueryParameter<object>("file", "File!");

            var mutation = new MutationQueryBuilder().WithAddFileToColumn(
                new AssetQueryBuilder().WithAllScalarFields(),
                itemID: itemID,
                columnID: columnID,
                file: fileParam
            ).WithParameter(fileParam);
            var response = await client.RunFileMutation(mutation, file, filename);
            return response.AddFileToColumn;
        }
    }
}
