using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Text;
using System.Threading.Tasks;
using UNO_CINCO.Models;
using UNO_CINCO.Views;
using Xamarin.Forms;

namespace UNO_CINCO.ViewModels
{
    class ParteAsistViewModel : BaseViewModel
    {
        public PartesAsistencia _selectedItem;

        public ObservableCollection<PartesAsistencia> Items { get; }
        public Command LoadItemsCommand { get; }
        public Command AddItemCommand { get; }
        public Command<PartesAsistencia> ItemTapped { get; }

        public ParteAsistViewModel()
        {
            Title = "Partes Asistencia";
            Items = new ObservableCollection<PartesAsistencia>();
            LoadItemsCommand = new Command(async () => await ExecuteLoadItemsCommand());

            ItemTapped = new Command<PartesAsistencia>(OnItemSelected);

            AddItemCommand = new Command(OnAddItem);
        }

        async Task ExecuteLoadItemsCommand()
        {
            IsBusy = true;

            try
            {
                Items.Clear();
                var items = await DataStorePartes.GetItemsAsync(true);
                foreach (var item in items)
                {
                    Items.Add(item);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
            finally
            {
                IsBusy = false;
            }
        }

        public void OnAppearing()
        {
            IsBusy = true;
            SelectedItem = null;
        }

        public PartesAsistencia SelectedItem
        {
            get => _selectedItem;
            set
            {
                SetProperty(ref _selectedItem, value);
                OnItemSelected(value);
            }
        }

        private async void OnAddItem(object obj)
        {
            await Shell.Current.GoToAsync(nameof(NewPartesAsistPage));
        }

        private async void OnItemSelected(PartesAsistencia item)
        {
            if (item == null)
                return;

            // This will push the ItemDetailPage onto the navigation stack
            await Shell.Current.GoToAsync($"{nameof(ClienteDetailPage)}?{nameof(ParteAsistDetailViewModel.ItemId)}={item.IdParte}");
        }
    }
}
