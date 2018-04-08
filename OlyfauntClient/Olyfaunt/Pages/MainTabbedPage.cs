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
            Title = "Community Feed";

            FeedPage feedPage = new FeedPage();
            Children.Add(feedPage);
            Children.Add(new PostPage(feedPage));
            Children.Add(new CommunityPage());

        }

		protected override void OnCurrentPageChanged()
		{
            base.OnCurrentPageChanged();
            Title = CurrentPage.Title;
		}

	}
}
