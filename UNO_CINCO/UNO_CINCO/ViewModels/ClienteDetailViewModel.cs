using System;
using System.Diagnostics;
using System.Threading.Tasks;
using UNO_CINCO.Models;
using Xamarin.Forms;

namespace UNO_CINCO.ViewModels
{
    [QueryProperty(nameof(codigo), nameof(codigo))]
    public class ClienteDetailViewModel : BaseViewModel
    {
        private string codigo;
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

        public string Codigo
        {
            get
            {
                return codigo;
            }
            set
            {
                codigo = value;
                LoadItemId(value);
            }
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

        public async void LoadItemId(string itemId)
        {
            try
            {
                var item = await DataStore.GetItemAsync(itemId);
                codigo = item.codigo;
                razon = item.razon;
                nombre = item.nombre;
                alias = item.alias;
                email = item.email;
                direccion = item.direccion;
                localidad = item.localidad;
                provincia = item.provincia;
                cp = item.cp;
                pais = item.pais;
                telefono1 = item.pais;
                telefono2 = item.telefono2;
                fax = item.fax;
                web = item.web;
    }
            catch (Exception)
            {
                Debug.WriteLine("Error al leer registro");
            }
        }
    }
}
