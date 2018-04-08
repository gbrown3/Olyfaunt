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
            StackLayout newFeedStack = new StackLayout();
            newFeedStack.Children.Add(UIElement);

            foreach (View child in feedStack.Children)
            {
                newFeedStack.Children.Add(CopyOfChild(child));
            }

            feedStack = newFeedStack;
        }

        /// <summary>
        /// Make sure we're passing child by value and not reference?
        /// </summary>
        /// <returns>The of child.</returns>
        /// <param name="child">Child.</param>
        public View CopyOfChild(View child)
        {
            return child;
        }
    }
}

