using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UNO_CINCO.Models;

namespace UNO_CINCO.Services
{
    public class ParteAsistService : IDataStore<PartesAsistencia>
    {
        readonly List<PartesAsistencia> partes;
        public ParteAsistService()
        {
            partes = new List<PartesAsistencia>()
            {
                new PartesAsistencia { IdParte = Guid.NewGuid().ToString(), CodigoEmpresa = "" },
                new PartesAsistencia { IdParte = Guid.NewGuid().ToString(), CodigoEmpresa = ""},
                new PartesAsistencia { IdParte = Guid.NewGuid().ToString(), CodigoEmpresa = ""},
                new PartesAsistencia { IdParte = Guid.NewGuid().ToString(), CodigoEmpresa = ""},
                new PartesAsistencia { IdParte = Guid.NewGuid().ToString(), CodigoEmpresa = "" },
                new PartesAsistencia { IdParte = Guid.NewGuid().ToString(), CodigoEmpresa = "" }
            };
        }

        public async Task<bool> AddItemAsync(PartesAsistencia parte)
        {
            partes.Add(parte);

            return await Task.FromResult(true);
        }

        public async Task<bool> DeleteItemAsync(string id)
        {
            var oldItem = partes.Where((PartesAsistencia arg) => arg.IdParte == id).FirstOrDefault();
            partes.Remove(oldItem);

            return await Task.FromResult(true);
        }

        public async Task<PartesAsistencia> GetItemAsync(string id)
        {
            return await Task.FromResult(partes.FirstOrDefault(s => s.IdParte == id));
        }

        public async Task<IEnumerable<PartesAsistencia>> GetItemsAsync(bool forceRefresh = false)
        {
            return await Task.FromResult(partes);
        }

        async Task<bool> IDataStore<PartesAsistencia>.UpdateItemAsync(PartesAsistencia parte)
        {
            var oldItem = partes.Where((PartesAsistencia arg) => arg.IdParte == parte.IdParte).FirstOrDefault();
            partes.Remove(oldItem);
            partes.Add(parte);

            return await Task.FromResult(true);
        }
    }
}
