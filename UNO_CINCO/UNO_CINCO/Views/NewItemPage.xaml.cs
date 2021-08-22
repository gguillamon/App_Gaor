using System;
using System.Collections.Generic;
using System.ComponentModel;
using UNO_CINCO.Models;
using UNO_CINCO.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace UNO_CINCO.Views
{
    public partial class NewClientePage : ContentPage
    {
        public Clientes Item { get; set; }

        public NewClientePage()
        {
            InitializeComponent();
            BindingContext = new NewClienteViewModel();
        }

       
    }
}