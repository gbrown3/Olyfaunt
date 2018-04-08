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

            Button pickPictureButton = new Button
            {
                Text = "Choose a picture",
                HorizontalOptions = LayoutOptions.CenterAndExpand,
                VerticalOptions = LayoutOptions.CenterAndExpand
            };

            pickPictureButton.Clicked += OnPickPictureButtonClicked;


            stack.Children.Add(pickPictureButton);

            Content = stack;
        }




        async void OnPickPictureButtonClicked (object sender, EventArgs e)
        {
            (sender as Button).IsEnabled = false;

            Stream stream = await DependencyService.Get<IPicturePicker>().GetImageStreamAsync();
            if (stream != null)
            {
                Image image = new Image
                {
                    Source = ImageSource.FromStream(() => stream),
                    BackgroundColor = Color.Gray
                };

                PostProblem(new Problem(image));
            }
            else
            {
                (sender as Button).IsEnabled = true;
            }
        }

        /// <summary>
        /// Post problem to community feed
        /// </summary>
        /// <param name="problem">Problem.</param>
        private void PostProblem(Problem problem)
        {
            feedPage.AddUIElementToTop(new ProblemUIElement(problem));
        }
    }
}

