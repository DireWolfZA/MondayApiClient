using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MondayApi.Schema;

//https://developer.monday.com/api-reference/docs/subitems
namespace MondayApi.Subitems {
    public class SubitemActions : ISubitemActions {
        private readonly IMondayApiClient client;
        public SubitemActions(IMondayApiClient client) {
            this.client = client;
        }

        public async Task<IEnumerable<Item>> GetAsync(string parentItemID) {
            var itemIDs = new GraphQlQueryParameter<IEnumerable<string>>(null, defaultValue: new string[] { parentItemID });

            var query = new QueryQueryBuilder().WithItems(new ItemQueryBuilder().WithSubitems(new ItemQueryBuilder().WithAllScalarFields()), ids: itemIDs);
            var response = await client.RunQuery(query);
            return response.Items?.FirstOrDefault().Subitems;
        }
    }
}
