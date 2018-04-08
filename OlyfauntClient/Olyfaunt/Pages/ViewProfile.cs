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
            Image image = new Image { Source = user.picpath };
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

            Label needsTitle = new Label()
            {
                Text = "Needs: ",
                FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(EntryCell)),
                VerticalOptions = LayoutOptions.CenterAndExpand
            };
            Label NEEDS = new Label()
            {
                Text = needs,
                FontSize = Device.GetNamedSize(NamedSize.Small, typeof(EntryCell)),
                VerticalOptions = LayoutOptions.CenterAndExpand
            };
            StackLayout needStack = new StackLayout 
            { 
                Orientation = StackOrientation.Horizontal, 
                Children = { needsTitle, NEEDS},
                VerticalOptions = LayoutOptions.CenterAndExpand
            };


            Label wantTitle = new Label()
            {
                Text = "Wants: ",
                FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(EntryCell)),
                VerticalOptions = LayoutOptions.CenterAndExpand
            }; 
            Label WANTS = new Label()
            {
                Text = wants,
                FontSize = Device.GetNamedSize(NamedSize.Small, typeof(EntryCell)),
                VerticalOptions = LayoutOptions.CenterAndExpand
            }; 
            StackLayout wantStack = new StackLayout 
            { 
                Orientation = StackOrientation.Horizontal, 
                Children = { wantTitle, WANTS },
                VerticalOptions = LayoutOptions.CenterAndExpand 
            };


            Label likesTitle = new Label()
            {
                Text = "Likes: ",
                FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(EntryCell)),
                VerticalOptions = LayoutOptions.CenterAndExpand
            };

            Label LIKES = new Label()
            {
                Text = likes,
                FontSize = Device.GetNamedSize(NamedSize.Small, typeof(EntryCell)),
                VerticalOptions = LayoutOptions.CenterAndExpand
            };
            StackLayout likeStack = new StackLayout 
            { 
                Orientation = StackOrientation.Horizontal, 
                Children = { likesTitle, LIKES },
                VerticalOptions = LayoutOptions.CenterAndExpand 
            };



            stack = new StackLayout();
            var grid = new Grid();
            grid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });
            grid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(2, GridUnitType.Star) });
            grid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });
            grid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(3, GridUnitType.Star) });

            grid.Children.Add(image, 0, 0);
            grid.Children.Add(name, 0, 1);

            stack.Children.Add(needStack);
            stack.Children.Add(wantStack);
            stack.Children.Add(likeStack);

            grid.Children.Add(stack, 0, 2);

            
            Content = grid;
		}

		protected override bool OnBackButtonPressed()
		{
            //(this.Parent as CommunityPage)
            return base.OnBackButtonPressed();
		}
	}
}