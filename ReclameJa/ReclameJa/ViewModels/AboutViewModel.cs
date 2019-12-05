using MvvmHelpers;
using System;
using System.Windows.Input;

using Xamarin.Forms;

namespace ReclameJa.ViewModels
{
    public class AboutViewModel : BaseViewModel
    {
        public AboutViewModel()
        {
            Title = "About";

            OpenWebCommand = new Command(() => Device.OpenUri(new Uri("https://github.com/glaubermarcelino/ads4periodo")));
        }

        public ICommand OpenWebCommand { get; }
    }
}