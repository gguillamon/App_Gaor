using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UNO_CINCO.Models;
using UNO_CINCO.ViewModels;
using UNO_CINCO.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace UNO_CINCO.Views
{
    public partial class ClientesPage : ContentPage
    {
        ClientesViewModel _viewModel;

        public ClientesPage()
        {
            InitializeComponent();

            BindingContext = _viewModel = new ClientesViewModel();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            _viewModel.OnAppearing();
        }
    }
}