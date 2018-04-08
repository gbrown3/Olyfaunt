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
            Icon = "community_members.png";

            stack = new StackLayout();
            scroller = new ScrollView();

            Padding = new Thickness(5, 5);

            foreach (User user in App.Database)
            {
                stack.Children.Add(new UserUIElement(user));
            }

            scroller.Content = stack;
            Content = scroller;
        }

        public void resetStack()
        {
            resetStack();
            foreach (User user in App.Database)
            {
                stack.Children.Add(new UserUIElement(user));
            }
            scroller.Content = stack;
            Content = scroller;
        }
    }
}
