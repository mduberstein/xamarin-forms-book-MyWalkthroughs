using System;

using Xamarin.Forms;

namespace Greetings
{
    public partial class GreetingsPage : ContentPage
    {
        public GreetingsPage()
        {
            Content = new StackLayout
            {
                Children = {
                    new Label { Text = "Hello ContentPage" }
                }
            };
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

