using System;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace UNO_CINCO.ViewModels
{
    public class AboutViewModel : BaseViewModel
    {
        public AboutViewModel()
        {
            Title = "GAOR TM";
            OpenWebCommand = new Command(async () => await Browser.OpenAsync("https://www.gaortm.es/"));
        }

        public ICommand OpenWebCommand { get; }
    }
}