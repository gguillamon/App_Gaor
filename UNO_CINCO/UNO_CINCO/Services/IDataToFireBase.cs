using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace UNO_CINCO.Services
{
    public interface IDataToFireBase<T>
    {
        Task AddItemToDB(T itemModel);
        Task<T> ShowItemAsync(int id);
        Task<List<T>> ShowAllItemsDB();
        Task UpdateCodItem(T item);
        Task DeleteItem(int item);

    }
}
