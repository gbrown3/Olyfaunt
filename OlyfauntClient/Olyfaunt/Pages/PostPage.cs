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
                System.Diagnostics.Debug.WriteLine("Button was clicked");
                pickPictureButton.IsEnabled = false;

                System.Diagnostics.Debug.WriteLine("About to run IPicturePicker stream");
                Stream stream = await DependencyService.Get<IPicturePicker>().GetImageStreamAsync();
                System.Diagnostics.Debug.WriteLine("Finished running IPicturePickerStream");

                if (stream != null)
                {
                    System.Diagnostics.Debug.WriteLine("Image Stream wasn't null!");

                    Image image = new Image
                    {
                        Source = ImageSource.FromStream(() => stream),
                        BackgroundColor = Color.Gray
                    };

                    /*
                    TapGestureRecognizer recognizer = new TapGestureRecognizer();
                    recognizer.Tapped += (sender2, args) =>
                    {
                        (this as ContentPage).Content = stack;
                        pickPictureButton.IsEnabled = true;
                    };
                    image.GestureRecognizers.Add(recognizer);


                    (this as ContentPage).Content = image;
                    */
                    stack.Children.Add(image);
                }
                else
                {
                    System.Diagnostics.Debug.WriteLine("Image Stream was null!");
                    pickPictureButton.IsEnabled = true;
                }
            };


            stack.Children.Add(pickPictureButton);

            Content = stack;
        }
    }
}

