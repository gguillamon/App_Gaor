using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using UNO_CINCO.Models;

namespace UNO_CINCO.Services
{
    class ParteAsistFireStore : IDataToFireBase<PartesAsistencia>
    {
        public Task AddItemToDB(PartesAsistencia itemModel)
        {
            throw new NotImplementedException();
        }

        public Task DeleteItem(int item)
        {
            throw new NotImplementedException();
        }

        public Task<List<PartesAsistencia>> ShowAllItemsDB()
        {
            throw new NotImplementedException();
        }

        public Task<PartesAsistencia> ShowItemAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateCodItem(PartesAsistencia item)
        {
            throw new NotImplementedException();
        }
    }
}
