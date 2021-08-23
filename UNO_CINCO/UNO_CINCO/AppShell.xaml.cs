using System;
using System.Collections.Generic;
using UNO_CINCO.ViewModels;
using UNO_CINCO.Views;
using Xamarin.Forms;

namespace UNO_CINCO
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(ClienteDetailPage), typeof(ClienteDetailPage));
            Routing.RegisterRoute(nameof(NewClientePage), typeof(NewClientePage));
            Routing.RegisterRoute(nameof(ParteAsistDetailPage), typeof(ParteAsistDetailPage));
            Routing.RegisterRoute(nameof(NewPartesAsistPage), typeof(NewPartesAsistPage));
        }

        private async void OnMenuItemClicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("//LoginPage");
        }
    }
}
