using System;
using Xamarin.Forms;
namespace Olyfaunt
{
    public class EventUIElement : Grid
    {
        
        public EventUIElement(Event e)
        {
            // Initialize layout
            BackgroundColor = Color.FromHex("56A6F1");
            RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });
            RowDefinitions.Add(new RowDefinition { Height = new GridLength(3, GridUnitType.Star) });
            ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });
            ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });

            // Make things to go in grid
            Label titleLabel = new Label 
            { 
                Text = e.Name,
                TextColor = Color.White,
                //Font = "",
                HorizontalTextAlignment = TextAlignment.Center,
                VerticalTextAlignment = TextAlignment.Center,
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center
            };



            Grid descriptionGrid = new Grid();
            descriptionGrid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });
            descriptionGrid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });
            descriptionGrid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(3, GridUnitType.Star) });

            Label whatLabel = new Label
            {
                Text = "What: ",
                TextColor = Color.White,
                HorizontalTextAlignment = TextAlignment.Center,
                VerticalTextAlignment = TextAlignment.Center,
                HorizontalOptions = LayoutOptions.CenterAndExpand,
                VerticalOptions = LayoutOptions.CenterAndExpand
            };
            Label descriptionLabel = new Label
            {
                Text = e.Description,
                TextColor = Color.White,
                HorizontalTextAlignment = TextAlignment.Center,
                VerticalTextAlignment = TextAlignment.Center,
                HorizontalOptions = LayoutOptions.FillAndExpand,
                VerticalOptions = LayoutOptions.FillAndExpand
            };

            descriptionGrid.Children.Add(whatLabel, 0, 0);
            descriptionGrid.Children.Add(descriptionLabel, 0, 1);


            Grid dateGrid = new Grid();
            dateGrid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });
            dateGrid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });
            dateGrid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(3, GridUnitType.Star) });


            Label whenLabel = new Label                         
            {
                Text = "When: ",            
                TextColor = Color.White,
                HorizontalTextAlignment = TextAlignment.Center,
                VerticalTextAlignment = TextAlignment.Center,
                HorizontalOptions = LayoutOptions.CenterAndExpand,
                VerticalOptions = LayoutOptions.CenterAndExpand
            };
            Label dateLabel = new Label
            {
                Text = e.Date + "\nat " + e.Time,
                TextColor = Color.White,
                HorizontalTextAlignment = TextAlignment.Center,
                VerticalTextAlignment = TextAlignment.Center,
                HorizontalOptions = LayoutOptions.FillAndExpand,
                VerticalOptions = LayoutOptions.FillAndExpand
            };

            dateGrid.Children.Add(whenLabel, 0, 0);
            dateGrid.Children.Add(dateLabel, 0, 1);

            // Put everything together
            Children.Add(titleLabel, 0, 0);
            Grid.SetColumnSpan(titleLabel, 2);

            Children.Add(descriptionGrid, 0, 1);
            Children.Add(dateGrid, 1, 1);

        }
    }
}
