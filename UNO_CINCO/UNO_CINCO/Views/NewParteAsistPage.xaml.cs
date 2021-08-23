using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UNO_CINCO.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using UNO_CINCO.ViewModels;

namespace UNO_CINCO.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NewPartesAsistPage : ContentPage
    {
        public PartesAsistencia Item { get; set; }

        public NewPartesAsistPage()
        {
            InitializeComponent();
            BindingContext = new NewParteAsistViewModel();
        }
    }
}