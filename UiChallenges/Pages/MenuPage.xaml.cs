using System;
using System.Collections.Generic;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace UiChallenges.Pages
{
    public partial class MenuPage : ContentPage
    {
        public MenuPage()
        {
            InitializeComponent();
        }

        async void NavigateToChallenge(object sender, EventArgs e)
        {
            switch (((Button)sender).Text)
            {
                case "Cruise mobile":
                    await Navigation.PushAsync(new CruisMobilePage());
                    break;
                default:
                    break;
            }
        }

        async void NavigateToUrl(object sender, EventArgs e)
        {
            await Browser.OpenAsync(((Button)sender).BindingContext as string, BrowserLaunchMode.SystemPreferred);
        }
    }
}
