using System;
using System.IO;
using System.Threading.Tasks;
using Olyfaunt.Abstractions;
using Olyfaunt.Services;
using Olyfaunt.Helpers;
using System.Diagnostics;

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
        public static IAuthenticate Authenticator { get; private set; }

        public static void Init(IAuthenticate authenticator)
        {
            Authenticator = authenticator;
        }

        public App()
        {
            ServiceLocator.Instance.Add<ICloudService, AzureCloudService>();
            MainPage = new NavigationPage (new SignInSignUpPage());
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
