using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace Olyfaunt
{
	public class ViewProfile : ContentPage
	{
        User user;
        StackLayout stack;

		public ViewProfile (User user)
		{
            this.user = user;
            //NavigationPage.SetHasNavigationBar(this, true);
            NavigationPage.SetHasBackButton(this, true);
            Image image = user.profileImage;
            string wants = "";
            foreach (string text in user.Wants)
            {
                wants += (text + " ");
            }

            string needs = "";
            foreach (string text in user.Needs)
            {
                needs += (text + " ");
            }

            string likes = "";
            foreach (string text in user.Likes)
            {
                likes += (text + " ");
            }

            Label name = new Label()
            {
                Text = user.Username,
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(EntryCell)),
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.CenterAndExpand
            };

            Label NEEDS = new Label()
            {
                Text = "Needs: " + needs,
                FontSize = Device.GetNamedSize(NamedSize.Small, typeof(EntryCell)),
                VerticalOptions = LayoutOptions.CenterAndExpand
            }; Label WANTS = new Label()
            {
                Text = "Wants: " + wants,
                FontSize = Device.GetNamedSize(NamedSize.Small, typeof(EntryCell)),
                VerticalOptions = LayoutOptions.CenterAndExpand
            }; Label LIKES = new Label()
            {
                Text = "Likes: " + likes,
                FontSize = Device.GetNamedSize(NamedSize.Small, typeof(EntryCell)),
                VerticalOptions = LayoutOptions.CenterAndExpand
            };



            stack = new StackLayout();
            var grid = new Grid();
            grid.Children.Add(image, 0, 0);
            grid.Children.Add(name, 0, 2);
            grid.Children.Add(NEEDS, 0, 4);
            grid.Children.Add(WANTS, 0, 6);
            grid.Children.Add(LIKES, 0, 8);

            

            stack.Children.Add(grid);

            
            Content = stack;
		}
	}
}