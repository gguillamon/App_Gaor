using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using UNO_CINCO.Models;
using UNO_CINCO.Services;
using Xamarin.Forms;

namespace UNO_CINCO.ViewModels
{
    public class NewClienteViewModel : BaseViewModel
    {
        ClienteFireStore clienteFirestore = new ClienteFireStore();
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
        private bool isrefreshing = false;
        private object listViewSource;

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
        public bool IsRefreshing { get => isrefreshing; set => isrefreshing = value; }
        public object ListViewSource { get => listViewSource; set => listViewSource = value; }
        
        public ICommand insertCommand
        {
            get
            {
                return new RelayCommand(InserMethod);
            }
        }
        public async void InserMethod()
        {
            var cliente = new Clientes
            {
                Codigo = codigo,
                Nombre = nombre,
                Razon = razon,
                Alias = alias,
                Nif = nif,
                Email = email,
                Direccion = direccion,
                Localidad = localidad,
                Provincia = provincia,
                Cp = cp,
                Pais = pais,
                Telefono1 = telefono1,
                Telefono2 = telefono2,
                Fax = fax,
                Web1 = web1,
                Web2 = web2
            };

            await clienteFirestore.AddItemToDB(cliente);
            this.IsRefreshing = true;
            await Task.Delay(1000);
            this.IsRefreshing = false;
            await LoadData();
            await Shell.Current.GoToAsync("..");
            

        }
        public async Task LoadData()
        {
            this.ListViewSource = await clienteFirestore.ShowAllItemsDB();
            
        }

        private Command cancel1;

        public ICommand cancel
        {
            get
            {
                if (cancel1 == null)
                {
                    cancel1 = new Command(Performcancel);
                }

                return cancel1;
            }
        }

        private void Performcancel()
        {
            Shell.Current.GoToAsync("..");
        }


    }
    }

