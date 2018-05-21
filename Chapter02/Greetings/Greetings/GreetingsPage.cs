using System;

using Xamarin.Forms;

namespace Greetings
{
    public partial class GreetingsPage : ContentPage
    {
        public GreetingsPage()
        {
            Content =
                    // new StackLayout
                    //{
                    //    Children = {
                    new Label
                    {
                        Text = "Greetings, Xamarin.Forms!",
                        BackgroundColor = Color.Yellow,
                        HorizontalOptions = LayoutOptions.Center,
                        VerticalOptions = LayoutOptions.Center,
                        HorizontalTextAlignment = TextAlignment.Center,
                        FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
                        FontAttributes = FontAttributes.Bold | FontAttributes.Italic
                    };
            //    }
            //};
            switch(Device.RuntimePlatform){
                case Device.iOS:
                    Padding = new Thickness(0, 40, 0, 0);
                    break;
            }
            //Obsolete since 2.3.4
            //Device.OnPlatform(iOS: () =>
            //{
            //    Padding = new Thickness(0, 40, 0, 0);
            //});
        }
    }
}

