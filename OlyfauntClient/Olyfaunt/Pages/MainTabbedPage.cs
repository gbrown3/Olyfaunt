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
            Title = "Community Feed";   // Initialize title to be Community Feed because that's the first page it'll be open to

            /*
            ItemTemplate = new DataTemplate(() =>
            {
                return new ContentPage();
            });

            ItemsSource = new ObservableCollection<ContentPage> { new FeedPage()};
            */
            Children.Add(new FeedPage());
            Children.Add(new SignInSignUpPage());
        }
    }
}
