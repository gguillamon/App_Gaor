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
        

        public ClientesPage()
        {
            InitializeComponent();

            BindingContext =  new ClientesViewModel();
        }
        public async void  ListViewName_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            await Navigation.PushAsync(new ClienteDetailPage(e.SelectedItem as Clientes));
        }

    }
}