using System;
using System.IO;
using System.Collections.Generic;
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
        public static List<User> Database { get; private set; }

        public static IAuthenticate Authenticator { get; private set; }

        public static void Init(IAuthenticate authenticator)
        {
            Authenticator = authenticator;
        }

        public App()
        {
            ServiceLocator.Instance.Add<ICloudService, AzureCloudService>();
            Database = new List<User>();
            SeedDatabase();
            MainPage = new NavigationPage(new MainTabbedPage());
            //MainPage = new NavigationPage (new SignInSignUpPage());
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

        void SeedDatabase()
        {
            User user1 = new User("lit-mike.jpg");
            user1.Username = "LitMike17";
            user1.Bio = "I like to party";
            user1.Id = user1.GetHashCode().ToString();
            user1.AddNeed("Quiet after 2am");
            user1.AddWant("Hallway needs to not smell like feet");
            user1.AddLike("Join my pickup soccer league!");

            Database.Add(user1);

            User user2 = new User("chill-kelly.jpg");
            user2.Username = "ChillKelly007";
            user2.Bio = "I like to chill";
            user2.Id = user1.GetHashCode().ToString();
            user2.AddNeed("Clean kitchen");
            user2.AddWant("Shared meals");
            user2.AddLike("Gardening!");

            Database.Add(user2);

            User user3 = new User("simple-doug.jpg");
            user3.Username = "SimpleDoug441";
            user3.Bio = "I like to be simple";
            user3.Id = user1.GetHashCode().ToString();
            user3.AddNeed("Alone time");
            user3.AddWant("Tidy communal space");
            user3.AddLike("Long walks to the river");

            Database.Add(user3);

            User user4 = new User("crazy-jane.jpg");
            user4.Username = "CrazyJane999";
            user4.Bio = "I LOVE to party";
            user4.Id = user1.GetHashCode().ToString();
            user4.AddNeed("No hair in showers");
            user4.AddWant("Parties every Friday/Saturday");
            user4.AddLike("Themed progressives");

            Database.Add(user4);

        }
    }
}
