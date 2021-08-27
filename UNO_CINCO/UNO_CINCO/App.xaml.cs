using System;
using UNO_CINCO.Services;
using UNO_CINCO.ViewModels;
using UNO_CINCO.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace UNO_CINCO
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

           

             MainPage = new AppShell();
           /* MainPage = new NavigationPage(new PaginaListaClientes());*/
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
