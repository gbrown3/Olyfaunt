using Microsoft.WindowsAzure.MobileServices;
using Olyfaunt.Abstractions;

namespace Olyfaunt.Services
{
    class AzureCloudService : ICloudService
    {
        MobileServiceClient client;

        public AzureCloudService()
        {
            client = new MobileServiceClient("https://olyfaunt.azurewebsites.net");
        }

        public ICloudTable<T> GetTable<T>() where T : TableData
        {
            return new AzureCloudTable<T>(client);
        }

    }
}
