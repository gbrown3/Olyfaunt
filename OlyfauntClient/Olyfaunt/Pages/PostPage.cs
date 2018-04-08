using System;
using System.IO;
using Xamarin.Forms;

namespace Olyfaunt
{
    public class PostPage : ContentPage
    {
        private FeedPage feedPage;

        public PostPage(FeedPage feedPage)
        {
            this.feedPage = feedPage;

            Title = "Post";
            Icon = "plus.png";

            StackLayout stack = new StackLayout();

            Button makeAnEventButton = new Button
            {
                Text = "MAKE AN EVENT",
                TextColor = Color.White,
                BackgroundColor = Color.Blue,
                HorizontalOptions = LayoutOptions.FillAndExpand,
                VerticalOptions = LayoutOptions.EndAndExpand
            };
            Button reportAProblemButton = new Button
            {
                Text = "REPORT A PROBLEM",
                TextColor = Color.White,
                BackgroundColor = Color.Red,
                HorizontalOptions = LayoutOptions.FillAndExpand,
                VerticalOptions = LayoutOptions.End
            };

            makeAnEventButton.Clicked += delegate { GoToMakeEventPage(); };
            reportAProblemButton.Clicked += delegate { GoToReportProblemPage(); };

            stack.Children.Add(makeAnEventButton);
            stack.Children.Add(reportAProblemButton);

            Content = stack;
        }

        async void GoToReportProblemPage()
        {
            await Navigation.PushAsync(new ReportProblemPage(feedPage, (this.Parent as TabbedPage)));
        }

        async void GoToMakeEventPage()
        {
            await Navigation.PushAsync(new MakeEventPage(feedPage));
        }
    }
}

