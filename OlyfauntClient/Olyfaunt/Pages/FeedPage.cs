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
            Icon = "house.png";
            //BackgroundColor = Color.Black;

            feedStack = new StackLayout();
            Padding = new Thickness(5, 5);

            for (int i = 0; i < 40; i++) {
                feedStack.Children.Add(new EventUIElement(new Event("Event" + i, "Sick event bro", "April 20", "4:20 pm" )));
            }

            scroller = new ScrollView();
            scroller.Content = feedStack;

            Content = scroller;
        }

        /// <summary>
        /// Add a new event or problem to the top of the feed
        /// </summary>
        /// <param name="UIElement">UIE lement.</param>
        public void AddUIElementToTop(Layout UIElement)       // TODO: figure out if we should be more specific. I think most UI elements will be a collection of elements, so a Layout works
        {
            feedStack.Children.Add(UIElement);
            feedStack.LowerChild(UIElement);
        }
    }
}

