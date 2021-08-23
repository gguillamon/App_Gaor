using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using Xamarin.Forms;

namespace UNO_CINCO.ViewModels
{
    [QueryProperty(nameof(ItemId), nameof(ItemId))]
    public class ParteAsistDetailViewModel : BaseViewModel
    {
        private string itemId;
        private string idParte;
        private string codigoEmpresa;
        private string usuario;
        private DateTime inicio;
        private DateTime fin;
        private DateTime fecha;
        private string contactoId;
        private string tipoAsistencia;
        private string mantenimiento;
        private string tipoCliente;
        private string descripcion;
        private byte[] firmaUser;
        private byte[] firmaCliente;



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
        public string IdParte
        {
            get => idParte;
            set => SetProperty(ref idParte, value);
        }

        public string CodigoEmpresa
        {
            get => codigoEmpresa;
            set => SetProperty(ref codigoEmpresa, value);
        }

        public string Usuario
        {
            get => usuario;
            set => SetProperty(ref usuario, value);
        }
        public DateTime Inicio
        {
            get => inicio;
            set => SetProperty(ref inicio, value);
        }
        public DateTime Fin
        {
            get => fin;
            set => SetProperty(ref fin, value);
        }
        public DateTime Fecha
        {
            get => fecha;
            set => SetProperty(ref fecha, value);
        }
        public string ContactoId
        {
            get => contactoId;
            set => SetProperty(ref contactoId, value);
        }
        public string TipoAsistencia
        {
            get => tipoAsistencia;
            set => SetProperty(ref tipoAsistencia, value);
        }
        public string Mantenimiento
        {
            get => mantenimiento;
            set => SetProperty(ref mantenimiento, value);
        }
        public string TipoCliente
        {
            get => tipoCliente;
            set => SetProperty(ref tipoCliente, value);
        }
        public string Descripcion
        {
            get => descripcion;
            set => SetProperty(ref descripcion, value);
        }
        public byte[] FirmaUser
        {
            get => firmaUser;
            set => SetProperty(ref firmaUser, value);
        }
        public byte[] FirmaCliente
        {
            get => firmaCliente;
            set => SetProperty(ref firmaCliente, value);
        }
       

        public async void LoadItemId(string itemId)
        {
            try
            {
                var item = await DataStore.GetItemAsync(itemId);
                IdParte = item.IdParte;
                CodigoEmpresa = item.CodigoEmpresa;
                Usuario = item.Usuario;
                Inicio = item.Inicio;
                Fin = item.Fin;
                Fecha = item.Fecha;
                ContactoId = item.ContactoId;
                TipoAsistencia = item.TipoAsistencia;
                Mantenimiento = item.Mantenimiento;
                TipoCliente = item.TipoCliente;
                Descripcion = item.Descripcion;
                FirmaUser = item.FirmaUser;
                FirmaCliente = item.FirmaCliente;
                
            }
            catch (Exception)
            {
                Debug.WriteLine("Error al leer registro");
            }
        }
    }
}
