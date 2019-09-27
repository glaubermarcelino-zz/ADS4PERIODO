using ManFree.ViewModels;
using Rg.Plugins.Popup.Services;
using Xamarin.Forms;

namespace ReclameJa.Views
{
    //[XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
            BindingContext = new LoginViewModel();
        }

        private void BtnEnter_Clicked(object sender, System.EventArgs e)
        {
            //App.Current.MainPage = new NavigationPage(new MainPage());
            App.Current.MainPage = new NavigationPage(new DashBoard());
        }

        private async void BtnPopup_Clicked(object sender, System.EventArgs e)
        {
            //Chamado ao Rg.Plugins.Popup
            await PopupNavigation.Instance.PushAsync(new PopUpFreePage());

        }
    }
}