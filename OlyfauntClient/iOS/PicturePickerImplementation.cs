using System;
using System.IO;
using Foundation;
using UIKit;
using System.Threading.Tasks;
using Xamarin.Forms;

[assembly: Dependency (typeof (Olyfaunt.iOS.PicturePickerImplementation))]

namespace Olyfaunt.iOS
{
    /// <summary>
    /// Implementation to pick pictures in iOS
    /// </summary>
    public class PicturePickerImplementation : IPicturePicker
    {
        TaskCompletionSource<Stream> taskCompletionSource;
        UIImagePickerController imagePicker;

        public Task<Stream> GetImageStreamAsync()
        {
            // Create and define UIImagePickerController
            imagePicker = new UIImagePickerController
            {
                SourceType = UIImagePickerControllerSourceType.PhotoLibrary,
                MediaTypes = UIImagePickerController.AvailableMediaTypes(UIImagePickerControllerSourceType.PhotoLibrary)
            };
            System.Diagnostics.Debug.WriteLine("Created and defined UI imagePicker controller");

            // Set event handlers
            imagePicker.FinishedPickingMedia += OnImagePickerFinishedPickingMedia;
            imagePicker.Canceled += OnImagePickerCancelled;

            System.Diagnostics.Debug.WriteLine("About to present UIImagePickerController");
            // Present UIImagePickerController;
            UIWindow window = UIApplication.SharedApplication.KeyWindow;
            var viewController = window.RootViewController;
            viewController.PresentModalViewController(imagePicker, true);
            System.Diagnostics.Debug.WriteLine("Finished presenting UIImagePickerController");

            // Return Task object
            taskCompletionSource = new TaskCompletionSource<Stream>();
            return taskCompletionSource.Task;
        }

        void OnImagePickerFinishedPickingMedia(object sender, UIImagePickerMediaPickedEventArgs args)
        {
            System.Diagnostics.Debug.WriteLine("Image Picker Finished Picking Media");
            UIImage image = args.EditedImage ?? args.OriginalImage;

            if (image != null)
            {
                // Convert UIImage to .NET Stream object
                NSData data = image.AsJPEG(1);
                Stream stream = data.AsStream();

                // Set the Stream as the completion of the Task
                taskCompletionSource.SetResult(stream);
            }
            else
            {
                taskCompletionSource.SetResult(null);
            }
            imagePicker.DismissModalViewController(true);
        }

        void OnImagePickerCancelled(object sender, EventArgs args)
        {
            System.Diagnostics.Debug.WriteLine("Image picker canceled");
            taskCompletionSource.SetResult(null);
            imagePicker.DismissModalViewController(true);
        }

    }
}
