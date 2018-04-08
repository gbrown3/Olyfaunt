using System;
using Xamarin.Forms;

namespace Olyfaunt
{
    public class CommunityPage : ContentPage
    {

        StackLayout stack;
        ScrollView scroller;

        public CommunityPage()
        {
            Title = "My Community";

            stack = new StackLayout();
            scroller = new ScrollView();

            Padding = new Thickness(5, 5);

            for (int i = 0; i < 40; i++)
            {
                stack.Children.Add(new EventUIElement(new Event("Event" + i, "Sick event bro", "April 20", "4:20 pm")));
            }

            scroller.Content = stack;
            Content = scroller;
        }
    }
}
