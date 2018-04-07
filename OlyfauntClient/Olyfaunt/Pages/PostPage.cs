using System;

using Xamarin.Forms;

namespace Olyfaunt
{
    public class PostPage : ContentPage
    {
        public PostPage()
        {
            Title = "Post";

            this.Icon = "plus.png";

            Content = new StackLayout
            {
                Children = {
                    new Label { Text = "This is the post page!" }
                }
            };
        }
    }
}

