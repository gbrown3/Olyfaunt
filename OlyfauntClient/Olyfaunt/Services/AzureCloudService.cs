using System.Threading.Tasks;
using Microsoft.WindowsAzure.MobileServices;
using Olyfaunt.Abstractions;
using Xamarin.Forms;

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

        public Task LoginAsync()
        {
            var loginProvider = DependencyService.Get<ILoginProvider>();
            return loginProvider.LoginAsync(client);
        }

    }
}
