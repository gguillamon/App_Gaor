using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using UNO_CINCO.Models;
using Xamarin.Forms;

namespace UNO_CINCO.ViewModels
{
    public class NewClienteViewModel : BaseViewModel
    {
        public string codigo;
        private string razon;
        private string nombre;
        public string alias;
        private string email;
        private string direccion;
        private string localidad;
        private string provincia;
        private string cp;
        private string pais;
        private string telefono1;
        private string telefono2;
        private string fax;
        private string web;

        public NewClienteViewModel()
        {
            SaveCommand = new Command(OnSave, ValidateSave);
            CancelCommand = new Command(OnCancel);
            this.PropertyChanged +=
                (_, __) => SaveCommand.ChangeCanExecute();
        }

        private bool ValidateSave()
        {
            return !String.IsNullOrWhiteSpace(Codigo)
                && !String.IsNullOrWhiteSpace(Nombre);
        }
        public string Codigo
        {
            get => codigo;
            set => SetProperty(ref codigo, value);
        }
        public string Razon
        {
            get => razon;
            set => SetProperty(ref razon, value);
        }

        public string Nombre
        {
            get => nombre;
            set => SetProperty(ref nombre, value);
        }
        public string Alias
        {
            get => alias;
            set => SetProperty(ref nombre, value);
        }
        public string Email
        {
            get => email;
            set => SetProperty(ref email, value);
        }
        public string Direccion
        {
            get => direccion;
            set => SetProperty(ref direccion, value);
        }
        public string Localidad
        {
            get => localidad;
            set => SetProperty(ref localidad, value);
        }
        public string Provincia
        {
            get => provincia;
            set => SetProperty(ref provincia, value);
        }
        public string Cp
        {
            get => cp;
            set => SetProperty(ref cp, value);
        }
        public string Pais
        {
            get => pais;
            set => SetProperty(ref pais, value);
        }
        public string Telefono1
        {
            get => telefono1;
            set => SetProperty(ref telefono1, value);
        }
        public string Telefono2
        {
            get => telefono2;
            set => SetProperty(ref telefono2, value);
        }
        public string Fax
        {
            get => fax;
            set => SetProperty(ref fax, value);
        }
        public string Web
        {
            get => web;
            set => SetProperty(ref web, value);
        }





        public Command SaveCommand { get; }
        public Command CancelCommand { get; }

        private async void OnCancel()
        {
            // This will pop the current page off the navigation stack
            await Shell.Current.GoToAsync("..");
        }

        private async void OnSave()
        {
            Clientes newItem = new Clientes()
            {
                Codigo = Codigo,
                Razon = Razon,
                Nombre = Nombre,
                Alias = Alias,
                Email = Email,
                Direccion = Direccion,
                Localidad = Localidad,
                Provincia = Provincia,
                Cp = Cp,
                Pais = Pais,
                Telefono1 = Telefono1,
                Telefono2 = Telefono2,
                Fax = Fax,
                Web = Web

            };
         



            

            await DataStore.AddItemAsync(newItem);

            // This will pop the current page off the navigation stack
            await Shell.Current.GoToAsync("..");
        }
    }
}
