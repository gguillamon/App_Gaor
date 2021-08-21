using System.ComponentModel;
using UNO_CINCO.ViewModels;
using Xamarin.Forms;

namespace UNO_CINCO.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}