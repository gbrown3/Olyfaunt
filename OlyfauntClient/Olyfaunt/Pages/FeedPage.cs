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
            Title = "Community Feed";


            feedStack = new StackLayout();
            Padding = new Thickness(0, 5);

            for (int i = 0; i < 40; i++) {
                feedStack.Children.Add(new EventUIElement(new Event("Event" + i, "Sick event bro", "April 20", "4:20 pm" )));
            }

            scroller = new ScrollView();
            scroller.Content = feedStack;

            Content = scroller;
        }
    }
}

