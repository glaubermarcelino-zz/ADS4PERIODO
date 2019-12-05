using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ReclameJa.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private void btnRegistrar_Clicked(object sender, System.EventArgs e)
        {
            Application.Current.MainPage = new NavigationPage(new UsuarioPage());
        }

        private void btnEntrar_Clicked(object sender, System.EventArgs e)
        {
            Application.Current.MainPage = new AppShell();
        }
    }
}