using ReclameJa.ViewModels;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ReclameJa.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AcompanhamentoPage : ContentPage
    {
        public AcompanhamentoViewModel _acompanhamentoViewModel;
        public AcompanhamentoPage()
        {
            InitializeComponent();
            _acompanhamentoViewModel = new AcompanhamentoViewModel();
            BindingContext = _acompanhamentoViewModel;
        }
    }
}