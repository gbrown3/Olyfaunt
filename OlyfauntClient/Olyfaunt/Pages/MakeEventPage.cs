using System;

using Xamarin.Forms;

namespace Olyfaunt
{
    public class MakeEventPage : ContentPage
    {
        FeedPage feedPage;

        public MakeEventPage(FeedPage feedPage)
        {
            this.feedPage = feedPage;

            Content = new StackLayout
            {
                Children = {
                    new Label { Text = "Hello ContentPage" }
                }
            };
        }
    }
}

