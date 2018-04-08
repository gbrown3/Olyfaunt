using System.Threading.Tasks;
using Android.Content;
using Newtonsoft.Json.Linq;
using Microsoft.WindowsAzure.MobileServices;
using Olyfaunt.Abstractions;
using Olyfaunt.Droid.Services;

[assembly: Xamarin.Forms.Dependency(typeof(DroidLoginProvider))]
namespace Olyfaunt.Droid.Services
{
    public class DroidLoginProvider : ILoginProvider
    {
        Context context;

        public void Init(Context context)
        {
            this.context = context;
        }

        public async Task LoginAsync(MobileServiceClient client)
        {
            await client.LoginAsync(context, MobileServiceAuthenticationProvider.Google, "olyfaunt");
        }
    }
}