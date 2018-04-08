using System.Threading.Tasks;
using Microsoft.WindowsAzure.MobileServices;
using Newtonsoft.Json.Linq;
using Olyfaunt.Abstractions;
using Olyfaunt.iOS.Services;
using UIKit;

[assembly: Xamarin.Forms.Dependency(typeof(iOSLoginProvider))]
namespace Olyfaunt.iOS.Services
{
    public class iOSLoginProvider : ILoginProvider
    {
        public async Task LoginAsync(MobileServiceClient client)
        {
            await client.LoginAsync(RootView, MobileServiceAuthenticationProvider.Google, "olyfaunt");
        }
        public UIViewController RootView => UIApplication.SharedApplication.KeyWindow.RootViewController;
    }
}