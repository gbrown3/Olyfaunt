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
            BackgroundColor = Color.Red;

            // Initialize layout
            HeightRequest = 200;
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
                Text = "thinks this is a PROBLEM",
                TextColor = Color.White,
                HorizontalTextAlignment = TextAlignment.Center,
                VerticalTextAlignment = TextAlignment.Center,
                HorizontalOptions = LayoutOptions.FillAndExpand,
                VerticalOptions = LayoutOptions.FillAndExpand
            };
            Grid.SetColumnSpan(problemTitleLabel, 3);
            Grid.SetRowSpan(problemTitleLabel, 2);

            Children.Add(problemTitleLabel, 1, 0);


            Image profileImage = problem.ReportingUser.profileImage;
            Children.Add(profileImage, 0, 0);
            Grid.SetRowSpan(profileImage, 2);



        }
    }
}
