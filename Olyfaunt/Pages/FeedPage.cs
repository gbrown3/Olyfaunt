using System;

using Xamarin.Forms;

namespace Olyfaunt.Pages
{
    public class FeedPage : ContentPage
    {

        ScrollView scroller;
        StackLayout feedStack;


        public FeedPage()
        {
            feedStack = new StackLayout();
            scroller = new ScrollView();

            for (int i = 0; i < 20; i++) {
                feedStack.Children.Add(new Label { Text = "Label #" + i });
            }

            Content = scroller;
        }
    }
}

