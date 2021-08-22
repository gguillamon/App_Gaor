using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UNO_CINCO.Models;

namespace UNO_CINCO.Services
{
    class ContactoService : IDataStore<Contactos>
    {
        readonly List<Contactos> contactos;

        public async Task<bool> AddItemAsync(Contactos contacto)
        {
            contactos.Add(contacto);

            return await Task.FromResult(true);
        }

        public async Task<bool> DeleteItemAsync(string id)
        {
            var oldItem = contactos.Where((Contactos arg) => arg.Id == id).FirstOrDefault();
            contactos.Remove(oldItem);

            return await Task.FromResult(true);
        }

        public async Task<Contactos> GetItemAsync(string id)
        {
            return await Task.FromResult(contactos.FirstOrDefault(s => s.Id == id));
        }

        public async Task<IEnumerable<Contactos>> GetItemsAsync(bool forceRefresh = false)
        {
            return await Task.FromResult(contactos);
        }

        async Task<bool> IDataStore<Contactos>.UpdateItemAsync(Contactos contacto)
        {
            var oldItem = contactos.Where((Contactos arg) => arg.Id == contacto.Id).FirstOrDefault();
            contactos.Remove(oldItem);
            contactos.Add(contacto);

            return await Task.FromResult(true);
        }
    }
}
