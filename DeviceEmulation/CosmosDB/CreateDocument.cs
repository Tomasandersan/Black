using System;
using System.Threading.Tasks;
using DeviceEmulation.Models;
using DeviceEmulation.Shared;
using Microsoft.Azure.Documents.Client;

namespace DeviceEmulation.CosmosDB
{
   public static class CreateDocument
    {
        public static async Task CreateCosmosDbDocument(CosmosDbMessage mess)
        {
            var client = new DocumentClient(new Uri(CosmosDbConstants.ConnectionUrl), CosmosDbConstants.Key);
            await client.CreateDocumentAsync(UriFactory.CreateDocumentCollectionUri("SomeDB", "SomeCollection"), mess);
        }
    }
}
