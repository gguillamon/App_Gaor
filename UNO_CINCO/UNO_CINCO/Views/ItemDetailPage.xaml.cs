using System.ComponentModel;
using UNO_CINCO.ViewModels;
using Xamarin.Forms;

namespace UNO_CINCO.Views
{
    public partial class ClienteDetailPage : ContentPage
    {
        public ClienteDetailPage()
        {
            InitializeComponent();
            BindingContext = new ClienteDetailViewModel();
        }
    }
}