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
            // Initialize layout
            HeightRequest = 200;
            HorizontalOptions = LayoutOptions.FillAndExpand;
            VerticalOptions = LayoutOptions.FillAndExpand;

            ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });
            RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });

            Children.Add(problem.ProblemImage, 0, 0);
        }
    }
}
