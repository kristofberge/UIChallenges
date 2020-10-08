using UiChallenges.ViewModels;
using Xamarin.Forms;

namespace UiChallenges.Pages
{
    public partial class CruisMobilePage : ContentPage
    {
        public CruisMobilePage()
        {
            InitializeComponent();

            BindingContext = new CruiseMobileViewModel();
        }

        private void OnItemTapped(object sender, SelectionChangedEventArgs e)
        {
            Navigation.PushModalAsync(new CruiseDetailsPage { BindingContext = new CruiseDetailsViewModel(e.CurrentSelection[0] as Cruise) });
        }
    }
}
