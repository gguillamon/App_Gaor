using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UNO_CINCO.Models;

namespace UNO_CINCO.Services
{
    class ClienteService : IDataStore<Clientes>
    {
        readonly List<Clientes> clientes;

        public async Task<bool> AddItemAsync(Clientes cliente)
        {
            clientes.Add(cliente);

            return await Task.FromResult(true);
        }

        public async Task<bool> DeleteItemAsync(string codigo)
        {
            var oldItem = clientes.Where((Clientes arg) => arg.codigo == codigo).FirstOrDefault();
            clientes.Remove(oldItem);

            return await Task.FromResult(true);
        }

        public async Task<Clientes> GetItemAsync(string codigo)
        {
            return await Task.FromResult(clientes.FirstOrDefault(s => s.codigo == codigo));
        }

        public async Task<IEnumerable<Clientes>> GetItemsAsync(bool forceRefresh = false)
        {
            return await Task.FromResult(clientes);
        }

        async Task<bool> IDataStore<Clientes>.UpdateItemAsync(Clientes cliente)
        {
            var oldItem = clientes.Where((Clientes arg) => arg.codigo == cliente.codigo).FirstOrDefault();
            clientes.Remove(oldItem);
            clientes.Add(cliente);

            return await Task.FromResult(true);
        }
    }
}
