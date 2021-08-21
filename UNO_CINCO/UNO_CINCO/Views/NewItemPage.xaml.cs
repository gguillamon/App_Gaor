using System;
using System.Collections.Generic;
using System.ComponentModel;
using UNO_CINCO.Models;
using UNO_CINCO.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace UNO_CINCO.Views
{
    public partial class NewItemPage : ContentPage
    {
        public Clientes Item { get; set; }

        public NewItemPage()
        {
            InitializeComponent();
            BindingContext = new NewItemViewModel();
        }
    }
}