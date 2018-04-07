using System;
using Xamarin.Forms;
namespace Olyfaunt
{
    public class EventUIElement : Grid
    {
        
        public EventUIElement(Event e)
        {
            // Initialize layout
            RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });
            RowDefinitions.Add(new RowDefinition { Height = new GridLength(3, GridUnitType.Star) });
            ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });
            ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });

            // Make things to go in grid
            Label titleLabel = new Label { Text = e.Name };

        }
    }
}
