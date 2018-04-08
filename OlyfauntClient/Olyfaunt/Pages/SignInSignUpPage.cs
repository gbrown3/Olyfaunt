using System;

using Xamarin.Forms;

namespace Olyfaunt
{
    public class SignInSignUpPage : ContentPage
    {
        public SignInSignUpPage()
        {
            NavigationPage.SetHasNavigationBar(this, false);

            Label title = new Label
            {
                Text = "Welcome to OLYFAUNT",
                FontSize = Device.GetNamedSize (NamedSize.Large, typeof(EntryCell)),
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.CenterAndExpand
            };

            var userName = new Entry
            {
                Placeholder = "Username"
            };

            var password = new Entry
            {
                Placeholder = "Password",
                IsPassword = true 
            };

            var loginButton = new Button
            {
                Text = "Log in"
            };

            loginButton.Clicked += (sender, e) =>
            {
                // TODO: verify and then accept/reject
                Navigation.PushModalAsync(new NavigationPage(new MainTabbedPage()));
            };

            Content = new StackLayout
            {
                Children =
                {
                    title,
                    userName,
                    password,
                    loginButton

                }
            };
        }
    }
}

