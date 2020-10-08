using System;

using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration;
using Xamarin.Forms.PlatformConfiguration.iOSSpecific;

namespace UiChallenges.Pages
{
    public partial class CruiseDetailsPage : ContentPage
    {
        public CruiseDetailsPage()
        {
            On<iOS>().SetUseSafeArea(true);

            InitializeComponent();
        }

        async void Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopModalAsync();
        }
    }
}
