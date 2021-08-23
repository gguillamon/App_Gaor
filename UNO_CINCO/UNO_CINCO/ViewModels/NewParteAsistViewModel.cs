using System;
using System.Collections.Generic;
using System.Text;
using UNO_CINCO.Models;
using Xamarin.Forms;

namespace UNO_CINCO.ViewModels
{
    class NewParteAsistViewModel : BaseViewModel
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


        public NewParteAsistViewModel()
        {
            SaveCommand = new Command(OnSave, ValidateSave);
            CancelCommand = new Command(OnCancel);
            this.PropertyChanged +=
                (_, __) => SaveCommand.ChangeCanExecute();
        }

        private bool ValidateSave()
        {
            return !String.IsNullOrWhiteSpace(IdParte)
                && !String.IsNullOrWhiteSpace(CodigoEmpresa);
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
            PartesAsistencia newItem = new PartesAsistencia()
            {
            IdParte = IdParte,
            CodigoEmpresa = CodigoEmpresa,
            Usuario = Usuario,
            Inicio = Inicio,
            Fin = Fin,
            Fecha = Fecha,
            ContactoId = ContactoId,
            TipoAsistencia = TipoAsistencia,
            Mantenimiento =Mantenimiento,
            TipoCliente = TipoCliente,
            Descripcion = Descripcion,
            FirmaUser = FirmaUser,
            FirmaCliente = FirmaCliente

        };






            await DataStore.AddItemAsync(newItem);

            // This will pop the current page off the navigation stack
            await Shell.Current.GoToAsync("..");
        }
    }
}
