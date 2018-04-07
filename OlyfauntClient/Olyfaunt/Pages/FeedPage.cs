using System;

using Xamarin.Forms;

namespace Olyfaunt
{
    public class FeedPage : ContentPage
    {

        ScrollView scroller;
        StackLayout feedStack;


        public FeedPage()
        {
            feedStack = new StackLayout();

            for (int i = 0; i < 40; i++) {
                feedStack.Children.Add(new Label { Text = "Label #" + i });
            }

            scroller = new ScrollView();
            scroller.Content = feedStack;

            Content = scroller;
        }
    }
}

