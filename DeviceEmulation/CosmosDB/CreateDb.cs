using System;
using System.Threading.Tasks;
using DeviceEmulation.Shared;
using Microsoft.Azure.Documents;
using Microsoft.Azure.Documents.Client;

namespace DeviceEmulation.CosmosDB
{
    public class CreateDb : Resource
    {
        private Database _db;
        private DocumentClient _client;

        public async Task CreateDataBase()
        {
            using (_client = new DocumentClient(new Uri(CosmosDbConstants.ConnectionUrl), CosmosDbConstants.Key))
            {
                _db = await _client.CreateDatabaseIfNotExistsAsync(new Database {Id = "SomeDB"});

                await CreateCollection();
            }
        }

        private async Task CreateCollection()
        {
            await _client.CreateDocumentCollectionIfNotExistsAsync(_db.SelfLink,
                new DocumentCollection {Id = "SomeCollection"},
                new RequestOptions {OfferThroughput = 400});
        }
    }
}