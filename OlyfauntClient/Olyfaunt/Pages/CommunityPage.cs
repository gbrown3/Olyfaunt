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

            for (int i = 0; i < 40; i++)
            {
                User exampleUser = new User();
                exampleUser.Username = "User # " + i;
                stack.Children.Add(new UserUIElement(exampleUser));
            }

            scroller.Content = stack;
            Content = scroller;
        }
    }
}
