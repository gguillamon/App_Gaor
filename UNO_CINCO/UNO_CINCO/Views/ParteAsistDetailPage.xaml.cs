using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UNO_CINCO.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace UNO_CINCO.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ParteAsistDetailPage : ContentPage
    {
        public ParteAsistDetailPage()
        {
            InitializeComponent();
            BindingContext = new ParteAsistDetailViewModel();
        }
    }
}