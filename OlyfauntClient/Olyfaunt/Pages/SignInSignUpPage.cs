using System;

using Xamarin.Forms;

namespace Olyfaunt
{
    public class SignInSignUpPage : ContentPage
    {
        public SignInSignUpPage()
        {
            Content = new StackLayout
            {
                Children = {
                    new Label { Text = "Hello ContentPage" }
                }
            };
        }
    }
}

