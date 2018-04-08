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
            Image image = user.profileImage;
            Label name = new Label()
            {
                Text = user.Username,
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(EntryCell)),
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.CenterAndExpand
            };

            Label NEEDS = new Label()
            {
                Text = "Needs:",
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(EntryCell)),
                VerticalOptions = LayoutOptions.CenterAndExpand
            }; Label WANTS = new Label()
            {
                Text = "Wants:",
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(EntryCell)),
                VerticalOptions = LayoutOptions.CenterAndExpand
            }; Label LIKES = new Label()
            {
                Text = "Likes:",
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(EntryCell)),
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