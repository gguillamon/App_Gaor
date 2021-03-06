using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using UNO_CINCO.Models;
using UNO_CINCO.Services;
using Xamarin.Forms;

namespace UNO_CINCO.ViewModels
{
    public class BaseViewModel : INotifyPropertyChanged
    {
        public IDataStore<Clientes> DataStore => DependencyService.Get<IDataStore<Clientes>>();
        public IDataStore<PartesAsistencia> DataStorePartes => DependencyService.Get<IDataStore<PartesAsistencia>>();
        public IDataToFireBase<Clientes> DataStoreFire => DependencyService.Get<IDataToFireBase<Clientes>>();
        public IDataToFireBase<PartesAsistencia> DataPartesFire => DependencyService.Get<IDataToFireBase<PartesAsistencia>>();




        bool isBusy = false;
        public bool IsBusy
        {
            get { return isBusy; }
            set { SetProperty(ref isBusy, value); }
        }

        string title = string.Empty;
        public string Title
        {
            get { return title; }
            set { SetProperty(ref title, value); }
        }

        protected bool SetProperty<T>(ref T backingStore, T value,
            [CallerMemberName] string propertyName = "",
            Action onChanged = null)
        {
            if (EqualityComparer<T>.Default.Equals(backingStore, value))
                return false;

            backingStore = value;
            onChanged?.Invoke();
            OnPropertyChanged(propertyName);
            return true;
        }

        #region INotifyPropertyChanged
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            var changed = PropertyChanged;
            if (changed == null)
                return;

            changed.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion
    }
}
