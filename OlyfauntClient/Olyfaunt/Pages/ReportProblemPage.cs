using System;
using System.IO;
using Xamarin.Forms;

namespace Olyfaunt
{
    public class ReportProblemPage : ContentPage
    {
        FeedPage feedPage;
        TabbedPage mainTabbedPage;

        public ReportProblemPage(FeedPage feedPage, TabbedPage mainTabbedPage)
        {
            this.feedPage = feedPage;
            this.mainTabbedPage = mainTabbedPage;

            Button pickPictureButton = new Button
            {
                Text = "Choose a picture",
                HorizontalOptions = LayoutOptions.CenterAndExpand,
                VerticalOptions = LayoutOptions.CenterAndExpand
            };

            pickPictureButton.Clicked += OnPickPictureButtonClicked;

            Content = new StackLayout {Children = { pickPictureButton }};
        }

        async void OnPickPictureButtonClicked(object sender, EventArgs e)
        {
            (sender as Button).IsEnabled = false;

            System.Diagnostics.Debug.WriteLine("About to get stream");
            Stream stream = await DependencyService.Get<IPicturePicker>().GetImageStreamAsync();
            System.Diagnostics.Debug.WriteLine("Finished getting stream");

            if (stream != null)
            {
                System.Diagnostics.Debug.WriteLine("Stream is not null");
                Image image = new Image
                {
                    Source = ImageSource.FromStream(() => stream),
                    BackgroundColor = Color.Gray
                };

                User placeholderUser = new User("john_smith.png");
                placeholderUser.Username = "John Smith";
                PostProblem(new Problem(placeholderUser, image));    // TODO: replace this with the current app user
            }

            (sender as Button).IsEnabled = true;
        }

        /// <summary>
        /// Post problem to community feed and go back to community feed
        /// </summary>
        /// <param name="problem">Problem.</param>
        private void PostProblem(Problem problem)
        {
            feedPage.AddUIElementToTop(new ProblemUIElement(problem));
            mainTabbedPage.CurrentPage = feedPage;
            GoBackToTabbedMainPage();
            //(this.Parent as TabbedPage).CurrentPage = feedPage;
            //(this as TabbedPage).CurrentPage = feedPage;
        }

        async void GoBackToTabbedMainPage()
        {
            await Navigation.PopToRootAsync();
        }
    }
}

