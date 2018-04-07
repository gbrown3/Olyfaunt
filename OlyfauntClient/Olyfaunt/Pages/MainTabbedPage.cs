using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Xamarin.Forms;
namespace Olyfaunt
{
    /// <summary>
    /// Wrapper for all the other pages-- this way we'll have a consistent navigation bar at the bottom
    /// </summary>
    public class MainTabbedPage : TabbedPage
    {
        public MainTabbedPage()
        {
            NavigationPage.SetHasNavigationBar(this, true);
            //Title = ""; 

            Children.Add(new FeedPage());
            Children.Add(new PostPage());

        }

		protected override void OnCurrentPageChanged()
		{
            base.OnCurrentPageChanged();
            Title = CurrentPage.Title;
		}

	}
}
