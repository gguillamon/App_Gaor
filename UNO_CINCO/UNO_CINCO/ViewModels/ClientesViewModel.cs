using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Threading.Tasks;
using UNO_CINCO.Models;
using UNO_CINCO.Views;
using Xamarin.Forms;

namespace UNO_CINCO.ViewModels
{
    public class ClientesViewModel : BaseViewModel
    {
        private Clientes _selectedItem;

        public ObservableCollection<Clientes> Items { get; }
        public Command LoadItemsCommand { get; }
        public Command AddItemCommand { get; }
        public Command<Clientes> ItemTapped { get; }

        public ClientesViewModel()
        {
            Title = "Clientes";
            Items = new ObservableCollection<Clientes>();
            LoadItemsCommand = new Command(async () => await ExecuteLoadItemsCommand());

            ItemTapped = new Command<Clientes>(OnItemSelected);

            AddItemCommand = new Command(OnAddItem);
        }

        async Task ExecuteLoadItemsCommand()
        {
            IsBusy = true;

            try
            {
                Items.Clear();
                var items = await DataStore.GetItemsAsync(true);
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

        public Clientes SelectedItem
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
            await Shell.Current.GoToAsync(nameof(NewClientePage));
        }

        private async void OnItemSelected(Clientes item)
        {
            if (item == null)
                return;

            // This will push the ItemDetailPage onto the navigation stack
            await Shell.Current.GoToAsync($"{nameof(ClienteDetailPage)}?{nameof(ClienteDetailViewModel.Codigo)}={item.Codigo}");
        }
    }
}