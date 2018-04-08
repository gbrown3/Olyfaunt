using System;

using Xamarin.Forms;

namespace Olyfaunt
{
    public class SignInSignUpPage : ContentPage
    {
        bool authenticated = false;
        Button loginButton;

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

            loginButton = new Button
            {
                Text = "Log in"
            };


            loginButton.Clicked += async (sender, e) =>
            {
                if (App.Authenticator != null)
                {
                    authenticated = await App.Authenticator.Authenticate();
                }
                if (authenticated == true)
                {
                    await Navigation.PushModalAsync(new MainTabbedPage());
                }
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

        protected override async void OnAppearing()
        {
            base.OnAppearing();

            // Go straight to home page if already logged in
            if(authenticated == true)
            {
                await Navigation.PushModalAsync(new MainTabbedPage());

                // Hide the sign-in button
                this.loginButton.IsVisible = false;
            }
        }
    }
}

