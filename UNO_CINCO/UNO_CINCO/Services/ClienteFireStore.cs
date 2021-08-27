using Firebase.Database;
using Firebase.Database.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UNO_CINCO.Models;
using UNO_CINCO.ViewModels;

namespace UNO_CINCO.Services
{
    class ClienteFireStore : IDataToFireBase<Clientes>
    {
        FirebaseClient firebase;

        public ClienteFireStore()
        {
            firebase = new FirebaseClient("https://gaorapp-default-rtdb.firebaseio.com/");
        }

        public async Task AddItemToDB(Clientes itemModel)
        {
            var now = DateTime.Now;
            var zeroDate = DateTime.MinValue.AddHours(now.Hour).AddMinutes(now.Minute).AddSeconds(now.Second).AddMilliseconds(now.Millisecond);
            int uniqueId = (int)(zeroDate.Ticks / 10000);


            await firebase.Child("clientes").PostAsync(new Clientes()
            {
               
                Codigo = uniqueId,
                Nombre = itemModel.Nombre,
                Razon = itemModel.Razon,
                Alias = itemModel.Alias,
                Nif = itemModel.Nif,
                Email = itemModel.Email,
                Direccion = itemModel.Direccion,
                Localidad = itemModel.Localidad,
                Provincia = itemModel.Provincia,
                Cp = itemModel.Cp,
                Pais = itemModel.Pais,
                Telefono1 = itemModel.Telefono1,
                Telefono2 = itemModel.Telefono2,
                Fax = itemModel.Fax,
                Web1 = itemModel.Web1,
                Web2 = itemModel.Web2

            });
        }

        public async Task DeleteItem(int id)
        {
            var toDelete = (await firebase.Child("clientes").OnceAsync<Clientes>()).Where(a => a.Object.Codigo == id).FirstOrDefault();

             await firebase.Child("clientes").Child(toDelete.Key).DeleteAsync();
        }


        public async Task<List<Clientes>> ShowAllItemsDB()
        {
            return (await firebase.Child("clientes").OnceAsync<Clientes>()).Select(item => new Clientes
            {
                Codigo = item.Object.Codigo,
                Nombre = item.Object.Nombre,
                Razon = item.Object.Razon,
                Alias = item.Object.Alias,
                Nif = item.Object.Nif,
                Email = item.Object.Email,
                Direccion = item.Object.Direccion,
                Localidad = item.Object.Localidad,
                Provincia = item.Object.Provincia,
                Cp = item.Object.Cp,
                Pais = item.Object.Pais,
                Telefono1 = item.Object.Telefono1,
                Telefono2 = item.Object.Telefono2,
                Fax = item.Object.Fax,
                Web1 = item.Object.Web1,
                Web2 = item.Object.Web2

            }).ToList();
                
        }

        public Task<Clientes> ShowItemAsync(int id)
        {
            throw new NotImplementedException();
        }


        public async Task UpdateCodItem(Clientes item)
        {
            var toUpdate = (await firebase.Child("clientes").OnceAsync<Clientes>()).Where(a => a.Object.Codigo ==item.Codigo ).FirstOrDefault();

            await firebase.Child("clientes").Child(toUpdate.Key).PutAsync(new Clientes()
            {
                Codigo = item.Codigo
            });
        
        }

       
    }
}
