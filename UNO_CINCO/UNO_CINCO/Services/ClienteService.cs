using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UNO_CINCO.Models;

namespace UNO_CINCO.Services
{
    public class ClienteService : IDataStore<Clientes>
    {
        readonly List<Clientes> clientes;

        public ClienteService()
        {
            clientes = new List<Clientes>()
            {
                new Clientes { Codigo = "12311", Nombre = "Empresa 1" },
                new Clientes { Codigo=  "12312", Nombre = "Empresa 2" },
                new Clientes { Codigo = "12313", Nombre = "Empresa 3" },
                new Clientes { Codigo = "12314", Nombre = "Empresa 4"},
                new Clientes { Codigo = "12315", Nombre = "Empresa 5" },
                new Clientes { Codigo = "12316", Nombre = "Empresa 6" }
            };
        }

        public async Task<bool> AddItemAsync(Clientes cliente)
        {
            clientes.Add(cliente);

            return await Task.FromResult(true);
        }

        public async Task<bool> DeleteItemAsync(string codigo)
        {
            var oldItem = clientes.Where((Clientes arg) => arg.Codigo == codigo).FirstOrDefault();
            clientes.Remove(oldItem);

            return await Task.FromResult(true);
        }

        public async Task<Clientes> GetItemAsync(string codigo)
        {
            return await Task.FromResult(clientes.FirstOrDefault(s => s.Codigo == codigo));
        }

        public async Task<IEnumerable<Clientes>> GetItemsAsync(bool forceRefresh = false)
        {
            return await Task.FromResult(clientes);
        }

        async Task<bool> IDataStore<Clientes>.UpdateItemAsync(Clientes cliente)
        {
            var oldItem = clientes.Where((Clientes arg) => arg.Codigo == cliente.Codigo).FirstOrDefault();
            clientes.Remove(oldItem);
            clientes.Add(cliente);

            return await Task.FromResult(true);
        }
    }
}
