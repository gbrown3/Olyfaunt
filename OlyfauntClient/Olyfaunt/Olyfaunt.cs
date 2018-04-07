using System;

using Xamarin.Forms;

namespace Olyfaunt
{
    public class App : Application
    {
        public App()
        {
            // The root page of your application

            //var signInSignUp;

            MainPage = new SignInSignUpPage();
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
