using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MondayApi.Schema;

//https://developer.monday.com/api-reference/reference/assets-1
namespace MondayApi.Assets {
    public class AssetActions : IAssetActions {
        private readonly IMondayApiClient client;
        public AssetActions(IMondayApiClient client) {
            this.client = client;
        }

        public async Task<IEnumerable<IEnumerable<IFileValueItem>>> GetItemFiles(string itemID, string[] columnIDs = null) {
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
                    ids: columnIDs,
                    types: new ColumnType?[] { ColumnType.File }
                ),
                ids: new string[] { itemID }
            );
            var response = await client.RunQuery(query);
            return response.Items?.FirstOrDefault()?.ColumnValues?.OfType<FileValue>()?.Select(fv => fv.Files);
        }

        public async Task<IEnumerable<Asset>> GetByItem(string itemID) {
            var query = new QueryQueryBuilder().WithItems(
                new ItemQueryBuilder().WithAssets(
                    new AssetQueryBuilder().WithAllScalarFields()
                ),
                ids: new string[] { itemID }
            );
            var response = await client.RunQuery(query);
            return response.Items?.FirstOrDefault()?.Assets;
        }

        public async Task<IEnumerable<Update>> GetByItemUpdates(string itemID) {
            var query = new QueryQueryBuilder().WithItems(
                new ItemQueryBuilder().WithUpdates(
                    new UpdateQueryBuilder().WithID().WithAssets(
                        new AssetQueryBuilder().WithAllScalarFields()
                    )
                ),
                ids: new string[] { itemID }
            );
            var response = await client.RunQuery(query);
            return response.Items?.FirstOrDefault()?.Updates;
        }

        public async Task<Asset> GetOne(string id) {
            var query = new QueryQueryBuilder().WithAssets(
                new AssetQueryBuilder().WithAllScalarFields(),
                ids: new string[] { id }
            );
            var response = await client.RunQuery(query);
            return response.Assets?.FirstOrDefault();
        }

        public async Task<Asset> UploadFileToUpdate(string updateID, System.IO.Stream file, string filename) {
            var fileParam = new GraphQlQueryParameter<object>("file", "File!");

            var mutation = new MutationQueryBuilder().WithAddFileToUpdate(
                new AssetQueryBuilder().WithAllScalarFields(),
                updateID: updateID,
                file: fileParam
            ).WithParameter(fileParam);
            var response = await client.RunFileMutation(mutation, file, filename);
            return response.AddFileToUpdate;
        }

        public async Task<Asset> UploadFileToItem(string itemID, string columnID, System.IO.Stream file, string filename) {
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

        // https://developer.monday.com/api-reference/reference/files-1#clear-the-files-column
        public async Task<Item> ClearItemFilesColumn(string boardID, string itemID, string columnID) {
            var mutation = new MutationQueryBuilder().WithChangeColumnValue(
                new ItemQueryBuilder().WithAllScalarFields().WithColumnValues(
                    new ColumnValueQueryBuilder().WithAllScalarFields(),
                    ids: new string[] { columnID }
                ),
                boardID: boardID,
                itemID: itemID,
                columnID: columnID,
                value: "{\"clear_all\": true}"
            );
            var response = await client.RunMutation(mutation);
            return response.ChangeColumnValue;
        }
    }
}
