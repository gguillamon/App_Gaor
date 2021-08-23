using System;
using System.Diagnostics;
using System.Threading.Tasks;
using UNO_CINCO.Models;
using Xamarin.Forms;

namespace UNO_CINCO.ViewModels
{
    [QueryProperty(nameof(ItemId), nameof(ItemId))]
    public class ClienteDetailViewModel : BaseViewModel
    {
        private string itemId;
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
        

        public string ItemId
        {

            get
            {
                return itemId;
            }
            set
            {
                itemId = value;
                LoadItemId(value);
            }
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

        public async void LoadItemId(string itemId)
        {
            try
            {
                var item = await DataStore.GetItemAsync(itemId);
                Codigo = item.Codigo;
                Razon = item.Razon;
                Nombre = item.Nombre;
                Alias = item.Alias;
                Email = item.Email;
                Direccion = item.Direccion;
                Localidad = item.Localidad;
                Provincia = item.Provincia;
                Cp = item.Cp;
                Pais = item.Pais;
                Telefono1 = item.Telefono1;
                Telefono2 = item.Telefono2;
                Fax = item.Fax;
                Web = item.Web;
    }
            catch (Exception)
            {
                Debug.WriteLine("Error al leer registro");
            }
        }
    }
}
