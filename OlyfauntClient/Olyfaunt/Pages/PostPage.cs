using System;
using System.IO;
using Xamarin.Forms;

namespace Olyfaunt
{
    public class PostPage : ContentPage
    {
        public PostPage()
        {
            Title = "Post";
            Icon = "plus.png";

            StackLayout stack = new StackLayout();

            Button pickPictureButton = new Button
            {
                Text = "Choose a picture",
                HorizontalOptions = LayoutOptions.CenterAndExpand,
                VerticalOptions = LayoutOptions.CenterAndExpand
            };

            pickPictureButton.Clicked += async (sender, e) => 
            {
                pickPictureButton.IsEnabled = false;
                Stream stream = await DependencyService.Get<IPicturePicker>().GetImageStreamAsync();

                if (stream != null)
                {
                    Image image = new Image
                    {
                        Source = ImageSource.FromStream(() => stream),
                        BackgroundColor = Color.Gray
                    };

                    TapGestureRecognizer recognizer = new TapGestureRecognizer();
                    recognizer.Tapped += (sender2, args) =>
                    {
                        (this as ContentPage).Content = stack;
                        pickPictureButton.IsEnabled = true;
                    };
                    image.GestureRecognizers.Add(recognizer);

                    (this as ContentPage).Content = image;
                }
                else
                {
                    pickPictureButton.IsEnabled = true;
                }
            };


            stack.Children.Add(pickPictureButton);

            Content = stack;
        }
    }
}

