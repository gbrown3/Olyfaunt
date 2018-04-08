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

            FillWithSampleEvents();

            scroller = new ScrollView();
            scroller.Content = feedStack;

            Content = scroller;
        }

        private void FillWithSampleEvents()
        {
            feedStack.Children.Add(new EventUIElement(new Event(
                "Scrabble",
                "If you want a chill night, come play scrabble in library room 232.",
                "4/13/2018",
                "8:30 PM"
            )));
            feedStack.Children.Add(new EventUIElement( new Event(
                "Smash Tournament", 
                "Time to smash! Come down to the lounge to get your smash bros on!", 
                "4/14/2018", 
                "7:00 PM"
            )));
            feedStack.Children.Add(new EventUIElement(new Event(
                "Watch Mr. Robot",
                "I'm trying to catch up on Mr.Robot in the lounge, if anyone feels like joining I can make some popcorn",
                "4/21/2018",
                "10:00 PM"
            )));
            feedStack.Children.Add(new EventUIElement(new Event(
                "Cocoa and Cookies",
                "I'll be making hot cocoa and cookies, so please come by Room 456 if you want try some",
                "4/30/2018",
                "9:30 PM"
            )));
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

