using System;
using Xamarin.Forms;
namespace Olyfaunt
{
    /// <summary>
    /// UI Element to display a problem, as well as ways to react to it 
    /// </summary>
    public class ProblemUIElement : Grid
    {
        public ProblemUIElement(Problem problem)
        {
            BackgroundColor = Color.FromHex("F10F0F");

            // Initialize layout
            HeightRequest = 400;
            Padding = new Thickness(5, 0);
            HorizontalOptions = LayoutOptions.FillAndExpand;
            VerticalOptions = LayoutOptions.FillAndExpand;

            RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });
            RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });
            RowDefinitions.Add(new RowDefinition { Height = new GridLength(5, GridUnitType.Star) });
            RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });

            ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });
            ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });
            ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });
            ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });



            // Add in elements
            Children.Add(problem.ProblemImage, 0, 2);
            Grid.SetColumnSpan(Children[0], 4);


            Label problemTitleLabel = new Label
            {
                Text = problem.ReportingUser.Username + " thinks this is a\nPROBLEM",
                TextColor = Color.White,
                HorizontalTextAlignment = TextAlignment.Center,
                VerticalTextAlignment = TextAlignment.Center,
                HorizontalOptions = LayoutOptions.Fill,
                VerticalOptions = LayoutOptions.Fill
            };
            Children.Add(problemTitleLabel, 1, 0);
            Grid.SetColumnSpan(problemTitleLabel, 3);
            Grid.SetRowSpan(problemTitleLabel, 2);


            Image profileImage = problem.ReportingUser.profileImage;
            profileImage.HorizontalOptions = LayoutOptions.FillAndExpand;
            profileImage.VerticalOptions = LayoutOptions.FillAndExpand;
            Children.Add(profileImage, 0, 0);
            Grid.SetRowSpan(profileImage, 2);


            Button agreeButton = new Button
            {
                Image = "agree.png",
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center
            };
            Button disagreeButton = new Button
            {
                Image = "disagree.png",
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center
            };
            Button iDidItButton = new Button
            {
                Image = "i_did_it.png",
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center
            };
            Button iFixedItButton = new Button
            {
                Image = "i_fixed_it.png",
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center
            };

            // Note: I know theres a better way to do this. I don't care rn
            agreeButton.Clicked += (sender, e) => 
            {
                System.Diagnostics.Debug.WriteLine("Agree image tostring: " + agreeButton.Image.ToString());
                if (agreeButton.Image.ToString().Equals("File: agree.png"))
                {
                    agreeButton.Image = "agree_tapped.png";
                }
                else
                {
                    agreeButton.Image = "agree.png";
                }
            };
            disagreeButton.Clicked += (sender, e) =>
            {
                if (disagreeButton.Image.ToString().Equals("File: disagree.png"))
                {
                    disagreeButton.Image = "disagree_tapped.png";
                }
                else
                {
                    disagreeButton.Image = "disagree.png";
                }
            };
            iDidItButton.Clicked += (sender, e) =>
            {
                if (iDidItButton.Image.ToString().Equals("File: i_did_it.png"))
                {
                    iDidItButton.Image = "i_did_it_tapped.png";
                }
                else
                {
                    iDidItButton.Image = "i_did_it.png";
                }
            };
            iFixedItButton.Clicked += (sender, e) =>
            {
                if (iFixedItButton.Image.ToString().Equals("File: i_fixed_it.png"))
                {
                    iFixedItButton.Image = "i_fixed_it_tapped.png";
                }
                else
                {
                    iFixedItButton.Image = "i_fixed_it.png";
                }
            };

            Children.Add(agreeButton, 0, 3 );
            Children.Add(disagreeButton, 1, 3);
            Children.Add(iDidItButton, 2, 3);
            Children.Add(iFixedItButton, 3, 3);

        }
    }
}
