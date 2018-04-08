using System;
using System.IO;
using System.Threading.Tasks;
using Olyfaunt.Abstractions;
using Olyfaunt.Services;
using Xamarin.Forms;

namespace Olyfaunt
{
    public interface IAuthenticate
    {
        Task<bool> Authenticate();
    }
    public interface IPicturePicker
    {
        Task<Stream> GetImageStreamAsync();      // May need to change the type of stream
    }

    public class App : Application
    {
        public static ICloudService CloudService { get; set; }

        //public static User currentUser = new User();   // TODO: replace this and everything that uses it with database calls

        public App()
        {
            CloudService = new AzureCloudService();
            MainPage = new NavigationPage (new MainTabbedPage());
        }

        public static IAuthenticate Authenticator { get; private set; }

        public static void Init(IAuthenticate authenticator)
        {
            Authenticator = authenticator;
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
