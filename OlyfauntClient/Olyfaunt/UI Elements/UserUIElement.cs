using System;
using Xamarin.Forms;
namespace Olyfaunt
{
    /// <summary>
    /// UI element to use when looking at lists of users
    /// </summary>
    public class UserUIElement : Grid
    {
        const int userUIElHeight = 100;
        public User user { get; private set;  }    // internal storage of username


        public UserUIElement(User user)
        {
            this.user = user;
            // Get info from server about profile

            // Layout specifications
            this.HeightRequest = userUIElHeight;
            Padding = new Thickness(5, 0);

            ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(3, GridUnitType.Star) });    // Add columns so that user profile takes up 1/5 of UI element
            ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(8, GridUnitType.Star) });
            RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });

            // Add in user data
            Label usernameLabel = new Label
            {
                Text = user.Username,
                HorizontalOptions = LayoutOptions.CenterAndExpand,
                VerticalOptions = LayoutOptions.CenterAndExpand,
                HorizontalTextAlignment = TextAlignment.Center,
                VerticalTextAlignment = TextAlignment.Center
            };

            TapGestureRecognizer tgrLabel = new TapGestureRecognizer();
            tgrLabel.Tapped += (sender, e) =>
            {
                Navigation.PushAsync(new NavigationPage(new ViewProfile(user)));
            };

            usernameLabel.GestureRecognizers.Add(tgrLabel);

            Children.Add(user.profileImage, 0, 0);
            Children.Add(usernameLabel, 1, 0);


        }
    }
}
