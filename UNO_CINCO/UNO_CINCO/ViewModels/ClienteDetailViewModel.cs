using System;
using System.Diagnostics;
using System.Threading.Tasks;
using UNO_CINCO.Models;
using UNO_CINCO.Services;
using Xamarin.Forms;

namespace UNO_CINCO.ViewModels
{
   
    public class ClienteDetailViewModel
    {
        ClienteFireStore firestore = new ClienteFireStore();

        private int itemId;
        private int codigo;
        private string nombre;
        private string razon;
        private string alias;
        private string nif;
        private string email;
        private string direccion;
        private string localidad;
        private string provincia;
        private string cp;
        private string pais;
        private string telefono1;
        private string telefono2;
        private string fax;
        private string web1;
        private string web2;

        public int ItemId { get => itemId; set => itemId = value; }
        public int Codigo { get => codigo; set => codigo = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Razon { get => razon; set => razon = value; }
        public string Alias { get => alias; set => alias = value; }
        public string Nif { get => nif; set => nif = value; }
        public string Email { get => email; set => email = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public string Localidad { get => localidad; set => localidad = value; }
        public string Provincia { get => provincia; set => provincia = value; }
        public string Cp { get => cp; set => cp = value; }
        public string Pais { get => pais; set => pais = value; }
        public string Telefono1 { get => telefono1; set => telefono1 = value; }
        public string Telefono2 { get => telefono2; set => telefono2 = value; }
        public string Fax { get => fax; set => fax = value; }
        public string Web1 { get => web1; set => web1 = value; }
        public string Web2 { get => web2; set => web2 = value; }

        public ClienteDetailViewModel(Clientes item)
        {
            Codigo = item.Codigo;
            Nombre = item.Nombre;
            Razon = item.Razon;
            Alias = item.Alias;
            Nif = item.Nif;
            Email = item.Email;
            Direccion = item.Direccion;
            Localidad = item.Localidad;
            Provincia = item.Provincia;
            Cp = item.Cp;
            Pais = item.Pais;
            Telefono1 = item.Telefono1;
            Telefono2 = item.Telefono2;
            Fax = item.Fax;
            Web1 = item.Web1;
            Web2 = item.Web2;

        }
        public ClienteDetailViewModel()
        {

        }
       
    }
}
