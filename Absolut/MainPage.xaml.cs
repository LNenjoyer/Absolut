using Microsoft.Maui.Layouts;

namespace Absolut
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            // Tworzymy AbsoluteLayout 
            AbsoluteLayout layout = new AbsoluteLayout();
            // Tworzymy tło (zielony BoxView) 
            BoxView backgroundBox = new BoxView
            {
                Color = Colors.Yellow
            };
            AbsoluteLayout.SetLayoutBounds(backgroundBox, new Rect(0, 0, 1, 1));
            AbsoluteLayout.SetLayoutFlags(backgroundBox, AbsoluteLayoutFlags.All);
            // Tworzymy biały BoxView 
            BoxView whiteBox = new BoxView
            {
                Color = Colors.Blue
            };
            AbsoluteLayout.SetLayoutBounds(whiteBox, new Rect(0.5, 0.5, 180, 180));
            AbsoluteLayout.SetLayoutFlags(whiteBox, AbsoluteLayoutFlags.PositionProportional);
            // Tworzymy przycisk 
            Button startButton = new Button
            {
                Text = "Click me",
                BackgroundColor = Colors.Black,
                TextColor = Colors.White
            };
            AbsoluteLayout.SetLayoutBounds(startButton, new Rect(0, 0.95, 1, 50));
            AbsoluteLayout.SetLayoutFlags(startButton, AbsoluteLayoutFlags.PositionProportional | AbsoluteLayoutFlags.WidthProportional);
            // Dodajemy elementy do layoutu 
            layout.Children.Add(backgroundBox);
            layout.Children.Add(whiteBox);
            layout.Children.Add(startButton);
            // Ustawiamy layout jako zawartość strony 
            Content = layout;
        }
    }
}
